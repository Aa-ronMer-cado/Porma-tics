using Newtonsoft.Json;
using Pormatics.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace Pormatics.Data
{
    /// <summary>
    /// Central data-access layer.  All reads and writes go through here.
    /// Folder layout (created automatically on first run):
    ///   %AppData%\Pormatics\
    ///       clothes.json
    ///       Images\
    ///           {guid}.png / .jpg / ...
    /// </summary>
    public static class StorageService
    {
        // ── Paths ────────────────────────────────────────────────────
        private static readonly string RootFolder =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Pormatics");

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
            string json = JsonConvert.SerializeObject(items, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonPath, json);
        }

        // ── Add one item + copy its image ────────────────────────────
        /// <summary>
        /// Saves metadata and copies the source image into the Images folder.
        /// Returns the saved item (with ImageFileName populated).
        /// </summary>
        public static ClothingItem AddItem(ClothingItem item, string sourceImagePath)
        {
            if (!string.IsNullOrEmpty(sourceImagePath) && File.Exists(sourceImagePath))
            {
                string ext = Path.GetExtension(sourceImagePath);
                string fileName = item.Id + ext;
                File.Copy(sourceImagePath, Path.Combine(ImagesFolder, fileName), overwrite: true);
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
            if (target == null) return;

            // Remove image file
            string imgPath = target.ImageFullPath;
            if (File.Exists(imgPath))
                File.Delete(imgPath);

            all.Remove(target);
            SaveAll(all);
        }

        // ── Filter helpers ───────────────────────────────────────────
        public static List<ClothingItem> LoadByCategory(string category) =>
            LoadAll().Where(c => c.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();

        public static List<ClothingItem> LoadByStyle(string style) =>
            LoadAll().Where(c => c.Style.Equals(style, StringComparison.OrdinalIgnoreCase)).ToList();

        public static List<ClothingItem> LoadBySeason(string season) =>
            LoadAll().Where(c => c.Season.Equals(season, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}