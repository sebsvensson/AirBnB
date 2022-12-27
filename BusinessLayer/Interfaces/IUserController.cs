using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IUserController
    {
        void AddUser(string username, string password);

        IEnumerable<User> GetAllUsers();

        void AttachBooking(string username, Booking booking);

        User Login (string username, string password);
        void RemoveUser(User user);
    }
}
