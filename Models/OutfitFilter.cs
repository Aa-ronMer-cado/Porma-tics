namespace Pormatics.Models
{
    public class OutfitFilter
    {
        public List<string> Seasons { get; set; } = new();

        public List<string> Styles { get; set; } = new();

        public List<string> Colors { get; set; } = new();
    }
}