using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PresentationLayer.ViewModels.Commands
{
    public class OpenAddPropertyViewCommand : ICommand
    {
        private readonly MyPropertiesViewModel myPropertiesViewModel;

        public OpenAddPropertyViewCommand(MyPropertiesViewModel myPropertiesViewModel)
        {
            this.myPropertiesViewModel = myPropertiesViewModel;
        }

        public event EventHandler? CanExecuteChanged;

       

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            AddPropertyView addPropertyView = new AddPropertyView();
            addPropertyView.ShowDialog();

        }
    }
}
