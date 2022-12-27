﻿using PresentationLayer.ViewModels;
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
using System.Windows.Shapes;

namespace PresentationLayer.Views
{
    /// <summary>
    /// Interaction logic for PropertyBookingsView.xaml
    /// </summary>
    public partial class PropertyBookingsView : Window
    {
        public PropertyBookingsView()
        {
            InitializeComponent();
            DataContext = new PropertyBookingsViewModel();
        }
    }
}
