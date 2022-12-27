using BusinessLayer.Interfaces;
using DataLayer.Repositories.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Controllers
{
    public class UserController : IUserController
    {
        private readonly IUnitOfWork unitOfWork;

        public UserController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        public void RemoveUser(User user)
        {
            unitOfWork.Users.Remove(user);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return unitOfWork.Users.GetAll();
        }

        public void AttachBooking(string username, Booking booking)
        {
            User? user = unitOfWork.Users.GetByUserId(username);
            user.Bookings.Add(booking);
            unitOfWork.Complete();
        }

        

        public void AddUser(string username, string password)
        {
            User user = new User()
            {
                Username = username,
                Password = password,

            };

            unitOfWork.Users.Add(user);
            unitOfWork.Complete();
        }

        public User Login(string username, string password)
        {
            User u = unitOfWork.Users.GetLoginUser(username, password);
            return u;
        }

       
    }
}
