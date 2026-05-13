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

        private static readonly Dictionary<string, string[]> StyleCombinations = new()
        {
            ["Casual"] = new[] { "Casual", "Streetwear", "Minimalist", "Smart Casual" },
            ["Formal"] = new[] { "Formal", "Business", "Smart Casual" },
            ["Streetwear"] = new[] { "Streetwear", "Casual", "Athletic" },
            ["Minimalist"] = new[] { "Minimalist", "Casual", "Smart Casual", "Business" },
            ["Romantic"] = new[] { "Romantic", "Formal", "Smart Casual" },
            ["Retro"] = new[] { "Retro", "Streetwear", "Casual" },
            ["Smart Casual"] = new[] { "Smart Casual", "Casual", "Business", "Formal", "Minimalist" },
            ["Athletic"] = new[] { "Athletic", "Casual", "Streetwear" },
            ["Business"] = new[] { "Business", "Formal", "Smart Casual", "Minimalist" },
            ["Vacation"] = new[] { "Vacation", "Casual", "Romantic" }
        };

        private static readonly Dictionary<string, string[]> ColorCombinations = new()
        {
            ["White"] = new[] { "White", "Black", "Blue", "Brown", "Pink", "Green", "Gray", "Yellow", "Multi" },
            ["Black"] = new[] { "Black", "White", "Gray", "Red", "Brown", "Blue", "Pink" },
            ["Blue"] = new[] { "Blue", "White", "Gray", "Black", "Brown", "Yellow" },
            ["Brown"] = new[] { "Brown", "White", "Black", "Green", "Yellow", "Gray" },
            ["Pink"] = new[] { "Pink", "White", "Black", "Gray", "Brown" },
            ["Green"] = new[] { "Green", "White", "Brown", "Black", "Gray", "Yellow" },
            ["Red"] = new[] { "Red", "Black", "White", "Gray", "Blue" },
            ["Gray"] = new[] { "Gray", "White", "Black", "Blue", "Pink", "Green", "Brown", "Red" },
            ["Yellow"] = new[] { "Yellow", "White", "Blue", "Brown", "Green", "Gray" },
            ["Multi"] = new[] { "Multi", "White", "Black", "Gray" }
        };

        private static readonly Dictionary<string, string[]> SeasonCombinations = new()
        {
            ["Summer"] = new[] { "Summer" },
            ["Rainy"] = new[] { "Rainy" }
        };

        public static GeneratedOutfit GenerateOutfit(OutfitFilter filter)
        {
            List<ClothingItem> allClothes = StorageService.LoadAll();

            List<ClothingItem> tops = FilterClothes(allClothes, "TOPS", filter);
            List<ClothingItem> bottoms = FilterClothes(allClothes, "BOTTOMS", filter);
            List<ClothingItem> shoes = FilterClothes(allClothes, "SHOES", filter);
            List<ClothingItem> accessories = FilterClothes(allClothes, "ACCESSORIES", filter);

            if (tops.Count == 0)
                throw new InvalidOperationException("No matching top found.");

            if (bottoms.Count == 0)
                throw new InvalidOperationException("No matching bottom found.");

            if (shoes.Count == 0)
                throw new InvalidOperationException("No matching shoes found.");

            for (int attempt = 0; attempt < 100; attempt++)
            {
                ClothingItem top = PickRandom(tops);

                List<ClothingItem> matchingBottoms = bottoms
                    .Where(bottom => IsCompatible(top, bottom, filter))
                    .ToList();

                if (matchingBottoms.Count == 0)
                    continue;

                ClothingItem bottom = PickRandom(matchingBottoms);

                List<ClothingItem> matchingShoes = shoes
                    .Where(shoe =>
                        IsCompatible(top, shoe, filter) &&
                        IsCompatible(bottom, shoe, filter))
                    .ToList();

                if (matchingShoes.Count == 0)
                    continue;

                ClothingItem shoe = PickRandom(matchingShoes);

                List<ClothingItem> matchingAccessories = accessories
                    .Where(accessory =>
                        IsCompatible(top, accessory, filter) &&
                        IsCompatible(bottom, accessory, filter) &&
                        IsCompatible(shoe, accessory, filter))
                    .ToList();

                return new GeneratedOutfit
                {
                    Top = top,
                    Bottom = bottom,
                    Shoes = shoe,
                    Accessory = matchingAccessories.Count > 0
                        ? PickRandom(matchingAccessories)
                        : null
                };
            }

            return new GeneratedOutfit
            {
                Top = PickRandom(tops),
                Bottom = PickRandom(bottoms),
                Shoes = PickRandom(shoes),
                Accessory = accessories.Count > 0 ? PickRandom(accessories) : null
            };
        }

        private static List<ClothingItem> FilterClothes(
            List<ClothingItem> clothes,
            string category,
            OutfitFilter filter)
        {
            return clothes
                .Where(item =>
                    item.Category.Equals(category, StringComparison.OrdinalIgnoreCase) &&

                    MatchesAny(item.Season, filter.Seasons) &&
                    MatchesAny(item.Style, filter.Styles) &&
                    MatchesAny(item.Color, filter.Colors))
                .ToList();
        }

        private static bool IsCompatible(
            ClothingItem first,
            ClothingItem second,
            OutfitFilter filter)
        {
            return HasCompatibleStyle(first, second, filter) &&
                   HasCompatibleColor(first, second, filter) &&
                   HasCompatibleSeason(first, second, filter);
        }

        private static bool HasCompatibleStyle(
            ClothingItem first,
            ClothingItem second,
            OutfitFilter filter)
        {
            List<string> firstStyles = SplitValues(first.Style);
            List<string> secondStyles = SplitValues(second.Style);

            foreach (string selectedStyle in filter.Styles)
            {
                if (!StyleCombinations.ContainsKey(selectedStyle))
                    continue;

                string[] allowedStyles = StyleCombinations[selectedStyle];

                bool firstMatches = firstStyles.Any(style =>
                    allowedStyles.Contains(style, StringComparer.OrdinalIgnoreCase));

                bool secondMatches = secondStyles.Any(style =>
                    allowedStyles.Contains(style, StringComparer.OrdinalIgnoreCase));

                if (firstMatches && secondMatches)
                    return true;
            }

            return false;
        }

        private static bool HasCompatibleColor(
            ClothingItem first,
            ClothingItem second,
            OutfitFilter filter)
        {
            List<string> firstColors = SplitValues(first.Color);
            List<string> secondColors = SplitValues(second.Color);

            foreach (string selectedColor in filter.Colors)
            {
                if (!ColorCombinations.ContainsKey(selectedColor))
                    continue;

                string[] allowedColors = ColorCombinations[selectedColor];

                bool firstMatches = firstColors.Any(color =>
                    allowedColors.Contains(color, StringComparer.OrdinalIgnoreCase));

                bool secondMatches = secondColors.Any(color =>
                    allowedColors.Contains(color, StringComparer.OrdinalIgnoreCase));

                if (firstMatches && secondMatches)
                    return true;
            }

            return false;
        }

        private static bool HasCompatibleSeason(
            ClothingItem first,
            ClothingItem second,
            OutfitFilter filter)
        {
            List<string> firstSeasons = SplitValues(first.Season);
            List<string> secondSeasons = SplitValues(second.Season);

            foreach (string selectedSeason in filter.Seasons)
            {
                if (!SeasonCombinations.ContainsKey(selectedSeason))
                    continue;

                string[] allowedSeasons = SeasonCombinations[selectedSeason];

                bool firstMatches = firstSeasons.Any(season =>
                    allowedSeasons.Contains(season, StringComparer.OrdinalIgnoreCase));

                bool secondMatches = secondSeasons.Any(season =>
                    allowedSeasons.Contains(season, StringComparer.OrdinalIgnoreCase));

                if (firstMatches && secondMatches)
                    return true;
            }

            return false;
        }

        private static bool MatchesAny(string itemValue, List<string> selectedValues)
        {
            List<string> itemValues = SplitValues(itemValue);

            return selectedValues.Any(selected =>
                itemValues.Any(value =>
                    value.Equals(selected, StringComparison.OrdinalIgnoreCase)));
        }

        private static List<string> SplitValues(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return new List<string>();

            return value
                .Split(',')
                .Select(v => v.Trim())
                .Where(v => !string.IsNullOrWhiteSpace(v))
                .ToList();
        }

        private static ClothingItem PickRandom(List<ClothingItem> items)
        {
            return items[random.Next(items.Count)];
        }
    }
}