// ============================================================
//  TopCloset.cs
// ============================================================
namespace Pormatics.ClosetForm
{
    public partial class TopCloset : ClosetBase
    {
        public TopCloset()
        {
            CategoryFilter = "TOPS";
            LoadItems();
        }
    }
}