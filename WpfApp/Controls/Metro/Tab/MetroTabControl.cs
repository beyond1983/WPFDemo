﻿using System.Windows.Controls;
using WpfApp.Utility.Element;

namespace WpfApp.Controls.Metro
{
    public class MetroTabControl : TabControl
    {
        void SelectionState()
        {
            ElementBase.GoToState(this, "SelectionStart");
            ElementBase.GoToState(this, "SelectionEnd");
        }

        public MetroTabControl()
        {
            Loaded += delegate { ElementBase.GoToState(this, "SelectionLoaded"); };
            SelectionChanged += delegate (object sender, SelectionChangedEventArgs e) { if (e.Source is MetroTabControl) { SelectionState(); } };
            Utility.Refresh(this);
        }

        static MetroTabControl()
        {
            ElementBase.DefaultStyle<MetroTabControl>(DefaultStyleKeyProperty);
        }
    }
}
