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
    public class RemovePropertyCommand : ICommand
    {
        private readonly MyPropertiesViewModel myPropertiesViewModel;

        public RemovePropertyCommand(MyPropertiesViewModel myPropertiesViewModel)
        {
            this.myPropertiesViewModel = myPropertiesViewModel;
            myPropertiesViewModel.PropertyChanged += CheckIfCanExecute;
        }

        private void CheckIfCanExecute(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MyPropertiesViewModel.SelectedProperty))
            {
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return myPropertiesViewModel.SelectedProperty != null;
        }

        public void Execute(object? parameter)
        {
            Property property = App.Container.PropertyController.GetProperty(myPropertiesViewModel.SelectedProperty.PropertyId);
            App.Container.PropertyController.RemoveProperty(property);
            MessageBox.Show("Property removed");
            myPropertiesViewModel.RefreshProperties();
        }
    }
}
