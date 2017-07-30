using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows;
using WpfApp.Utility.Element;

namespace WpfApp.Controls.Metro
{
    public enum ButtonState
    {
        None,
        Red,
        Green
    }

    public class MetroButton : ButtonBase
    {
        public static readonly DependencyProperty MetroButtonStateProperty = ElementBase.Property<MetroButton, ButtonState>(nameof(MetroButtonStateProperty), ButtonState.None);
        public ButtonState MetroButtonState { get { return (ButtonState)GetValue(MetroButtonStateProperty); } set { SetValue(MetroButtonStateProperty, value); } }

        /// <summary>
        /// 图标
        /// </summary>
        public static readonly DependencyProperty MetroIconProperty = ElementBase.Property<MetroButton, string>(nameof(MetroIconProperty), "\ue604");
        public string MetroIcon
        {
            get { return (string)GetValue(MetroIconProperty); }
            set { SetValue(MetroIconProperty, value); }
        }

        /// <summary>
        /// 间距
        /// </summary>
        public static readonly DependencyProperty MetroMarginProperty = ElementBase.Property<MetroButton, Thickness>(nameof(MetroMarginProperty), new Thickness(1,2,0,0));
        public Thickness MetroMargin
        {
            get { return (Thickness)GetValue(MetroMarginProperty); }
            set { SetValue(MetroMarginProperty, value); }
        }

        public MetroButton()
        {
            Utility.Refresh(this);
        }

        static MetroButton()
        {
            ElementBase.DefaultStyle<MetroButton>(DefaultStyleKeyProperty);
        }
    }
}
