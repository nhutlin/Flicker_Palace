using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkCinema.Models
{
    public class MovieSchedule:Entity
    {
        public string MovieName { get; set; }
        public string MovieDate { get; set; }
        public string MovieDateTime { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal Price { get; set; }
        public string Theater { get; set; }
    }
}
