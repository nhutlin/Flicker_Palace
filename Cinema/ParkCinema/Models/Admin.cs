﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkCinema.Models
{
    public class Admin : Entity
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
