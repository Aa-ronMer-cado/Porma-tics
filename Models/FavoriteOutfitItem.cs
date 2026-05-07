using System;

namespace Pormatics.Models
{
    public class FavoriteOutfitItem
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string TopId { get; set; } = string.Empty;
        public string BottomId { get; set; } = string.Empty;
        public string ShoesId { get; set; } = string.Empty;
        public string AccessoryId { get; set; } = string.Empty;

        public DateTime DateSaved { get; set; } = DateTime.Now;
    }
}