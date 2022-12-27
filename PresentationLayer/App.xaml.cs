using BusinessLayer.Controllers;
using BusinessLayer.Interfaces;
using PresentationLayer.ViewModels;
using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using BusinessLayer;
using DataLayer;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container Container { get; } = new Container();
    }
}
