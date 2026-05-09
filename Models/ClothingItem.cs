using System;
using System.IO;
using Newtonsoft.Json;
using Pormatics.Data;

namespace Pormatics.Models
{
    public class ClothingItem
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; } = string.Empty;

        // Main closet category:
        // Top, Bottom, Shoes, Accessory
        public string Category { get; set; } = string.Empty;

        // Specific clothing type:
        // Hoodie, Jeans, Sneakers, Watch, etc.
        public string ClothingType { get; set; } = string.Empty;

        public string Color { get; set; } = string.Empty;

        public string Style { get; set; } = string.Empty;

        public string Season { get; set; } = string.Empty;

        public string ImageFileName { get; set; } = string.Empty;

        public DateTime DateAdded { get; set; } = DateTime.Now;

        [JsonIgnore]
        public string ImageFullPath
        {
            get
            {
                if (string.IsNullOrWhiteSpace(ImageFileName))
                    return string.Empty;

                return Path.Combine(StorageService.ImagesFolder, ImageFileName);
            }
        }
    }
}