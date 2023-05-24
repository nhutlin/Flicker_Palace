using ParkCinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkCinema.Repositories
{
    public class BackgroundRepository
    {
        
        public List<BackgroundImage> GetAll()
        {
            return new List<BackgroundImage>
            {
                new BackgroundImage{Id=1,MovieName="Prestij Meselesi",MovieDate="26 January",ImagePath="/images/prestij.jpg"},
                new BackgroundImage{Id=2,MovieName="Kutsal Damacana 4",MovieDate="2 February", ImagePath="/images/kutsal.jpg"},
                new BackgroundImage{Id=3,MovieName="Evdə qalmış",MovieDate="9 February",ImagePath="/images/evde.jpg"},
                new BackgroundImage{Id=4,MovieName="Ant-Man and the Wasp: Quantumania",MovieDate="16 February",ImagePath="/images/ant.jpg"},
                new BackgroundImage{Id=5,MovieName="Shazam! Fury of the Gods",MovieDate="16 March",ImagePath="/images/shazam.jpg"},
            };
        }
    }
}
