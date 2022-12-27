﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public ICollection<Booking>? Bookings { get; set; }

        public bool VerifyPassword(string pass)
        {
            return Password == pass;
        }
    }
}
