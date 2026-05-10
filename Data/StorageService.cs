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

        public static List<ClothingItem> LoadClothes()
        {
            return LoadJson<List<ClothingItem>>(ClothesJsonPath) ?? new List<ClothingItem>();
        }

        public static List<ClothingItem> LoadAll()
        {
            return LoadClothes();
        }

        private static void SaveClothes(List<ClothingItem> clothes)
        {
            SaveJson(ClothesJsonPath, clothes);
        }

        public static ClothingItem AddItem(ClothingItem item, string sourceImagePath)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            EnsureFoldersExist();

            if (string.IsNullOrWhiteSpace(item.Id))
                item.Id = Guid.NewGuid().ToString();

            item.DateAdded = item.DateAdded == default
                ? DateTime.Now
                : item.DateAdded;

            item.Category = item.Category.Trim();
            item.ClothingType = item.ClothingType.Trim();
            item.Color = item.Color.Trim();
            item.Style = item.Style.Trim();
            item.Season = item.Season.Trim();

            item.ImageFileName = CopyImageToStorage(item.Id, sourceImagePath);

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
                .FirstOrDefault(c => c.Id.Equals(id, StringComparison.OrdinalIgnoreCase));

            if (target == null)
                return;

            DeleteImage(target.ImageFullPath);

            clothes.Remove(target);
            SaveClothes(clothes);
        }

        public static void UpdateItem(ClothingItem updatedItem)
        {
            if (updatedItem == null || string.IsNullOrWhiteSpace(updatedItem.Id))
                return;

            List<ClothingItem> clothes = LoadClothes();

            int index = clothes.FindIndex(c =>
                c.Id.Equals(updatedItem.Id, StringComparison.OrdinalIgnoreCase));

            if (index == -1)
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
                    c.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        public static List<ClothingItem> LoadByCategory(string category)
        {
            if (string.IsNullOrWhiteSpace(category))
                return new List<ClothingItem>();

            return LoadClothes()
                .Where(c => TextEquals(c.Category, category))
                .ToList();
        }

        public static List<ClothingItem> FilterItems(
            string? category,
            string? style,
            string? season,
            string? color)
        {
            return LoadClothes()
                .Where(c =>
                    MatchesSingle(c.Category, category) &&
                    MatchesMultiValue(c.Style, style) &&
                    MatchesMultiValue(c.Season, season) &&
                    MatchesMultiValue(c.Color, color))
                .ToList();
        }

        public static List<FavoriteOutfitItem> LoadFavoriteOutfits()
        {
            return LoadJson<List<FavoriteOutfitItem>>(FavoritesJsonPath)
                   ?? new List<FavoriteOutfitItem>();
        }

        public static void SaveFavoriteOutfit(GeneratedOutfit outfit)
        {
            if (outfit == null)
                throw new ArgumentNullException(nameof(outfit));

            if (outfit.Top == null || outfit.Bottom == null || outfit.Shoes == null)
                throw new InvalidOperationException("Cannot save incomplete outfit.");

            List<FavoriteOutfitItem> favorites = LoadFavoriteOutfits();

            FavoriteOutfitItem favorite = new FavoriteOutfitItem
            {
                TopId = outfit.Top.Id,
                BottomId = outfit.Bottom.Id,
                ShoesId = outfit.Shoes.Id,
                AccessoryId = outfit.Accessory?.Id ?? string.Empty,
                DateSaved = DateTime.Now
            };

            favorites.Add(favorite);

            SaveFavoriteOutfits(favorites);
        }

        public static void SaveFavoriteOutfits(List<FavoriteOutfitItem> favorites)
        {
            SaveJson(FavoritesJsonPath, favorites ?? new List<FavoriteOutfitItem>());
        }

        private static string CopyImageToStorage(string itemId, string sourceImagePath)
        {
            if (string.IsNullOrWhiteSpace(sourceImagePath) || !File.Exists(sourceImagePath))
                return string.Empty;

            string extension = Path.GetExtension(sourceImagePath);

            if (string.IsNullOrWhiteSpace(extension))
                extension = ".png";

            string fileName = itemId + extension;
            string destinationPath = Path.Combine(ImagesFolder, fileName);

            File.Copy(sourceImagePath, destinationPath, true);

            return fileName;
        }

        private static void DeleteImage(string imagePath)
        {
            if (string.IsNullOrWhiteSpace(imagePath) || !File.Exists(imagePath))
                return;

            try
            {
                File.Delete(imagePath);
            }
            catch
            {
                // Ignore image delete errors to prevent app crash.
            }
        }

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

        private static void SaveJson<T>(string path, T data)
        {
            EnsureFoldersExist();

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);

            File.WriteAllText(path, json);
        }

        private static bool MatchesSingle(string itemValue, string? selectedValue)
        {
            if (string.IsNullOrWhiteSpace(selectedValue))
                return true;

            return TextEquals(itemValue, selectedValue);
        }

        private static bool MatchesMultiValue(string itemValue, string? selectedValue)
        {
            if (string.IsNullOrWhiteSpace(selectedValue))
                return true;

            return SplitValues(itemValue)
                .Any(value => TextEquals(value, selectedValue));
        }

        private static List<string> SplitValues(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return new List<string>();

            return value
                .Split(',')
                .Select(v => v.Trim())
                .Where(v => !string.IsNullOrWhiteSpace(v))
                .ToList();
        }

        private static bool TextEquals(string first, string second)
        {
            return string.Equals(
                first?.Trim(),
                second?.Trim(),
                StringComparison.OrdinalIgnoreCase);
        }
    }
}