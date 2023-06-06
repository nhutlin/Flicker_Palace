using FlickerPalace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickerPalace.Repositories
{
    public class BackgroundRepository
    {
        
        public List<BackgroundImage> GetAll()
        {
            return new List<BackgroundImage>
            {
                new BackgroundImage{Id=1,MovieName="Prestij Meselesi",MovieDate=DateTime.Now.AddDays(0).ToShortDateString().ToString(),ImagePath="/images/prestij.jpg"},
                new BackgroundImage{Id=2,MovieName="Ant-Man and the Wasp: Quantumania",MovieDate=DateTime.Now.AddDays(0).ToShortDateString().ToString(),ImagePath="/images/ant.jpg"},
                new BackgroundImage{Id=3,MovieName="Kutsal Damacana 4",MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(), ImagePath="/images/kutsal.jpg"},
                new BackgroundImage{Id=4,MovieName="Shazam! Fury of the Gods",MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),ImagePath="/images/shazam.jpg"},
                new BackgroundImage{Id=5,MovieName="Ant-Man and the Wasp: Quantumania",MovieDate=DateTime.Now.AddDays(0).ToShortDateString().ToString(),ImagePath="/images/ant.jpg"},
            };
        }
    }
}
