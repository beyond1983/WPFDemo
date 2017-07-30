using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp.Utility.Element;

namespace WpfApp.Controls.Metro
{
   public class MetroListView:ListView
    {
        static MetroListView()
        {
            ElementBase.DefaultStyle<MetroListView>(DefaultStyleKeyProperty);
        }
    }
}
