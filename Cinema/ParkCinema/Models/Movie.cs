using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkCinema.Models
{
    public class Movie:Entity
    {
        public string MovieName { get; set; }
        public string ImagePath { get; set; }
        public string MovieDate { get; set; }
        public string Age { get; set; }
        public string MovieFormat { get; set; }
        public string MovieLanguages { get; set; }
        public string MovieCondition { get; set; }
        public string MovieCountry { get; set; }
        public string MovieDirector { get; set; }
        public string MovieGenre { get; set; }
        public string MovieActors { get; set; }
        public string MovieDuration { get; set; }
        public List<string> Theater { get; set; }
        public string About { get; set; }
        public int MovieYear { get; set; }
        public string MovieLink { get; set; }
        public double Rating { get; set; }
        public decimal MoviePrice { get; set; }
    }
}
