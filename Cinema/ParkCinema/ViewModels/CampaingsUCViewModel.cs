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
           
        }
    }
}
