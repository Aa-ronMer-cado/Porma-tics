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
        // ── Paths ────────────────────────────────────────────────────
        private static readonly string RootFolder =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Pormatics");

        public static readonly string ImagesFolder =
            Path.Combine(RootFolder, "Images");

        private static readonly string JsonPath =
            Path.Combine(RootFolder, "clothes.json");

        // ── Ensure folders exist ─────────────────────────────────────
        static StorageService()
        {
            Directory.CreateDirectory(RootFolder);
            Directory.CreateDirectory(ImagesFolder);
        }

        // ── Read all items ───────────────────────────────────────────
        public static List<ClothingItem> LoadAll()
        {
            if (!File.Exists(JsonPath))
                return new List<ClothingItem>();

            try
            {
                string json = File.ReadAllText(JsonPath);

                return JsonConvert.DeserializeObject<List<ClothingItem>>(json)
                       ?? new List<ClothingItem>();
            }
            catch
            {
                return new List<ClothingItem>();
            }
        }

        // ── Write all items ──────────────────────────────────────────
        private static void SaveAll(List<ClothingItem> items)
        {
            Directory.CreateDirectory(RootFolder);

            string json = JsonConvert.SerializeObject(
                items,
                Formatting.Indented);

            File.WriteAllText(JsonPath, json);
        }

        // ── Add one item + copy image ────────────────────────────────
        public static ClothingItem AddItem(
            ClothingItem item,
            string sourceImagePath)
        {
            Directory.CreateDirectory(ImagesFolder);

            if (!string.IsNullOrEmpty(sourceImagePath) &&
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

        // ── Delete one item ──────────────────────────────────────────
        public static void DeleteItem(string id)
        {
            List<ClothingItem> all = LoadAll();

            ClothingItem? target = all.FirstOrDefault(c => c.Id == id);

            if (target == null)
                return;

            // Remove image file from Images folder
            string imgPath = target.ImageFullPath;

            try
            {
                if (!string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
                {
                    File.Delete(imgPath);
                }
            }
            catch
            {
                // Ignore file delete errors.
                // This prevents crashes if the image is still locked.
            }

            // Remove item from clothes.json
            all.Remove(target);

            SaveAll(all);
        }

        // ── Filter helpers ───────────────────────────────────────────
        public static List<ClothingItem> LoadByCategory(string category)
        {
            return LoadAll()
                .Where(c =>
                    c.Category.Equals(
                        category,
                        StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public static List<ClothingItem> LoadByStyle(string style)
        {
            return LoadAll()
                .Where(c =>
                    c.Style.Equals(
                        style,
                        StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public static List<ClothingItem> LoadBySeason(string season)
        {
            return LoadAll()
                .Where(c =>
                    c.Season.Equals(
                        season,
                        StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}