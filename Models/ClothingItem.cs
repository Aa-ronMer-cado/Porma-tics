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

        // Main category: TOPS, BOTTOMS, SHOES, ACCESSORIES
        public string Category { get; set; } = string.Empty;

        // Specific type: Hoodie, Jeans, Sneakers, Watch, etc.
        public string ClothingType { get; set; } = string.Empty;

        // Can contain multiple values separated by comma
        public string Color { get; set; } = string.Empty;

        public string Style { get; set; } = string.Empty;

        public string Season { get; set; } = string.Empty;

        public string ImageFileName { get; set; } = string.Empty;

        public DateTime DateAdded { get; set; } = DateTime.Now;

        [JsonIgnore]
        public bool HasImage =>
            !string.IsNullOrWhiteSpace(ImageFileName);

        [JsonIgnore]
        public string ImageFullPath =>
            HasImage
                ? Path.Combine(StorageService.ImagesFolder, ImageFileName)
                : string.Empty;

        [JsonIgnore]
        public bool ImageExists =>
            HasImage && File.Exists(ImageFullPath);

        public void Normalize()
        {
            Name = Name.Trim();
            Category = Category.Trim().ToUpperInvariant();
            ClothingType = ClothingType.Trim();
            Color = Color.Trim();
            Style = Style.Trim();
            Season = Season.Trim();
            ImageFileName = ImageFileName.Trim();
        }
    }
}