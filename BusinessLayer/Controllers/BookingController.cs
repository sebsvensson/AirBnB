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
    public class BookingController : IBookingController
    {
        private readonly IUnitOfWork unitOfWork;

        public BookingController(IUnitOfWork unitfwork)
        {
            this.unitOfWork = unitfwork;
        }

        public Booking AddBooking(Property property, DateTime startdate, DateTime endDate, double price, User customer, int amountOfPeople)
        {
            Booking booking = new Booking();
            {
                booking.Property = property;
                booking.StartDate = startdate;
                booking.EndDate = endDate;
                booking.Price = price;
                booking.Customer = customer;
                booking.AmountOfPeople = amountOfPeople;
            }

            if (unitOfWork.Bookings.AllowedToAdd(booking))
            {
                unitOfWork.Bookings.Add(booking);
                unitOfWork.Complete();
                return booking;
            }
            return null;

        }
        public Booking GetBooking(int id)
        {
            return unitOfWork.Bookings.Get(id);
        }

        public void RemoveBooking(Booking booking)
        {
            unitOfWork.Bookings.Remove(booking);
            unitOfWork.Complete();
        }
        public IEnumerable<Booking> GetUserBookings(User userid)
        {
            return unitOfWork.Bookings.GetUserBookings(userid);
            unitOfWork.Complete();
        }

        public IEnumerable<Booking> GetMyPropertyBookings(User u)
        {
            return unitOfWork.Bookings.GetMyPropertyBookings(u);
        }
    }
}