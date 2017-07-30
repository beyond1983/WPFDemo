using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfApp.Utility.Element;

namespace WpfApp.Controls.Metro
{
    public class MetroMenuTabItem: TabItem
    {
        public static readonly DependencyProperty IconProperty = ElementBase.Property<MetroMenuTabItem, string>(nameof(IconProperty), null);
        public static readonly DependencyProperty IconMoveProperty = ElementBase.Property<MetroMenuTabItem, string>(nameof(IconMoveProperty), null);
        public static readonly DependencyProperty TextHorizontalAlignmentProperty = ElementBase.Property<MetroMenuTabItem, HorizontalAlignment>(nameof(TextHorizontalAlignmentProperty), HorizontalAlignment.Right);

        public string Icon { get { return (string)GetValue(IconProperty); } set { SetValue(IconProperty, value); } }
        public string IconMove { get { return (string)GetValue(IconMoveProperty); } set { SetValue(IconMoveProperty, value); } }
        public HorizontalAlignment TextHorizontalAlignment { get { return (HorizontalAlignment)GetValue(TextHorizontalAlignmentProperty); } set { SetValue(TextHorizontalAlignmentProperty, value); } }

        static MetroMenuTabItem()
        {
            ElementBase.DefaultStyle<MetroMenuTabItem>(DefaultStyleKeyProperty);
        }
    }
}
