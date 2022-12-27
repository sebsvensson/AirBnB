using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IBookingController
    {
        IEnumerable<Booking> GetUserBookings(User userid);
        Booking GetBooking(int id);
        Booking AddBooking(Property property, DateTime startdate, DateTime endDate, double price, User customer, int amountOfPeople);
        void RemoveBooking(Booking booking);
        IEnumerable<Booking> GetMyPropertyBookings(User u);
    } 
}

