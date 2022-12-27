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
    public class MyPropertiesViewModel : BaseViewModel
    {
        private Property selectedProperty;
        public Property SelectedProperty { get => selectedProperty; set { selectedProperty = value; OnPropertyChanged(); } }
        public ObservableCollection<Property> MyProperties { get; set; } = new ObservableCollection<Property>();
        public ICommand OpenAddPropertyViewCommand { get; set; }
        public ICommand RemovePropertyCommand { get; set; }
        public ICommand OpenEditPropertyViewCommand { get; set; }
        public ICommand OpenReviewViewCommand { get; set; }
        public ICommand OpenPropertyBookingsCommand { get; set; }

        public MyPropertiesViewModel()
        {
            OpenAddPropertyViewCommand = new OpenAddPropertyViewCommand(this);
            OpenEditPropertyViewCommand = new OpenEditPropertyViewCommand(this);
            RemovePropertyCommand = new RemovePropertyCommand(this);
            OpenReviewViewCommand = new OpenReviewViewCommand(this);
            OpenPropertyBookingsCommand = new OpenPropertyBookingsCommand(this);
            RefreshProperties();
        }

        internal void RefreshProperties()
        {
            MyProperties.Clear();

            IEnumerable<Property> properties = App.Container.PropertyController.GetUserProperties(App.Container.LoggedIn);

            foreach (Property property in properties)
            {
                MyProperties.Add(property);
            }
        }

    }
}
