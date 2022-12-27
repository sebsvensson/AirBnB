using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PresentationLayer.ViewModels.Commands
{
    public class LogInCommand : ICommand
    {

        private readonly LoginViewModel.LoginViewModel loginViewModel;

        public LogInCommand(LoginViewModel.LoginViewModel loginViewModel)
        {
            this.loginViewModel = loginViewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }



        public void Execute(object? parameter)
        {
            string? userId = loginViewModel.username;
            string? password = loginViewModel.password;
            loginViewModel.LogIn(userId, password);

            MainView mainview = new MainView();
            if(App.Container.LoggedIn != null)
            {
                mainview.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong username or passowrd." +
                    "Try again");
            }
        }
    }
}
