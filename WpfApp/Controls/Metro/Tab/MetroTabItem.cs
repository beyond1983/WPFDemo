using System.Windows;
using System.Windows.Controls;
using WpfApp.Utility.Element;

namespace WpfApp.Controls.Metro
{
    public class MetroTabItem:TabItem
    {
        public static readonly DependencyProperty IconProperty = ElementBase.Property<MetroTabItem, string>(nameof(IconProperty), null);

        public string Icon { get { return (string)GetValue(IconProperty); } set { SetValue(IconProperty, value); } }

        static MetroTabItem()
        {
            ElementBase.DefaultStyle<MetroTabItem>(DefaultStyleKeyProperty);
        }
    }
}
