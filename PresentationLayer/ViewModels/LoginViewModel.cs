using PresentationLayer.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PresentationLayer.ViewModels.LoginViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public string? username { get; set; }
        public string? password { get; set; }
        public string? createusername { get; set; }
        public string? createpassword { get; set; }
        public ICommand AddUserCommand { get; set; }
        public ICommand LoginCommand { get; set; }

        public void AddUser(string createusername, string createpassword)
        {
            App.Container.UserController.AddUser(createusername, createpassword);
        }
        public void LogIn(string username, string password)
        {
            App.Container.Login(username, password);
        }
        public LoginViewModel()
        {
            AddUserCommand = new AddUserCommand(this);
            LoginCommand = new LogInCommand(this);
        }
    } 
}
