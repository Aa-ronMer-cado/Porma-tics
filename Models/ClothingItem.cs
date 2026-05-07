using System;
using System.Collections.Generic;
using System.Text;

namespace Pormatics.Models
{
    public class ClothingItem
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;   // TOPS | BOTTOMS | SHOES | ACCESSORIES
        public string Color { get; set; } = string.Empty;
        public string Style { get; set; } = string.Empty;
        public string Season { get; set; } = string.Empty;
        public string ImageFileName { get; set; } = string.Empty; // e.g. "abc123.png"
        public DateTime DateAdded { get; set; } = DateTime.Now;

        // Resolved at runtime — never serialized
        [Newtonsoft.Json.JsonIgnore]
        public string ImageFullPath =>
            System.IO.Path.Combine(Pormatics.Data.StorageService.ImagesFolder, ImageFileName);
    }
}