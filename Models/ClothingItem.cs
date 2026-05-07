using System;

namespace Pormatics.Models
{
    public class ClothingItem
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; } = string.Empty;

        // Main closet category
        public string Category { get; set; } = string.Empty;
        // TOPS, BOTTOMS, SHOES, ACCESSORIES

        // Specific clothing type
        public string ClothingType { get; set; } = string.Empty;
        // Hoodie, Jeans, Sneakers, Watch, etc.

        public string Color { get; set; } = string.Empty;
        public string Style { get; set; } = string.Empty;
        public string Season { get; set; } = string.Empty;

        public string ImageFileName { get; set; } = string.Empty;
        public DateTime DateAdded { get; set; } = DateTime.Now;

        [Newtonsoft.Json.JsonIgnore]
        public string ImageFullPath =>
            System.IO.Path.Combine(
                Pormatics.Data.StorageService.ImagesFolder,
                ImageFileName
            );
    }
}