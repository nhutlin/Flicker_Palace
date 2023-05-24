using ParkCinema.Commands;
using ParkCinema.Models;
using ParkCinema.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkCinema.ViewModels
{
    public class BackgroundImageViewModel : BaseViewModel 
    {
        public BackgroundRepository BackgroundImageRepository { get; set; }
        private ObservableCollection<BackgroundImage> allImages;
        private BackgroundImage image;

        public ObservableCollection<BackgroundImage> AllImages
        {
            get { return allImages; }
            set { allImages = value; OnPropertyChanged(); }
        }

        public BackgroundImage BackImage
        {
            get { return image; }
            set { image = value; OnPropertyChanged(); }
        }

        public RelayCommand FirstClickCommand { get; set; }
        public RelayCommand SecondClickCommand { get; set; }
        public RelayCommand ThirdClickCommand { get; set; }
        public RelayCommand FourthClickCommand { get; set; }

        public BackgroundImageViewModel()
        {
            BackgroundImageRepository = new BackgroundRepository();
            AllImages = new ObservableCollection<BackgroundImage>(BackgroundImageRepository.GetAll());
            BackImage = new BackgroundImage();
            FirstClickCommand = new RelayCommand((obj) =>
            {
                BackImage=AllImages[0];
            });
        }
    }
}
