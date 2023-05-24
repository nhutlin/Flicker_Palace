using ParkCinema.ViewModels;
using ParkCinema.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ParkCinema
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var viewModel = new MainViewModel();
            App.MyGrid = myGrid;
            var homeUCViewModel = new HomeUCViewModel();
            var homeUC = new HomeUC();
            homeUC.DataContext = homeUCViewModel;
            
            App.MyGrid.Children.Add(homeUC);
            this.DataContext = viewModel;
        }
    }
}
