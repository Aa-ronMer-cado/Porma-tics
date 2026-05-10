namespace Pormatics.Models
{
    public class OutfitFilter
    {
        public string Season { get; set; } = string.Empty;

        public List<string> Styles { get; set; } = new();

        public List<string> Colors { get; set; } = new();
    }
}