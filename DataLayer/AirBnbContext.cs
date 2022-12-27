using Microsoft.EntityFrameworkCore;
using Model;
using System.Data.SqlClient;

namespace DataLayer
{
    public class AirBnbContext : DbContext
    {
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=sqlutb2-db.hb.se,56077;Database=osu2228;User ID=osu2228;Password=ft5473");
			base.OnConfiguring(optionsBuilder);
		}

		public DbSet<Property> Properties { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Review> Reviews { get; set; }


        

        
    }
}