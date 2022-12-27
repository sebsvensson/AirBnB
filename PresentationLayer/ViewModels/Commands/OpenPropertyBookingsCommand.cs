using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PresentationLayer.ViewModels.Commands
{
    public class OpenPropertyBookingsCommand : ICommand
    {
        private readonly MyPropertiesViewModel myPropertiesViewModel;

        public event EventHandler? CanExecuteChanged;

        public OpenPropertyBookingsCommand(MyPropertiesViewModel myPropertiesViewModel)
        {
            this.myPropertiesViewModel = myPropertiesViewModel;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            PropertyBookingsView propertyBookingsView = new PropertyBookingsView();
            propertyBookingsView.ShowDialog();
        }
    }
}
