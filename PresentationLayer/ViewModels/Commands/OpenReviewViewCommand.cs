using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PresentationLayer.ViewModels.Commands
{
    public class OpenReviewViewCommand : ICommand
    {
        private readonly MyPropertiesViewModel myPropertiesViewModel;

        public OpenReviewViewCommand(MyPropertiesViewModel myPropertiesViewModel)
        {
            this.myPropertiesViewModel = myPropertiesViewModel;
            myPropertiesViewModel.PropertyChanged += CheckIfCanExecute;
        }
        private void CheckIfCanExecute(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
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
            int propertyID = myPropertiesViewModel.SelectedProperty.PropertyId;

            ReviewView reviewView = new ReviewView(propertyID);
            reviewView.ShowDialog();
        }

        
    }
}
