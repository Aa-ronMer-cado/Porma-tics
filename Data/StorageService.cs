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
        // =========================================
        // PATHS
        // =========================================

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

        // =========================================
        // INITIALIZE
        // =========================================

        static StorageService()
        {
            Directory.CreateDirectory(RootFolder);
            Directory.CreateDirectory(ImagesFolder);
        }

        // =========================================
        // CLOTHES
        // =========================================

        public static List<ClothingItem> LoadClothes()
        {
            if (!File.Exists(ClothesJsonPath))
                return new List<ClothingItem>();

            try
            {
                string json = File.ReadAllText(ClothesJsonPath);

                return JsonConvert.DeserializeObject<List<ClothingItem>>(json)
                       ?? new List<ClothingItem>();
            }
            catch
            {
                return new List<ClothingItem>();
            }
        }

        // BACKWARD COMPATIBILITY
        // So old forms using LoadAll() still work
        public static List<ClothingItem> LoadAll()
        {
            return LoadClothes();
        }

        private static void SaveClothes(List<ClothingItem> clothes)
        {
            Directory.CreateDirectory(RootFolder);

            string json =
                JsonConvert.SerializeObject(
                    clothes,
                    Formatting.Indented);

            File.WriteAllText(ClothesJsonPath, json);
        }

        public static ClothingItem AddItem(
            ClothingItem item,
            string sourceImagePath)
        {
            Directory.CreateDirectory(ImagesFolder);

            if (!string.IsNullOrWhiteSpace(sourceImagePath) &&
                File.Exists(sourceImagePath))
            {
                string extension =
                    Path.GetExtension(sourceImagePath);

                string fileName =
                    item.Id + extension;

                string destinationPath =
                    Path.Combine(ImagesFolder, fileName);

                File.Copy(
                    sourceImagePath,
                    destinationPath,
                    true);

                item.ImageFileName = fileName;
            }

            List<ClothingItem> clothes = LoadClothes();

            clothes.Add(item);

            SaveClothes(clothes);

            return item;
        }

        public static void DeleteItem(string id)
        {
            List<ClothingItem> clothes =
                LoadClothes();

            ClothingItem? target =
                clothes.FirstOrDefault(c => c.Id == id);

            if (target == null)
                return;

            try
            {
                if (!string.IsNullOrWhiteSpace(target.ImageFullPath) &&
                    File.Exists(target.ImageFullPath))
                {
                    File.Delete(target.ImageFullPath);
                }
            }
            catch
            {
                // Prevent crash if image is locked
            }

            clothes.Remove(target);

            SaveClothes(clothes);
        }

        public static void UpdateItem(ClothingItem updatedItem)
        {
            List<ClothingItem> clothes =
                LoadClothes();

            int index =
                clothes.FindIndex(c => c.Id == updatedItem.Id);

            if (index == -1)
                return;

            clothes[index] = updatedItem;

            SaveClothes(clothes);
        }

        public static ClothingItem? FindClothingById(string id)
        {
            return LoadClothes()
                .FirstOrDefault(c => c.Id == id);
        }

        public static List<ClothingItem> LoadByCategory(string category)
        {
            return LoadClothes()
                .Where(c =>
                    c.Category.Equals(
                        category,
                        StringComparison.OrdinalIgnoreCase))
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

                    (string.IsNullOrWhiteSpace(category) ||
                     c.Category.Equals(
                         category,
                         StringComparison.OrdinalIgnoreCase))

                    &&

                    (string.IsNullOrWhiteSpace(style) ||
                     c.Style.Equals(
                         style,
                         StringComparison.OrdinalIgnoreCase))

                    &&

                    (string.IsNullOrWhiteSpace(season) ||
                     c.Season.Equals(
                         season,
                         StringComparison.OrdinalIgnoreCase))

                    &&

                    (string.IsNullOrWhiteSpace(color) ||
                     c.Color.Equals(
                         color,
                         StringComparison.OrdinalIgnoreCase))
                )
                .ToList();
        }

        // =========================================
        // FAVORITE OUTFITS
        // =========================================

        public static List<FavoriteOutfitItem> LoadFavoriteOutfits()
        {
            if (!File.Exists(FavoritesJsonPath))
                return new List<FavoriteOutfitItem>();

            try
            {
                string json =
                    File.ReadAllText(FavoritesJsonPath);

                return JsonConvert.DeserializeObject<List<FavoriteOutfitItem>>(json)
                       ?? new List<FavoriteOutfitItem>();
            }
            catch
            {
                return new List<FavoriteOutfitItem>();
            }
        }

        public static void SaveFavoriteOutfit(
            GeneratedOutfit outfit)
        {
            if (outfit.Top == null ||
                outfit.Bottom == null ||
                outfit.Shoes == null)
            {
                throw new InvalidOperationException(
                    "Cannot save incomplete outfit.");
            }

            List<FavoriteOutfitItem> favorites =
                LoadFavoriteOutfits();

            FavoriteOutfitItem favorite =
                new FavoriteOutfitItem
                {
                    TopId = outfit.Top.Id,
                    BottomId = outfit.Bottom.Id,
                    ShoesId = outfit.Shoes.Id,
                    AccessoryId = outfit.Accessory?.Id ?? "",
                    DateSaved = DateTime.Now
                };

            favorites.Add(favorite);

            SaveFavoriteOutfits(favorites);
        }

        public static void SaveFavoriteOutfits(
            List<FavoriteOutfitItem> favorites)
        {
            string json =
                JsonConvert.SerializeObject(
                    favorites,
                    Formatting.Indented);

            File.WriteAllText(FavoritesJsonPath, json);
        }
    }
}