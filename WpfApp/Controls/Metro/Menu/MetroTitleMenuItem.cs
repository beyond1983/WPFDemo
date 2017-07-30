using System.Windows;
using System.Windows.Controls;
using WpfApp.Utility.Element;

namespace WpfApp.Controls.Metro
{
    /// <summary>
    /// 菜单子项
    /// </summary>
    public class MetroTitleMenuItem:MenuItem
    {
        public static readonly new DependencyProperty IconProperty = ElementBase.Property<MetroTitleMenuItem, object>(nameof(IconProperty), null);

        public new object Icon { get { return (object)GetValue(IconProperty); } set { SetValue(IconProperty, value); } }

        public MetroTitleMenuItem()
        {
            Utility.Refresh(this);
        }

        static MetroTitleMenuItem()
        {
            ElementBase.DefaultStyle<MetroTitleMenuItem>(DefaultStyleKeyProperty);
        }
    }
}
