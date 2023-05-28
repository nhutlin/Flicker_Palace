using ParkCinema.Helpers;
using ParkCinema.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkCinema.Repositories
{
    public class ScheduleRepository
    {
        public List<MovieSchedule> MovieSchedules { get; set; }

        public ScheduleRepository()
        {
            if (!File.Exists("movieSchedule.json"))
            {
                MovieSchedules = new List<MovieSchedule>
                {
                    new MovieSchedule
                    {
                        Id=1,
                        MovieName="Shazam! Fury of the Gods",
                        MovieDate=DateTime.Now.ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,27,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(136)
                    },
                    new MovieSchedule
                    {
                        Id=2,
                        MovieName="Shazam! Fury of the Gods",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(136)
                    },
                     new MovieSchedule
                    {
                        Id=3,
                        MovieName="Shazam! Fury of the Gods",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(136)
                    },
                      new MovieSchedule
                    {
                        Id=4,
                        MovieName="Shazam! Fury of the Gods",
                        MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,29,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(136)
                    },
                       new MovieSchedule
                    {
                        Id=5,
                        MovieName="Shazam! Fury of the Gods",
                        MovieDate=DateTime.Now.AddDays(3).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,30,14,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(136)
                    },
                    new MovieSchedule
                    {
                        Id=6,
                        MovieName="Forever",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(120)
                    },
                    new MovieSchedule
                    {
                        Id=7,
                        MovieName="Forever",
                        MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,29,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(120)
                    },
                    new MovieSchedule
                    {
                        Id=8,
                        MovieName="Forever",
                        MovieDate=DateTime.Now.AddDays(3).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,30,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(120)
                    },
                    new MovieSchedule
                    {
                        Id=9,
                        MovieName="Forever",
                        MovieDate=DateTime.Now.AddDays(4).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,31,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Taan Bình",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(120)
                    },
                    new MovieSchedule
                    {
                        Id=10,
                        MovieName="The LockSmith",
                        MovieDate=DateTime.Now.ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,27,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(140)
                    },
                    new MovieSchedule
                    {
                        Id=11,
                        MovieName="The LockSmith",
                        MovieDate=DateTime.Now.ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,27,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(140)
                    },
                    new MovieSchedule
                    {
                        Id=12,
                        MovieName="The LockSmith",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(140)
                    },
                    new MovieSchedule
                    {
                        Id=13,
                        MovieName="The LockSmith",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(140)
                    },
                    new MovieSchedule
                    {
                        Id=14,
                        MovieName="The LockSmith",
                        MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,29,18,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(140)
                    },
                    new MovieSchedule
                    {
                        Id=14,
                        MovieName="The LockSmith",
                        MovieDate=DateTime.Now.AddDays(4).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,31,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(140)
                    },
                     new MovieSchedule
                    {
                        Id=15,
                        MovieName="Epic Tales",
                        MovieDate=DateTime.Now.ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,27,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=7,
                        Duration=TimeSpan.FromMinutes(115)
                    },
                     new MovieSchedule
                    {
                        Id=16,
                        MovieName="Epic Tales",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=7,
                        Duration=TimeSpan.FromMinutes(115)
                    },
                     new MovieSchedule
                    {
                        Id=17,
                        MovieName="Epic Tales",
                        MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,29,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=7,
                        Duration=TimeSpan.FromMinutes(115)
                    },
                     new MovieSchedule
                    {
                        Id=18,
                        MovieName="Epic Tales",
                        MovieDate=DateTime.Now.AddDays(3).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,30,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=7,
                        Duration=TimeSpan.FromMinutes(115)
                    },
                     new MovieSchedule
                    {
                        Id=19,
                        MovieName="Epic Tales",
                        MovieDate=DateTime.Now.AddDays(4).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,31,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=7,
                        Duration=TimeSpan.FromMinutes(115)
                    },
                     new MovieSchedule
                    {
                        Id=20,
                        MovieName="Epic Tales",
                        MovieDate=DateTime.Now.AddDays(5).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,4,1,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=7,
                        Duration=TimeSpan.FromMinutes(115)
                    },
                     new MovieSchedule
                    {
                        Id=21,
                        MovieName="Epic Tales",
                        MovieDate=DateTime.Now.AddDays(6).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,4,2,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=7,
                        Duration=TimeSpan.FromMinutes(115)
                    },
                    
                      new MovieSchedule
                    {
                        Id=22,
                        MovieName="Scream 6",
                        MovieDate=DateTime.Now.ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,27,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(145)
                    },
                      new MovieSchedule
                    {
                        Id=23,
                        MovieName="Scream 6",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(145)
                    },
                      new MovieSchedule
                    {
                        Id=24,
                        MovieName="Scream 6",
                        MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,29,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(145)
                    },
                      new MovieSchedule
                    {
                        Id=25,
                        MovieName="Scream 6",
                        MovieDate=DateTime.Now.AddDays(3).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,30,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(145)
                    },
                      new MovieSchedule
                    {
                        Id=26,
                        MovieName="Scream 6",
                        MovieDate=DateTime.Now.AddDays(4).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,31,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(145)
                    },
                       new MovieSchedule
                    {
                        Id=27,
                        MovieName="Scream 6",
                        MovieDate=DateTime.Now.AddDays(5).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,4,1,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(145)
                    },
                        new MovieSchedule
                    {
                        Id=28,
                        MovieName="65",
                        MovieDate=DateTime.Now.ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,27,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(145)
                    },
                        new MovieSchedule
                    {
                        Id=29,
                        MovieName="65",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(145)
                    },
                        new MovieSchedule
                    {
                        Id=30,
                        MovieName="65",
                        MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,29,19,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(145)
                    },
                        new MovieSchedule
                    {
                        Id=31,
                        MovieName="65",
                        MovieDate=DateTime.Now.AddDays(3).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,30,19,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(145)
                    },
                        new MovieSchedule
                    {
                        Id=32,
                        MovieName="65",
                        MovieDate=DateTime.Now.AddDays(4).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,31,19,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(145)
                    },
                        new MovieSchedule
                    {
                        Id=33,
                        MovieName="65",
                        MovieDate=DateTime.Now.AddDays(5).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,4,1,19,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(145)
                    },
                        new MovieSchedule
                    {
                        Id=34,
                        MovieName="65",
                        MovieDate=DateTime.Now.AddDays(6).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,4,2,19,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(145)
                    },
                      
                        new MovieSchedule
                    {
                        Id=35,
                        MovieName="Cocaine Bear",
                        MovieDate=DateTime.Now.ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,27,19,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(160)
                    },
                        new MovieSchedule
                    {
                        Id=36,
                        MovieName="Cocaine Bear",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,19,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(160)
                    },
                        new MovieSchedule
                    {
                        Id=37,
                        MovieName="Cocaine Bear",
                        MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,29,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(160)
                    },
                        new MovieSchedule
                    {
                        Id=38,
                        MovieName="Cocaine Bear",
                        MovieDate=DateTime.Now.AddDays(3).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,30,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(160)
                    },
                        new MovieSchedule
                    {
                        Id=39,
                        MovieName="Cocaine Bear",
                        MovieDate=DateTime.Now.AddDays(4).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,31,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(160)
                    },
                        new MovieSchedule
                    {
                        Id=40,
                        MovieName="Cocaine Bear",
                        MovieDate=DateTime.Now.AddDays(5).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,4,1,10,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(160)
                    },
                        new MovieSchedule
                    {
                        Id=41,
                        MovieName="Cocaine Bear",
                        MovieDate=DateTime.Now.AddDays(6).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,4,2,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(160)
                    },
                        new MovieSchedule
                    {
                        Id=42,
                        MovieName="Ant-Man and the Wasp: Quantumania",
                        MovieDate=DateTime.Now.ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,27,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(125)
                    },
                        new MovieSchedule
                    {
                        Id=43,
                        MovieName="Ant-Man and the Wasp: Quantumania",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(136)
                    },
                        new MovieSchedule
                    {
                        Id=44,
                        MovieName="Ant-Man and the Wasp: Quantumania",
                        MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,29,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(125)
                    },
                        new MovieSchedule
                    {
                        Id=45,
                        MovieName="Ant-Man and the Wasp: Quantumania",
                        MovieDate=DateTime.Now.AddDays(3).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,30,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(125)
                    },
                        new MovieSchedule
                    {
                        Id=46,
                        MovieName="Ant-Man and the Wasp: Quantumania",
                        MovieDate=DateTime.Now.AddDays(3).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,31,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(125)
                    },
                        new MovieSchedule
                    {
                        Id=47,
                        MovieName="Prestij Meselesi",
                        MovieDate=DateTime.Now.ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,27,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(120)
                    },
                        new MovieSchedule
                    {
                        Id=48,
                        MovieName="Prestij Meselesi",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(120)
                    },
                        new MovieSchedule
                    {
                        Id=49,
                        MovieName="Prestij Meselesi",
                        MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,29,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(120)
                    },
                        new MovieSchedule
                    {
                        Id=50,
                        MovieName="Prestij Meselesi",
                        MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,29,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(120)
                    },
                        new MovieSchedule
                    {
                        Id=51,
                        MovieName="Prestij Meselesi",
                        MovieDate=DateTime.Now.AddDays(3).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,30,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(120)
                    },
                        new MovieSchedule
                    {
                        Id=52,
                        MovieName="Prestij Meselesi",
                        MovieDate=DateTime.Now.AddDays(4).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,31,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(120)
                    },
                        new MovieSchedule
                    {
                        Id=53,
                        MovieName="Prestij Meselesi",
                        MovieDate=DateTime.Now.AddDays(5).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,4,1,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(120)
                    },
                        new MovieSchedule
                    {
                        Id=54,
                        MovieName="Gifted",
                        MovieDate=DateTime.Now.ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,27,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(180)
                    },
                        new MovieSchedule
                    {
                        Id=55,
                        MovieName="Gifted",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(180)
                    },
                        new MovieSchedule
                    {
                        Id=56,
                        MovieName="Gifted",
                        MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,29,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(180)
                    },
                        new MovieSchedule
                    {
                        Id=57,
                        MovieName="Gifted",
                        MovieDate=DateTime.Now.AddDays(3).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,30,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(180)
                    },
                         new MovieSchedule
                    {
                        Id=58,
                        MovieName="Kutsal Damacana 4",
                        MovieDate=DateTime.Now.ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,27,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(110)
                    },
                        new MovieSchedule
                    {
                        Id=59,
                        MovieName="Kutsal Damacana 4",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(110)
                    },
                        new MovieSchedule
                    {
                        Id=60,
                        MovieName="Kutsal Damacana 4",
                        MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,29,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(110)
                    },
                        new MovieSchedule
                    {
                        Id=61,
                        MovieName="Kutsal Damacana 4",
                        MovieDate=DateTime.Now.AddDays(3).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,30,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(110)
                    },
                    new MovieSchedule
                    {
                        Id=62,
                        MovieName="Passengers",
                        MovieDate=DateTime.Now.ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,27,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(170)
                    },
                        new MovieSchedule
                    {
                        Id=63,
                        MovieName="Passengers",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(170)
                    },
                        new MovieSchedule
                    {
                        Id=64,
                        MovieName="Passengers",
                        MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,29,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(170)
                    },
                        new MovieSchedule
                    {
                        Id=65,
                        MovieName="Passengers",
                        MovieDate=DateTime.Now.AddDays(3).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,30,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(170)
                    },
                    new MovieSchedule
                    {
                        Id=66,
                        MovieName="A Beautiful Mind",
                        MovieDate=DateTime.Now.ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,27,14,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(190)
                    },
                        new MovieSchedule
                    {
                        Id=67,
                        MovieName="A Beautiful Mind",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(190)
                    },
                        new MovieSchedule
                    {
                        Id=68,
                        MovieName="A Beautiful Mind",
                        MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,29,13,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(190)
                    },
                        new MovieSchedule
                    {
                        Id=68,
                        MovieName="A Beautiful Mind",
                        MovieDate=DateTime.Now.AddDays(3).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,30,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(190)
                    },new MovieSchedule
                    {
                        Id=70,
                        MovieName="A Beautiful Mind",
                        MovieDate=DateTime.Now.ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,27,14,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(190)
                    },
                        new MovieSchedule
                    {
                        Id=71,
                        MovieName="Chernobyl",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(56)
                    },
                        new MovieSchedule
                    {
                        Id=72,
                        MovieName="Chernobyl",
                        MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,29,19,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(56)
                    },
                        new MovieSchedule
                    {
                        Id=73,
                        MovieName="Chernobyl",
                        MovieDate=DateTime.Now.AddDays(3).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,30,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=9,
                        Duration=TimeSpan.FromMinutes(56)
                    },
                    new MovieSchedule
                    {
                        Id=74,
                        MovieName="Julia & Julie",
                        MovieDate=DateTime.Now.ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,27,14,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=8,
                        Duration=TimeSpan.FromMinutes(180)
                    },
                        new MovieSchedule
                    {
                        Id=75,
                        MovieName="Julia & Julie",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=8,
                        Duration=TimeSpan.FromMinutes(180)
                    },
                        new MovieSchedule
                    {
                        Id=76,
                        MovieName="Julia & Julie",
                        MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,29,19,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=8,
                        Duration=TimeSpan.FromMinutes(180)
                    },
                        new MovieSchedule
                    {
                        Id=77,
                        MovieName="Julia & Julie",
                        MovieDate=DateTime.Now.AddDays(3).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,30,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=8,
                        Duration=TimeSpan.FromMinutes(180)
                    },
                    
                    new MovieSchedule
                    {
                        Id=78,
                        MovieName="Bergen",
                        MovieDate=DateTime.Now.ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,27,15,0,0).ToShortTimeString().ToString(),
                        Theater="Park Bulvar",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(180)
                    },
                        new MovieSchedule
                    {
                        Id=79,
                        MovieName="Bergen",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,12,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(180)
                    },
                        new MovieSchedule
                    {
                        Id=80,
                        MovieName="Bergen",
                        MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,29,19,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(180)
                    },
                        new MovieSchedule
                    {
                        Id=81,
                        MovieName="Bergen",
                        MovieDate=DateTime.Now.AddDays(3).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,30,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(180)
                    },
                    new MovieSchedule
                    {
                        Id=95,
                        MovieName="Wonder",
                        MovieDate=DateTime.Now.ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,27,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(170)
                    },
                        new MovieSchedule
                    {
                        Id=82,
                        MovieName="Wonder",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,12,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(170)
                    },
                        new MovieSchedule
                    {
                        Id=83,
                        MovieName="Wonder",
                        MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,29,19,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(170)
                    },
                        new MovieSchedule
                    {
                        Id=84,
                        MovieName="Wonder",
                        MovieDate=DateTime.Now.AddDays(3).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,30,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(170)
                    },
                    new MovieSchedule
                    {
                        Id=85,
                        MovieName="The Fault In Our Stars",
                        MovieDate=DateTime.Now.ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,27,15,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(165)
                    },
                        new MovieSchedule
                    {
                        Id=86,
                        MovieName="The Fault In Our Stars",
                        MovieDate=DateTime.Now.AddDays(1).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,28,12,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Linh Trung",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(165)
                    },
                        new MovieSchedule
                    {
                        Id=87,
                        MovieName="The Fault In Our Stars",
                        MovieDate=DateTime.Now.AddDays(2).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,29,19,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Tân Bình",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(165)
                    },
                        new MovieSchedule
                    {
                        Id=88,
                        MovieName="The Fault In Our Stars",
                        MovieDate=DateTime.Now.AddDays(3).ToShortDateString().ToString(),
                        MovieDateTime=new DateTime(2023,3,30,17,0,0).ToShortTimeString().ToString(),
                        Theater="Flicker Palace Gò Vấp",
                        Price=10,
                        Duration=TimeSpan.FromMinutes(165)
                    },

                };
                FileHelper.WriteMovieSchedule(MovieSchedules);
            }
            else
            {
                MovieSchedules = FileHelper.ReadMovieSchedule();
            }
        }
    }
}
