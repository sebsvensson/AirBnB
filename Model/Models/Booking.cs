using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Booking
    {
        public int BookingId { get; set; }
        public Property Property { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public int AmountOfPeople { get; set; }
        public User? Customer { get; set; }

        
    }
}
