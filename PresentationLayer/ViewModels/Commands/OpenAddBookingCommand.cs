using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PresentationLayer.ViewModels.Commands
{
    public class OpenAddBookingViewCommand : ICommand

    {
        private readonly PropertyViewModel propertyViewModel;

        public OpenAddBookingViewCommand(PropertyViewModel propertyViewModel)
        {
            this.propertyViewModel = propertyViewModel;
            propertyViewModel.PropertyChanged += CheckIfCanExecute;
        }

        private void CheckIfCanExecute(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(PropertyViewModel.SelectedProperty))
            {
                CanExecuteChanged.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return propertyViewModel.SelectedProperty != null;
        }

        public void Execute(object? parameter)
        {
            int PropId = propertyViewModel.SelectedProperty.PropertyId;

            AddBookingView addBookingView = new AddBookingView(PropId);
            addBookingView.ShowDialog();
        }
    }
}
