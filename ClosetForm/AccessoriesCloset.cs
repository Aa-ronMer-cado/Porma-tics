namespace Pormatics.ClosetForm
{
    public partial class AccessoriesCloset : ClosetBase
    {
        public AccessoriesCloset()
        {
            CategoryFilter = "ACCESSORIES";
            LoadItems();
        }
    }
}