using DataLayer.Repositories.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class BookingRepository : GenericRepository<Booking>, IBookingRepository
    {
        public BookingRepository(AirBnbContext context)
            : base(context)
        {

        }

        public override void Remove(Booking entity)
        {
            Context.Bookings.Where(x => x.BookingId == entity.BookingId).First();
            base.Remove(entity);
        }

        public IEnumerable<Booking> GetUserBookings(User? user)
        {
            return Context.Set<Booking>()
                .Include(u => u.Customer)
                .Include(u => u.Property)
                .Where(u => u.Customer.Id == user.Id).ToList();
        }
        public IEnumerable<Booking> GetMyPropertyBookings(User u)
        {
            return Context.Set<Booking>()
                .Include(b => b.Customer)
                .Include(b => b.Property)
                .Where(b => b.Property.Owner.Id == u.Id).ToList();
        }

        public bool AllowedToAdd(Booking booking)
        {
            if (Context.Bookings.Any(b => b.StartDate >= booking.StartDate && b.StartDate <= booking.EndDate ||
                b.EndDate >= booking.StartDate && b.EndDate <= booking.EndDate))
            {
                return false;
            }
               

            else return true;
               

                    
        }
    }
}
