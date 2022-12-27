using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.Interface
{
    public interface IBookingRepository : IGenericRepository<Booking>
    {
        IEnumerable<Booking> GetUserBookings(User user);

        bool AllowedToAdd(Booking booking);
        IEnumerable<Booking> GetMyPropertyBookings(User u);
    }
}
