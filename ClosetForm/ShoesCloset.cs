namespace Pormatics.ClosetForm
{
    public partial class ShoesCloset : ClosetBase
    {
        public ShoesCloset()
        {
            CategoryFilter = "SHOES";
            LoadItems();
        }
    }
}