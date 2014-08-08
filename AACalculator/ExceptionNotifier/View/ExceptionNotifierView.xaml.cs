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
using System.Windows.Shapes;

namespace AACalculator.ExceptionNotifier.View
{
    /// <summary>
    /// Interaction logic for ExceptionNotifierView.xaml
    /// </summary>
    public partial class ExceptionNotifierView : Window
    {
        public ExceptionNotifierView()
        {
            InitializeComponent();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            Keyboard.Focus(btnClose);
        }
    }
}
