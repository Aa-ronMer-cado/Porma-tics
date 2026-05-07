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
            Directory.CreateDirectory(RootFolder);
            Directory.CreateDirectory(ImagesFolder);
        }

        public static List<ClothingItem> LoadAll()
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

        private static void SaveAll(List<ClothingItem> items)
        {
            Directory.CreateDirectory(RootFolder);

            string json = JsonConvert.SerializeObject(items, Formatting.Indented);

            File.WriteAllText(ClothesJsonPath, json);
        }

        public static ClothingItem AddItem(ClothingItem item, string sourceImagePath)
        {
            Directory.CreateDirectory(ImagesFolder);

            if (!string.IsNullOrWhiteSpace(sourceImagePath) &&
                File.Exists(sourceImagePath))
            {
                string ext = Path.GetExtension(sourceImagePath);
                string fileName = item.Id + ext;
                string destinationPath = Path.Combine(ImagesFolder, fileName);

                File.Copy(sourceImagePath, destinationPath, overwrite: true);

                item.ImageFileName = fileName;
            }

            List<ClothingItem> all = LoadAll();

            all.Add(item);

            SaveAll(all);

            return item;
        }

        public static void DeleteItem(string id)
        {
            List<ClothingItem> all = LoadAll();

            ClothingItem? target = all.FirstOrDefault(c => c.Id == id);

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
                // Avoid crash if file is locked.
            }

            all.Remove(target);

            SaveAll(all);
        }

        public static void UpdateItem(ClothingItem updatedItem)
        {
            List<ClothingItem> all = LoadAll();

            int index = all.FindIndex(c => c.Id == updatedItem.Id);

            if (index == -1)
                return;

            all[index] = updatedItem;

            SaveAll(all);
        }

        public static List<ClothingItem> LoadByCategory(string category)
        {
            return LoadAll()
                .Where(c => c.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public static List<ClothingItem> FilterItems(
            string? category,
            string? style,
            string? season,
            string? color)
        {
            return LoadAll()
                .Where(c =>
                    (string.IsNullOrWhiteSpace(category) ||
                     c.Category.Equals(category, StringComparison.OrdinalIgnoreCase)) &&

                    (string.IsNullOrWhiteSpace(style) ||
                     c.Style.Equals(style, StringComparison.OrdinalIgnoreCase)) &&

                    (string.IsNullOrWhiteSpace(season) ||
                     c.Season.Equals(season, StringComparison.OrdinalIgnoreCase)) &&

                    (string.IsNullOrWhiteSpace(color) ||
                     c.Color.Equals(color, StringComparison.OrdinalIgnoreCase)))
                .ToList();
        }

        public static List<FavoriteOutfitItem> LoadFavoriteOutfits()
        {
            if (!File.Exists(FavoritesJsonPath))
                return new List<FavoriteOutfitItem>();

            try
            {
                string json = File.ReadAllText(FavoritesJsonPath);

                return JsonConvert.DeserializeObject<List<FavoriteOutfitItem>>(json)
                       ?? new List<FavoriteOutfitItem>();
            }
            catch
            {
                return new List<FavoriteOutfitItem>();
            }
        }

        public static void SaveFavoriteOutfit(GeneratedOutfit outfit)
        {
            if (outfit.Top == null || outfit.Bottom == null || outfit.Shoes == null)
                throw new InvalidOperationException("Cannot save an incomplete outfit.");

            List<FavoriteOutfitItem> favorites = LoadFavoriteOutfits();

            var favorite = new FavoriteOutfitItem
            {
                TopId = outfit.Top.Id,
                BottomId = outfit.Bottom.Id,
                ShoesId = outfit.Shoes.Id,
                AccessoryId = outfit.Accessory?.Id ?? string.Empty
            };

            favorites.Add(favorite);

            string json = JsonConvert.SerializeObject(favorites, Formatting.Indented);

            File.WriteAllText(FavoritesJsonPath, json);
        }

        public static ClothingItem? FindClothingById(string id)
        {
            return LoadAll().FirstOrDefault(c => c.Id == id);
        }
    }
}