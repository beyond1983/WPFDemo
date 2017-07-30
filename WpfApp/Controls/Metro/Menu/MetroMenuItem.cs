using System.Windows;
using System.Windows.Controls;
using WpfApp.Utility.Element;

namespace WpfApp.Controls.Metro
{
    public class MetroMenuItem:MenuItem
    {
        public static readonly new DependencyProperty IconProperty = ElementBase.Property<MetroMenuItem, object>(nameof(IconProperty), null);

        public new object Icon { get { return (object)GetValue(IconProperty); } set { SetValue(IconProperty, value); } }

        public MetroMenuItem()
        {
            Utility.Refresh(this);
        }

        static MetroMenuItem()
        {
            ElementBase.DefaultStyle<MetroMenuItem>(DefaultStyleKeyProperty);
        }
    }
}
