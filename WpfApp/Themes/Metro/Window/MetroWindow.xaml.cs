using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp.Themes.Metro
{
    /// <summary>
    /// MetroWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MetroWindow 
    {
        void Minimized(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(sender as FrameworkElement).WindowState = WindowState.Minimized;
        }
        void Normal(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(sender as FrameworkElement).WindowState = WindowState.Normal;
        }
        void Maximized(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(sender as FrameworkElement).WindowState = WindowState.Maximized;
        }
        void Close(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(sender as FrameworkElement).Close();
        }
    }
}
