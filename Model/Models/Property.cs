
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Property
    {
        public int PropertyId { get; set; }
        public User Owner { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public int PricePerNight { get; set; }
        public int Rating { get; set; }
        public string? Facilities { get; set; }
        public bool Available { get; set; }
        public string? Description { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Booking> Bookings { get; set; }


    }
}


