using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkCinema.Models
{
    public class BackgroundImage:Entity
    {
        public string MovieName { get; set; }
        public string ImagePath { get; set; }
        public string MovieDate { get; set; }
    }
}
