using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PresentationLayer.ViewModels.Commands
{
    public class OpenMyPropertiesViewCommand : ICommand
    {
        private readonly MainViewModel mainViewModel;

        public OpenMyPropertiesViewCommand(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            MyPropertiesView myPropertiesView = new MyPropertiesView();
            myPropertiesView.ShowDialog();

        }
    }
}
