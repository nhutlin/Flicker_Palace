﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickerPalace.Models
{
    public class MovieSchedule:Entity
    {
        public string MovieName { get; set; }
        public string MovieDate { get; set; }
        public string MovieDateTime { get; set; }
        public string  Duration { get; set; }
        public int Price { get; set; }
        public string Theater { get; set; }
    }
}
