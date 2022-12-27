using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PresentationLayer.ViewModels.Commands
{
    public class GetAllPropertiesCommand : ICommand
    {
        private readonly PropertyViewModel propertyViewModel;

        public GetAllPropertiesCommand(PropertyViewModel propertyViewModel)
        {
            this.propertyViewModel = propertyViewModel;
        }
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            propertyViewModel.RefreshProperties();
        }
    }
}
