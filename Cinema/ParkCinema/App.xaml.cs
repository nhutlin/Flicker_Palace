using ParkCinema.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ParkCinema
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Grid MyGrid { get; set; }
        public static MovieRepository MovieRepo { get; set; }
        public static ScheduleRepository ScheduleRepo { get; set; }
        public static EmailRepository EmailRepo { get; set; }
        public static UIElement BackPage { get; set; }
        public static ViewModels.MovieBackgroundUCViewModel PreviousViewModel { get; set; }

        public App()
        {
            MovieRepo = new MovieRepository();
            ScheduleRepo = new ScheduleRepository();
            EmailRepo=new EmailRepository();
        }
    }
}
