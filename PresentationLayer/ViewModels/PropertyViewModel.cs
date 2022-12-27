using Model;
using PresentationLayer.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PresentationLayer.ViewModels
{
    public class PropertyViewModel : BaseViewModel
    {
        private Property selectedProperty;
        public Property SelectedProperty { get => selectedProperty; set { selectedProperty = value; OnPropertyChanged(); } }
        public string Adress { get; set; }
        public string City { get; set; }
        public int PricePerNight { get; set; }
        public int Rating { get; set; }
        public string Facilities { get; set; }
        public ObservableCollection<Property> Properties { get; set; } = new ObservableCollection<Property>();
        public ICommand GetPropertiesCommand { get; set; }
        public ICommand FilterPropertiesCommand { get; set; }
        public ICommand OpenAddBookingViewCommand { get; set; }


        public PropertyViewModel()
        {
            GetPropertiesCommand = new GetAllPropertiesCommand(this);
            FilterPropertiesCommand = new FilterPropertiesCommand(this);
            OpenAddBookingViewCommand = new OpenAddBookingViewCommand(this);
            RefreshProperties();
        }
        internal void RefreshProperties()
        {
            Properties.Clear();

            IEnumerable<Property> properties = App.Container.PropertyController.GetProperties();
            foreach (Property property in properties)
            {
                Properties.Add(property);
            }
        }

        internal void SearchFiltered()
        {
            Properties.Clear();

            IEnumerable<Property> properties = App.Container.PropertyController.GetPropertiesFiltered(City, Facilities, PricePerNight, Rating);

            foreach (Property property in properties)
            {
                Properties.Add(property);
            }
        }


    }
}

