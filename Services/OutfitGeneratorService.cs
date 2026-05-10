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
            List<ClothingItem> tops = FilterClothes("TOPS", filter);
            List<ClothingItem> bottoms = FilterClothes("BOTTOMS", filter);
            List<ClothingItem> shoes = FilterClothes("SHOES", filter);
            List<ClothingItem> accessories = FilterClothes("ACCESSORIES", filter);

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

        private static List<ClothingItem> FilterClothes(string category, OutfitFilter filter)
        {
            return StorageService.LoadAll()
                .Where(item =>
                    item.Category.Equals(category, StringComparison.OrdinalIgnoreCase) &&

                    item.Season.Equals(filter.Season, StringComparison.OrdinalIgnoreCase) &&

                    filter.Styles.Any(style =>
                        item.Style.Equals(style, StringComparison.OrdinalIgnoreCase)) &&

                    filter.Colors.Any(color =>
                        item.Color.Equals(color, StringComparison.OrdinalIgnoreCase))
                )
                .ToList();
        }

        private static ClothingItem PickRandom(List<ClothingItem> items)
        {
            return items[random.Next(items.Count)];
        }
    }
}