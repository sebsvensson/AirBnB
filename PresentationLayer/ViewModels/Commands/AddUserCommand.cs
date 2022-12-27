using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PresentationLayer.ViewModels.Commands
{
    internal class AddUserCommand : ICommand
    {
        private readonly LoginViewModel.LoginViewModel loginViewModel;

        public AddUserCommand(LoginViewModel.LoginViewModel loginViewModel)
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
            string? username = loginViewModel.createusername;
            string? password = loginViewModel.createpassword;
            loginViewModel.AddUser(username, password);

            MessageBox.Show("Account Created");
        }
    }
}
