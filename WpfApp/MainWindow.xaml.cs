﻿using System;
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
using WpfApp.Controls.Metro;
using Zeor.Common;
using Zeor.Interface;

namespace WpfApp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void txtUrl_ButtonClick(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 1;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            tabHome.SelectedIndex = 2;
        }
    }
}
