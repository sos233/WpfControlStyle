using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;

namespace WpfControlStyle
{
    public class BaseStartWindow : Window
    {
        public BaseStartWindow()
        {
            InitializeStyle();
            this.Loaded += delegate
            {
                InitializeEvent();
            };
        }

        private void InitializeEvent()
        {
            ControlTemplate baseWindowTemplate = (ControlTemplate)App.Current.Resources["BaseStartWindowControlTemplate"];

            Button minBtn = (Button)baseWindowTemplate.FindName("btnMin", this);
            minBtn.Click += delegate
            {
                this.WindowState = WindowState.Minimized;
            };

            CheckBox maxBtn = (CheckBox)baseWindowTemplate.FindName("btnMax", this);
            maxBtn.Checked += delegate
            {
                this.WindowState = WindowState.Maximized;
            };
            maxBtn.Unchecked += delegate
            {
                this.WindowState = WindowState.Normal;
            };
            this.StateChanged += delegate
            {
                if (this.WindowState == WindowState.Maximized)
                    maxBtn.IsChecked = true;
                else
                    maxBtn.IsChecked = false;
            };

            Button closeBtn = (Button)baseWindowTemplate.FindName("btnClose", this);
            closeBtn.Click += delegate
            {
                Application.Current.Shutdown();
            };

            Border borderTitle = (Border)baseWindowTemplate.FindName("borderTitle", this);
            borderTitle.MouseMove += delegate(object sender, MouseEventArgs e)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    this.DragMove();
                }
            };
        }

        private void InitializeStyle()
        {
            this.Style = (Style)App.Current.Resources["BaseStartWindowStyle"];
        }
    }
}