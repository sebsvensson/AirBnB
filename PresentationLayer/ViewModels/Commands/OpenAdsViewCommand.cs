using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PresentationLayer.ViewModels.Commands
{
    public class OpenAdsViewCommand : ICommand
    {
        private readonly MainViewModel mainViewModel;
        public OpenAdsViewCommand(MainViewModel mainViewModel)
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
            PropertiesView propertiesView = new PropertiesView();

            propertiesView.ShowDialog();


        }
    }
}
