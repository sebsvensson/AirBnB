using DataLayer.Repositories;
using DataLayer.Repositories.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AirBnbContext _context;

        public UnitOfWork(AirBnbContext context)
        {
            _context = context;
            Properties = new PropertyRepository(_context);
            Bookings = new BookingRepository(_context);
            Reviews = new ReviewsRepository(_context);
            Users = new UserRepository(_context);
        }
        public IPropertyRepository Properties { get; set; }
        public IBookingRepository Bookings { get; set; }
        public IReviewRepository Reviews { get; set; }
        public IUserRepository Users { get; set; }
        public void Complete()
        {
            _context.SaveChanges();
        }
        public void Seed(AirBnbContext airBnbContext)
        {
            //    User user1 = new User()
            //    {

            //        FirstName = "Göran",
            //        LastName = "Persson",
            //        PhoneNumber = 0707707070,
            //        Password = "passord",
            //    };

            //    User user2 = new User()
            //    {

            //        FirstName = "Fredrik",
            //        LastName = "Svensson",
            //        PhoneNumber = 0707707071,
            //        Password = "passord1"
            //    };

            //    User user3 = new User()
            //    {

            //        FirstName = "Lilian",
            //        LastName = "Karlsson",
            //        PhoneNumber = 0707707072,
            //        Password = "passord2"
            //    };



            //    Property property1 = new Property()
            //    {

            //        Owner = user1,
            //        City = "Stockholm",
            //        Adress = "Vasagatan 1",
            //        PricePerNight = 1000,
            //        Rating = 5,
            //        Facilities = "Balkong",
            //        Reviews = new List<Review>()
            //        {
            //            new Review()
            //            {
            //                Comment = "Helt fantastiskt",
            //                Rating = 5,
            //                Reviewer = user3,
            //            }
            //        }
            //    };

            //    Property property2 = new Property()
            //    {

            //        Owner = user2,
            //        City = "Göteborg",
            //        Adress = "Friggagatan 13",
            //        PricePerNight = 700,
            //        Rating = 3,
            //        Facilities = "Bastu",
            //        Reviews = new List<Review>()
            //        {
            //            new Review()
            //            {

            //                Comment = "OK",
            //                Rating = 3,
            //                Reviewer = user1,
            //            }
            //        }
            //    };


            //    Booking booking1 = new Booking()
            //    {
            //        Property = property1,
            //        StartDate = DateTime.Now,
            //        EndDate = DateTime.Now.AddDays(7),
            //        Price = 0,
            //        Customer = user1,
            //    };


            //    //airBnbContext.Users.AddRange(user1, user2, user3);
            //    //airBnbContext.Properties.AddRange(property1, property2);
            //    //airBnbContext.Bookings.Add(booking1);
            //    airBnbContext.SaveChanges();
            //}
        }
    }
}
