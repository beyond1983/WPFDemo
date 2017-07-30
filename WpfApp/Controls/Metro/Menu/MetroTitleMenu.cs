using System.Windows.Controls;
using WpfApp.Utility.Element;

namespace WpfApp.Controls.Metro
{
    /// <summary>
    /// Metro菜单
    /// </summary>
    public class MetroTitleMenu:Menu
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public MetroTitleMenu()
        {
            Utility.Refresh(this);
        }

        /// <summary>
        /// 析构函数
        /// </summary>
        static MetroTitleMenu()
        {
            ElementBase.DefaultStyle<MetroTitleMenu>(DefaultStyleKeyProperty);
        }
    }
}
