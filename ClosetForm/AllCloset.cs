// ============================================================
//  AllCloset.cs  —  shows every clothing item
// ============================================================
namespace Pormatics.ClosetForm
{
    public partial class AllCloset : ClosetBase
    {
        public AllCloset()
        {
            CategoryFilter = null;   // null = all categories
            LoadItems();
        }
    }
}