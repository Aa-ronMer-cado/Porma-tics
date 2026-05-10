using Newtonsoft.Json;
using Pormatics.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Pormatics.Data
{
    public static class StorageService
    {
        private static readonly string RootFolder =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Pormatics");

        public static readonly string ImagesFolder =
            Path.Combine(RootFolder, "Images");

        private static readonly string ClothesJsonPath =
            Path.Combine(RootFolder, "clothes.json");

        private static readonly string FavoritesJsonPath =
            Path.Combine(RootFolder, "favoriteOutfits.json");

        static StorageService()
        {
            EnsureFoldersExist();
        }

        private static void EnsureFoldersExist()
        {
            Directory.CreateDirectory(RootFolder);
            Directory.CreateDirectory(ImagesFolder);
        }

        // =========================================================
        // CLOTHES
        // =========================================================

        public static List<ClothingItem> LoadClothes()
        {
            return LoadJson<List<ClothingItem>>(ClothesJsonPath)
                   ?? new List<ClothingItem>();
        }

        // Backward compatibility
        public static List<ClothingItem> LoadAll()
        {
            return LoadClothes();
        }

        private static void SaveClothes(List<ClothingItem> clothes)
        {
            SaveJson(ClothesJsonPath, clothes);
        }

        public static ClothingItem AddItem(
            ClothingItem item,
            string sourceImagePath)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            EnsureFoldersExist();

            NormalizeItem(item);

            item.ImageFileName =
                CopyImageToStorage(item.Id, sourceImagePath);

            List<ClothingItem> clothes = LoadClothes();

            clothes.Add(item);

            SaveClothes(clothes);

            return item;
        }

        public static void DeleteItem(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return;

            List<ClothingItem> clothes = LoadClothes();

            ClothingItem? target = clothes
                .FirstOrDefault(c =>
                    TextEquals(c.Id, id));

            if (target == null)
                return;

            DeleteImage(target.ImageFullPath);

            clothes.Remove(target);

            SaveClothes(clothes);
        }

        public static void UpdateItem(ClothingItem updatedItem)
        {
            if (updatedItem == null ||
                string.IsNullOrWhiteSpace(updatedItem.Id))
            {
                return;
            }

            NormalizeItem(updatedItem);

            List<ClothingItem> clothes = LoadClothes();

            int index = clothes.FindIndex(c =>
                TextEquals(c.Id, updatedItem.Id));

            if (index < 0)
                return;

            clothes[index] = updatedItem;

            SaveClothes(clothes);
        }

        public static ClothingItem? FindClothingById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return null;

            return LoadClothes()
                .FirstOrDefault(c =>
                    TextEquals(c.Id, id));
        }

        public static List<ClothingItem> LoadByCategory(string category)
        {
            if (string.IsNullOrWhiteSpace(category))
                return new List<ClothingItem>();

            return LoadClothes()
                .Where(c =>
                    TextEquals(c.Category, category))
                .ToList();
        }

        public static List<ClothingItem> FilterItems(
            string? category,
            string? style,
            string? season,
            string? color)
        {
            List<ClothingItem> clothes = LoadClothes();

            return clothes
                .Where(c =>
                    MatchesSingle(c.Category, category) &&
                    MatchesMultiValue(c.Style, style) &&
                    MatchesMultiValue(c.Season, season) &&
                    MatchesMultiValue(c.Color, color))
                .ToList();
        }

        // =========================================================
        // FAVORITES
        // =========================================================

        public static List<FavoriteOutfitItem> LoadFavoriteOutfits()
        {
            return LoadJson<List<FavoriteOutfitItem>>(FavoritesJsonPath)
                   ?? new List<FavoriteOutfitItem>();
        }

        public static void SaveFavoriteOutfit(
            GeneratedOutfit outfit)
        {
            if (outfit == null)
                throw new ArgumentNullException(nameof(outfit));

            if (outfit.Top == null ||
                outfit.Bottom == null ||
                outfit.Shoes == null)
            {
                throw new InvalidOperationException(
                    "Cannot save incomplete outfit.");
            }

            List<FavoriteOutfitItem> favorites =
                LoadFavoriteOutfits();

            favorites.Add(new FavoriteOutfitItem
            {
                TopId = outfit.Top.Id,
                BottomId = outfit.Bottom.Id,
                ShoesId = outfit.Shoes.Id,
                AccessoryId = outfit.Accessory?.Id ?? string.Empty,
                DateSaved = DateTime.Now
            });

            SaveFavoriteOutfits(favorites);
        }

        public static void SaveFavoriteOutfits(
            List<FavoriteOutfitItem> favorites)
        {
            SaveJson(
                FavoritesJsonPath,
                favorites ?? new List<FavoriteOutfitItem>());
        }

        // =========================================================
        // IMAGE HELPERS
        // =========================================================

        private static string CopyImageToStorage(
            string itemId,
            string sourceImagePath)
        {
            if (string.IsNullOrWhiteSpace(sourceImagePath) ||
                !File.Exists(sourceImagePath))
            {
                return string.Empty;
            }

            string extension =
                Path.GetExtension(sourceImagePath);

            if (string.IsNullOrWhiteSpace(extension))
                extension = ".png";

            string fileName = itemId + extension;

            string destinationPath =
                Path.Combine(ImagesFolder, fileName);

            File.Copy(
                sourceImagePath,
                destinationPath,
                true);

            return fileName;
        }

        private static void DeleteImage(string imagePath)
        {
            if (string.IsNullOrWhiteSpace(imagePath) ||
                !File.Exists(imagePath))
            {
                return;
            }

            try
            {
                File.Delete(imagePath);
            }
            catch
            {
                // Ignore image delete errors
            }
        }

        // =========================================================
        // JSON HELPERS
        // =========================================================

        private static T? LoadJson<T>(string path)
        {
            if (!File.Exists(path))
                return default;

            try
            {
                string json = File.ReadAllText(path);

                if (string.IsNullOrWhiteSpace(json))
                    return default;

                return JsonConvert.DeserializeObject<T>(json);
            }
            catch
            {
                return default;
            }
        }

        private static void SaveJson<T>(
            string path,
            T data)
        {
            EnsureFoldersExist();

            string json =
                JsonConvert.SerializeObject(
                    data,
                    Formatting.Indented);

            File.WriteAllText(path, json);
        }

        // =========================================================
        // FILTER HELPERS
        // =========================================================

        private static bool MatchesSingle(
            string itemValue,
            string? selectedValue)
        {
            if (string.IsNullOrWhiteSpace(selectedValue))
                return true;

            return TextEquals(itemValue, selectedValue);
        }

        private static bool MatchesMultiValue(
            string itemValue,
            string? selectedValue)
        {
            if (string.IsNullOrWhiteSpace(selectedValue))
                return true;

            string[] values = SplitValues(itemValue);

            for (int i = 0; i < values.Length; i++)
            {
                if (TextEquals(values[i], selectedValue))
                    return true;
            }

            return false;
        }

        private static string[] SplitValues(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return Array.Empty<string>();

            return value
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(v => v.Trim())
                .ToArray();
        }

        private static bool TextEquals(
            string first,
            string second)
        {
            return string.Equals(
                first?.Trim(),
                second?.Trim(),
                StringComparison.OrdinalIgnoreCase);
        }

        // =========================================================
        // NORMALIZATION
        // =========================================================

        private static void NormalizeItem(ClothingItem item)
        {
            if (string.IsNullOrWhiteSpace(item.Id))
                item.Id = Guid.NewGuid().ToString();

            if (item.DateAdded == default)
                item.DateAdded = DateTime.Now;

            item.Name = item.Name?.Trim() ?? string.Empty;
            item.Category = item.Category?.Trim() ?? string.Empty;
            item.ClothingType = item.ClothingType?.Trim() ?? string.Empty;
            item.Color = item.Color?.Trim() ?? string.Empty;
            item.Style = item.Style?.Trim() ?? string.Empty;
            item.Season = item.Season?.Trim() ?? string.Empty;
        }
    }
}