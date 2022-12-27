using BusinessLayer.Interfaces;
using Model;
using PresentationLayer.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PresentationLayer.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private Property selectedProperty;
        public IPropertyController propertyController;
        public ObservableCollection<Property> Properties { get; set; } = new ObservableCollection<Property>();
        public ICommand OpenAdsViewCommand { get; set; }
        public ICommand OpenMyBookingsViewCommand { get; set; }
        public ICommand OpenMyPropertiesViewCommand { get; set; }


        public MainViewModel()
        {
            OpenAdsViewCommand = new OpenAdsViewCommand(this);
            OpenMyBookingsViewCommand = new OpenMyBookingsViewCommand(this);
            OpenMyPropertiesViewCommand = new OpenMyPropertiesViewCommand(this);
            
        }

        internal void RefreshProperties()
        {
            Properties.Clear();

            IEnumerable<Property> properties = propertyController.GetProperties();

            foreach (Property property in properties)
            {
                Properties.Add(property);
            }
        }

        public Property SelectProperty
        {
            get => selectedProperty; set
            {
                selectedProperty = value; OnPropertyChanged();
            }
        }
    }
}
