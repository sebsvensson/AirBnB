using BusinessLayer.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PresentationLayer.ViewModels.Commands
{
    public class EditPropertyCommand : ICommand
    {
        private readonly EditPropertyViewModel editPropertyViewModel;

        public EditPropertyCommand(EditPropertyViewModel editPropertyViewModel)
        {
            this.editPropertyViewModel = editPropertyViewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            Property? property = App.Container.PropertyController.GetProperty(editPropertyViewModel.PropertyID);

            property.Adress = editPropertyViewModel.Adress;
            property.City = editPropertyViewModel.City;
            property.PricePerNight = editPropertyViewModel.PricePerNight;  
            property.Facilities = editPropertyViewModel.Facilities;
            MessageBox.Show("Your property has been edited");
            
            

        }
    }
}
