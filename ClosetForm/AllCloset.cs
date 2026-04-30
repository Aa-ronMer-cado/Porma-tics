using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
