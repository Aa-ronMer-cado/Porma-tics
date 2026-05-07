using Pormatics.Data;
using Pormatics.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pormatics.Services
{
    public static class OutfitGeneratorService
    {
        private static readonly Random random = new Random();

        public static GeneratedOutfit GenerateOutfit(OutfitFilter filter)
        {
            List<ClothingItem> tops = StorageService.FilterItems(
                "TOPS",
                filter.Style,
                filter.Season,
                filter.Color);

            List<ClothingItem> bottoms = StorageService.FilterItems(
                "BOTTOMS",
                filter.Style,
                filter.Season,
                string.Empty);

            List<ClothingItem> shoes = StorageService.FilterItems(
                "SHOES",
                filter.Style,
                filter.Season,
                string.Empty);

            List<ClothingItem> accessories = StorageService.FilterItems(
                "ACCESSORIES",
                filter.Style,
                filter.Season,
                string.Empty);

            if (tops.Count == 0)
                throw new InvalidOperationException("No matching top found.");

            if (bottoms.Count == 0)
                throw new InvalidOperationException("No matching bottom found.");

            if (shoes.Count == 0)
                throw new InvalidOperationException("No matching shoes found.");

            return new GeneratedOutfit
            {
                Top = PickRandom(tops),
                Bottom = PickRandom(bottoms),
                Shoes = PickRandom(shoes),
                Accessory = accessories.Count > 0 ? PickRandom(accessories) : null
            };
        }

        private static ClothingItem PickRandom(List<ClothingItem> items)
        {
            return items[random.Next(items.Count)];
        }
    }
}