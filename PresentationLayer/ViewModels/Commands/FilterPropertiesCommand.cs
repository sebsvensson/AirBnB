using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PresentationLayer.ViewModels.Commands
{
    public class FilterPropertiesCommand : ICommand
    {
        private readonly PropertyViewModel propertyViewmodel;

        public FilterPropertiesCommand(PropertyViewModel propertyViewModel)
        {
            this.propertyViewmodel = propertyViewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            string City = propertyViewmodel.City;
            int Price = propertyViewmodel.PricePerNight;
            int Rating = propertyViewmodel.Rating;
            string Facilities = propertyViewmodel.Facilities;

            App.Container.PropertyController.GetPropertiesFiltered(City, Facilities, Price, Rating);

            propertyViewmodel.SearchFiltered();
        }
    }
}
