using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string? Comment { get; set; }
        public int Rating { get; set; }
        public User? Reviewer { get; set; }
        public Property? Property { get; set; }

    }
}
