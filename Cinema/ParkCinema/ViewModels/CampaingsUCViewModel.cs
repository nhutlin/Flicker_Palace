using ParkCinema.Commands;
using ParkCinema.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkCinema.ViewModels
{
    public class CampaingsUCViewModel:BaseViewModel
    {
        public RelayCommand LogoClickCommand { get; set; }
        public RelayCommand AppleClickCommand { get; set; }
        public RelayCommand AndroidClickCommand { get; set; }
        public RelayCommand FaceBookClickCommand { get; set; }
        public RelayCommand TwitterClickCommand { get; set; }
        public RelayCommand YoutubeClickCommand { get; set; }
        public CampaingsUCViewModel()
        {
            LogoClickCommand = new RelayCommand((obj) =>
            {
                App.BackPage = App.MyGrid.Children[0];

                var uc = new HomeUC();
                var vm = new HomeUCViewModel();

                uc.DataContext = vm;
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(uc);
            });
            AppleClickCommand = new RelayCommand((obj) =>
            {
                System.Diagnostics.Process.Start("https://apps.apple.com/us/app/park-cinema/id1119977600?ls=1");
            });
            AndroidClickCommand = new RelayCommand((obj) =>
            {
                System.Diagnostics.Process.Start("https://play.google.com/store/apps/details?id=az.parkcinema.app&hl=ru");
            });
            FaceBookClickCommand = new RelayCommand((obj) =>
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/ParkCinema");
            });
            TwitterClickCommand = new RelayCommand((obj) =>
            {
                System.Diagnostics.Process.Start("https://twitter.com/park_cinema");
            });
            YoutubeClickCommand = new RelayCommand((obj) =>
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC0NJN0gCCx_DbJlkPfD30Ag/feed");
            });
        }
    }
}
