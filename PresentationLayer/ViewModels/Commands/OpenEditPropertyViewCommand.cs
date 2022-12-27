using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PresentationLayer.ViewModels.Commands
{
    public class OpenEditPropertyViewCommand : ICommand
    {
        private readonly MyPropertiesViewModel myPropertiesViewModel;  
        public OpenEditPropertyViewCommand(MyPropertiesViewModel myPropertiesViewModel)
        {
            this.myPropertiesViewModel = myPropertiesViewModel;
            myPropertiesViewModel.PropertyChanged += CheckIfCanExecute;
        }
        public event EventHandler? CanExecuteChanged;
        private void CheckIfCanExecute(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(myPropertiesViewModel.SelectedProperty))
            {
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        public bool CanExecute(object? parameter)
        {
            return myPropertiesViewModel.SelectedProperty != null;
        }

        public void Execute(object? parameter)
        {
            int property = myPropertiesViewModel.SelectedProperty.PropertyId;

            EditPropertyView editPropertyView = new EditPropertyView(property);
            editPropertyView.ShowDialog();
            myPropertiesViewModel.RefreshProperties();


        }
    }
}
