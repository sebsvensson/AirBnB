using BusinessLayer.Controllers;
using BusinessLayer.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PresentationLayer.ViewModels;
using System.Windows;

namespace PresentationLayer.ViewModels.Commands
{
    public class AddPropertyCommand : ICommand
    {
        private readonly AddPropertyViewModel addPropertyViewModel;

        public IPropertyController propertyController;

        public AddPropertyCommand(AddPropertyViewModel addPropertyViewModel)
        {
            this.addPropertyViewModel = addPropertyViewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            //Property newProperty = new Property();

            App.Container.AddNewProperty(
                addPropertyViewModel.City,
                addPropertyViewModel.Adress,
                addPropertyViewModel.PricePerNight,
                addPropertyViewModel.Facilities,
                addPropertyViewModel.Description
                );
            MessageBox.Show("A new property was added");

        }
    }
}
