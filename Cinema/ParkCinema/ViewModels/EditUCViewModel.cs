using Microsoft.Win32;
using Newtonsoft.Json;
using ParkCinema.Commands;
using ParkCinema.Models;
using ParkCinema.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;
using Path = System.IO.Path;

namespace ParkCinema.ViewModels
{
    public class EditUCViewModel : BaseViewModel
    {
        public RelayCommand ResetChangesCommand { get; set; }
        public RelayCommand MainClickCommand { get; set; }
        public RelayCommand SaveChangesCommand { get; set; }
        public RelayCommand ImageClickCommand { get; set; }
        public RelayCommand PlotClickCommand { get; set; }
        public RelayCommand SessionsClickCommand { get; set; }
        public RelayCommand PosterClickCommand { get; set; }
        public RelayCommand SeatsClickCommand { get; set; }
        public RelayCommand ResetPlotCommand { get; set; }
        public RelayCommand ResetPosterCommand { get; set; }
        public RelayCommand ResetSeatsCommand { get; set; }
        public RelayCommand SaveSeatsCommand { get; set; }
        public RelayCommand MovieSeatsCommand { get; set; }
        public RelayCommand MovieDatesCommand { get; set; }
        public RelayCommand CloseEditCommand { get; set; }
        public RelayCommand DeleteMovieCommand { get; set; }

        private Movie movie;
        private string title;
        private int year;
        private string genre;
        private string director;
        private string writer;
        private string actor;
        private string country;
        private string language;
        private string duration;
        private double rating;
        private int price;
        private string imagePath;
        private string ageLimit;
        private string condition;
        private string movieAbout;
        private string trailer;
        private List<Movie> movies;
        private List<MovieSchedule> allMovies;
        private Visibility mainVisibility;
        private Visibility plotVisibility;
        private Visibility posterVisibility;
        private Visibility seatsVisibility;
        private Visibility sessionsVisibility;

        public Visibility MainVisibility
        {
            get { return mainVisibility; }
            set { mainVisibility = value; OnPropertyChanged(); }
        }

        public Visibility PlotVisibility
        {
            get { return plotVisibility; }
            set { plotVisibility = value; OnPropertyChanged(); }
        }

        public Visibility PosterVisibility
        {
            get { return posterVisibility; }
            set { posterVisibility = value; OnPropertyChanged(); }
        }

        public Visibility SeatsVisibility
        {
            get { return seatsVisibility; }
            set { seatsVisibility = value; OnPropertyChanged(); }
        }

        public Visibility SessionsVisibility
        {
            get { return sessionsVisibility; }
            set { sessionsVisibility = value; OnPropertyChanged(); }
        }

        public string MovieAbout
        {
            get { return movieAbout; }
            set { movieAbout = value; OnPropertyChanged(); }
        }

        public Movie Movie
        {
            get { return movie; }
            set { movie = value; OnPropertyChanged(); }
        }
        public string Title
        {
            get { return title; }
            set { title = value; OnPropertyChanged(); }
        }
        public int Year
        {
            get { return year; }
            set { year = value; OnPropertyChanged(); }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; OnPropertyChanged(); }
        }
        public string Director
        {
            get { return director; }
            set { director = value; OnPropertyChanged(); }
        }
        public string Writer
        {
            get { return writer; }
            set { writer = value; OnPropertyChanged(); }
        }
        public string Actor
        {
            get { return actor; }
            set { actor = value; OnPropertyChanged(); }
        }
        public string Country
        {
            get { return country; }
            set { country = value; OnPropertyChanged(); }
        }
        public string Language
        {
            get { return language; }
            set { language = value; OnPropertyChanged(); }
        }
        public string Duration
        {
            get { return duration; }
            set { duration = value; OnPropertyChanged(); }
        }
        public double Rating
        {
            get { return rating; }
            set { rating = value; OnPropertyChanged(); }
        }
        public int Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged(); }
        }
        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; OnPropertyChanged(); }
        }
        public string AgeLimit
        {
            get { return ageLimit; }
            set { ageLimit = value; OnPropertyChanged(); }
        }
        public string Condition
        {
            get { return condition; }
            set { condition = value; OnPropertyChanged(); }
        }
        public string Trailer
        {
            get { return trailer; }
            set { trailer = value; OnPropertyChanged(); }
        }

        private List<string> theaters;

        public List<string> Theaters
        {
            get { return theaters; }
            set { theaters = value; OnPropertyChanged("Dates"); }
        }

        private List<string> dates;

        public List<string> Dates
        {
            get { return dates; }
            set { dates = value; OnPropertyChanged("Dates"); }
        }

        private List<string> dateTimes;

        public List<string> DateTimes
        {
            get { return dateTimes; }
            set { dateTimes = value; OnPropertyChanged("Dates"); }
        }

        public List<MovieSchedule> AllMoviesSchedule
        {
            get { return allMovies; }
            set { allMovies = value; OnPropertyChanged(); }
        }

        public List<Movie> AllMovies
        {
            get { return movies; }
            set { movies = value; OnPropertyChanged(); }
        }
        private List<SelectedButtons> data;

        public List<SelectedButtons> Data
        {
            get { return data; }
            set { data = value; OnPropertyChanged(); }
        }


        private async void Reset()
        {
            foreach (var item in App.MovieRepo.Movies)
            {
                if (item.Id == Movie.Id)
                {
                    string apiUrl = "http://21521809.pythonanywhere.com/movies";

                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    string responseContent = await response.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject<List<Movie>>(responseContent);
                    //string jsonString = File.ReadAllText("movies.json");

                    //var data = JsonConvert.DeserializeObject<List<Movie>>(jsonString);

                    var element = data.FirstOrDefault(e => e.Id == item.Id);

                    Title = element.MovieName;
                    Genre = element.MovieGenre;
                    Price = element.MoviePrice;
                    Director = element.MovieDirector;
                    AgeLimit = element.Age;
                    Country = element.MovieCountry;
                    Duration = element.MovieDuration;
                    Language = element.MovieLanguages;
                    Year = element.MovieYear;
                    ImagePath = element.ImagePath;
                    MovieAbout = element.About;
                    Trailer = element.MovieLink;
                }
            }
        }
        private async void ResetPlot()
        {
            foreach (var item in App.MovieRepo.Movies)
            {
                if (item.Id == Movie.Id)
                {
                    string apiUrl = "http://21521809.pythonanywhere.com/movies";

                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    string responseContent = await response.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject<List<Movie>>(responseContent);
                    //string jsonString = File.ReadAllText("movies.json");

                    //var data = JsonConvert.DeserializeObject<List<Movie>>(jsonString);

                    var element = data.FirstOrDefault(e => e.Id == item.Id);

                    MovieAbout = element.About;
                    Trailer = element.MovieLink;
                }
            }
        }
        private async void ResetPoster()
        {
            foreach (var item in App.MovieRepo.Movies)
            {
                if (item.Id == Movie.Id)
                {
                    string apiUrl = "http://21521809.pythonanywhere.com/movies";

                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    string responseContent = await response.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject<List<Movie>>(responseContent);

                    var element = data.FirstOrDefault(e => e.Id == item.Id);

                    ImagePath = element.ImagePath;
                }
            }
        }
        private async void ResetSeats(MovieSchedule obj)
        {
            var current = obj;
            var uc = new AdminSeatsUC();
            var vm = new AdminSeatsUCViewModel();
            vm.Movie = current;
            string apiUrl = "https://21521809.pythonanywhere.com/toggleButtonState";

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(apiUrl);
            string responseContent = await response.Content.ReadAsStringAsync();

            List<SelectedButtons> buttonStates = JsonConvert.DeserializeObject<List<SelectedButtons>>(responseContent);
            //string json = File.ReadAllText("toggleButtonState.json");
            //List<SelectedButtons> buttonStates = JsonConvert.DeserializeObject<List<SelectedButtons>>(json);
            foreach (var item in buttonStates)
            {
                foreach (var temp in uc.myGrid.Children)
                {
                    if (temp is ToggleButton toggleButton)
                    {
                        if (item.ButtonName == toggleButton.Name && item.Movie.MovieName == current.MovieName && item.Movie.MovieDate == current.MovieDate && item.Movie.MovieDateTime == current.MovieDateTime)
                        {
                            toggleButton.IsChecked = true;
                            toggleButton.IsEnabled = false;
                            break;
                        }
                    }
                }

                }
            
            uc.DataContext = vm;
            App.MyGrid.Children.RemoveAt(2);
            App.MyGrid.Children.Add(uc);
        }
        private void SaveSeats()
        {
            if (File.Exists("adminSelected.json"))
            {
                string jsonString = File.ReadAllText("adminSelected.json");
                File.WriteAllText("toggleButtonState.json", jsonString);
            }
        }
        private async void OpenImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;

                byte[] imageBytes = File.ReadAllBytes(filePath);

                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = new MemoryStream(imageBytes);
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.EndInit();
                var path = Path.GetFullPath(openFileDialog.FileName);
                ImagePath = path;

                foreach (var item in App.MovieRepo.Movies)
                {
                    if (item.Id == Movie.Id)
                    {
                        string apiUrl = "http://21521809.pythonanywhere.com/movies";

                        HttpClient client = new HttpClient();

                        HttpResponseMessage response = await client.GetAsync(apiUrl);
                        string responseContent = await response.Content.ReadAsStringAsync();

                        var data = JsonConvert.DeserializeObject<List<Movie>>(responseContent);

                        var element = data.FirstOrDefault(e => e.Id == item.Id);


                        element.ImagePath = ImagePath;

                    }
                }
            }
        }
        private async void Save()
        {
            
            foreach (var item in App.MovieRepo.Movies)
            {
                if (item.Id == Movie.Id)
                {
                    string apiUrl = "http://21521809.pythonanywhere.com/movies";

                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    string responseContent = await response.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject<List<Movie>>(responseContent);

                    //string jsonString = File.ReadAllText("movies.json");

                    //var data = JsonConvert.DeserializeObject<List<Movie>>(jsonString);
                    var element = data.FirstOrDefault(e => e.Id == item.Id);

                    element.MovieName = Title;
                    element.MovieGenre = Genre;
                    element.MoviePrice = Price;
                    element.MovieDirector = Director;
                    element.Age = AgeLimit;
                    element.MovieCountry = Country;
                    element.MovieDuration = Duration;
                    element.MovieLanguages = Language;
                    element.MovieYear = Year;
                    element.ImagePath = ImagePath;
                    element.About = MovieAbout;
                    element.MovieLink = Trailer;

                    string jsonString = JsonConvert.SerializeObject(element);
                    using (var client1 = new HttpClient())
                    {
                        var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                        var response1 = await client1.PutAsync($"http://21521809.pythonanywhere.com/editmovie/{element.Id}", content);

                    }
                    //jsonString = JsonConvert.SerializeObject(data);

                    //File.WriteAllText("movies.json", jsonString);

                }
            }

            string apiUrl2 = "http://21521809.pythonanywhere.com/movies";

            HttpClient client2 = new HttpClient();

            HttpResponseMessage response2 = await client2.GetAsync(apiUrl2);
            string responseContent2 = await response2.Content.ReadAsStringAsync();

            List<Movie> itemList = JsonConvert.DeserializeObject<List<Movie>>(responseContent2);

            //string json = File.ReadAllText("movies.json");
            //List<Movie> itemList = JsonConvert.DeserializeObject<List<Movie>>(json);
            App.MovieRepo.Movies = itemList;
            //string updatedJson = JsonConvert.SerializeObject(itemList, Formatting.Indented);
            //File.WriteAllText("movies.json", updatedJson);

            MessageBox.Show("You have save the Movie");

        }

        public EditUCViewModel()
        {
            var newMovies = new List<MovieSchedule>();
            var uc = new AdminSeatsUC();
            var vm = new AdminSeatsUCViewModel();
            Data = vm.Data;
            AllMoviesSchedule = newMovies;

            Theaters = new List<string>();
            Theaters.Add("Flicker Palace New York");
            Theaters.Add("Flicker Palace Ohio");
            Theaters.Add("Flicker Palace Las Vegas");

            Dates = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Dates.Add(DateTime.Now.AddDays(i).ToString("dd/MM/yyyy"));
            }

            DateTimes = new List<string>();
            DateTime now = DateTime.Now;
            DateTimes.Add(new DateTime(now.Year, now.Month, DateTime.Now.AddDays(0).Day, 15, 0, 0).ToShortTimeString().ToString());
            DateTimes.Add(new DateTime(now.Year, now.Month, DateTime.Now.AddDays(0).Day, 15, 30, 0).ToShortTimeString().ToString());
            DateTimes.Add(new DateTime(now.Year, now.Month, DateTime.Now.AddDays(1).Day, 17, 0, 0).ToShortTimeString().ToString());
            DateTimes.Add(new DateTime(now.Year, now.Month, DateTime.Now.AddDays(1).Day, 17, 30, 0).ToShortTimeString().ToString());
            DateTimes.Add(new DateTime(now.Year, now.Month, DateTime.Now.AddDays(2).Day, 18, 0, 0).ToShortTimeString().ToString());
            DateTimes.Add(new DateTime(now.Year, now.Month, DateTime.Now.AddDays(2).Day, 18, 30, 0).ToShortTimeString().ToString());
            DateTimes.Add(new DateTime(now.Year, now.Month, DateTime.Now.AddDays(3).Day, 20, 0, 0).ToShortTimeString().ToString());
            DateTimes.Add(new DateTime(now.Year, now.Month, DateTime.Now.AddDays(3).Day, 20, 30, 0).ToShortTimeString().ToString());
            DateTimes.Add(new DateTime(now.Year, now.Month, DateTime.Now.AddDays(4).Day, 22, 0, 0).ToShortTimeString().ToString());
            DateTimes.Add(new DateTime(now.Year, now.Month, DateTime.Now.AddDays(4).Day, 22, 30, 0).ToShortTimeString().ToString());

            MainVisibility = Visibility.Visible;
            PlotVisibility = Visibility.Hidden;
            PosterVisibility = Visibility.Hidden;
            SeatsVisibility = Visibility.Hidden;
            SessionsVisibility = Visibility.Hidden;
            MainClickCommand = new RelayCommand((obj) =>
            {
                MainVisibility = Visibility.Visible;
                PlotVisibility = Visibility.Hidden;
                PosterVisibility = Visibility.Hidden;
                SeatsVisibility = Visibility.Hidden;
                SessionsVisibility = Visibility.Hidden;
                if (App.MyGrid.Children.Count == 3)
                    App.MyGrid.Children.RemoveAt(2);
            });

            PosterClickCommand = new RelayCommand((obj) =>
            {
                MainVisibility = Visibility.Hidden;
                PlotVisibility = Visibility.Hidden;
                PosterVisibility = Visibility.Visible;
                SeatsVisibility = Visibility.Hidden;
                SessionsVisibility = Visibility.Hidden;
                if (App.MyGrid.Children.Count == 3)
                    App.MyGrid.Children.RemoveAt(2);
            });
            SeatsClickCommand = new RelayCommand((obj) =>
            {
                MainVisibility = Visibility.Hidden;
                PlotVisibility = Visibility.Hidden;
                PosterVisibility = Visibility.Hidden;
                SeatsVisibility = Visibility.Visible;
                SessionsVisibility = Visibility.Hidden;
            });
            SessionsClickCommand = new RelayCommand((obj) =>
            {
                MainVisibility = Visibility.Hidden;
                PlotVisibility = Visibility.Hidden;
                PosterVisibility = Visibility.Hidden;
                SeatsVisibility = Visibility.Hidden;
                SessionsVisibility = Visibility.Visible;
                if (App.MyGrid.Children.Count == 3)
                    App.MyGrid.Children.RemoveAt(2);
            });
            ResetChangesCommand = new RelayCommand((obj) =>
            {
                Reset();
            });
            ResetPlotCommand = new RelayCommand((obj) =>
            {
                ResetPlot();
            });
            ResetPosterCommand = new RelayCommand((obj) =>
            {
                ResetPoster();
            });
            ResetSeatsCommand = new RelayCommand((obj) =>
            {
                var combo = obj as ComboBox;
                var movie = combo.SelectedItem as MovieSchedule;
                ResetSeats(movie);
            });
            SaveSeatsCommand = new RelayCommand((obj) =>
            {
                SaveSeats();
 
            });

            SaveChangesCommand = new RelayCommand((obj) =>
            {
                Save();
                var uc2 = new AdminUC();
                var vm2 = new AdminUCViewModel();
                vm2.MainPartVisibility = Visibility.Visible;
                uc2.DataContext = vm2;
                App.MyGrid.Children.Clear();
                App.MyGrid.Children.Add(uc2);
            });
            ImageClickCommand = new RelayCommand((obj) =>
            {
                OpenImage();
            });
            CloseEditCommand = new RelayCommand((obj) =>
            {
                var uc2 = new AdminUC();
                var vm2 = new AdminUCViewModel();
                vm2.MainPartVisibility = Visibility.Visible;
                uc2.DataContext = vm2;
                App.MyGrid.Children.Clear();
                App.MyGrid.Children.Add(uc2);
            });
            PlotClickCommand = new RelayCommand((obj) =>
            {
                PlotVisibility = Visibility.Visible;
                MainVisibility = Visibility.Hidden;
                PosterVisibility = Visibility.Hidden;
                SeatsVisibility = Visibility.Hidden;
                SessionsVisibility = Visibility.Hidden;
                foreach (var item in App.MovieRepo.Movies)
                {
                    if (item == Movie)
                    {
                        MovieAbout = Movie.About;
                        Trailer = Movie.MovieLink;
                    }
                }
                if (App.MyGrid.Children.Count == 3)
                    App.MyGrid.Children.RemoveAt(2);
            });
            MovieSeatsCommand = new RelayCommand(async (obj) =>
            {
                var current = obj as MovieSchedule;
                uc = new AdminSeatsUC();
                vm = new AdminSeatsUCViewModel();
                vm.Movie = current;

                string apiUrl = "https://21521809.pythonanywhere.com/toggleButtonState";

                HttpClient client = new HttpClient();

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                string responseContent = await response.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<List<SelectedButtons>>(responseContent);
                //string jsonString = File.ReadAllText("toggleButtonState.json");
                //var data = JsonConvert.DeserializeObject<List<SelectedButtons>>(jsonString);
                if (data != null)
                {
                    foreach (var item in data)
                    {
                        foreach (var temp in uc.myGrid.Children)
                        {
                            if (temp is ToggleButton toggleButton)
                            {
                                if (item.ButtonName == toggleButton.Name && item.Movie.MovieName == current.MovieName && item.Movie.MovieDate == current.MovieDate && item.Movie.MovieDateTime == current.MovieDateTime)
                                {
                                    toggleButton.IsChecked = true;
                                    toggleButton.IsEnabled = false;
                                    break;
                                }
                            }
                        }
                    }
                }

                uc.DataContext = vm;
                if (App.MyGrid.Children.Count > 2)
                {
                    App.MyGrid.Children.RemoveAt(2);
                }
                App.MyGrid.Children.Add(uc);
            });
            MovieDatesCommand = new RelayCommand(async (obj) =>
            {
                var current = obj as MovieSchedule;
                uc = new AdminSeatsUC();
                vm = new AdminSeatsUCViewModel();
                vm.Movie = current;
                string apiUrl = "https://21521809.pythonanywhere.com/toggleButtonState";

                HttpClient client = new HttpClient();

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                string responseContent = await response.Content.ReadAsStringAsync();

                List<SelectedButtons> buttonStates = JsonConvert.DeserializeObject<List<SelectedButtons>>(responseContent);
                //string json = File.ReadAllText("toggleButtonState.json");
                //List<SelectedButtons> buttonStates = JsonConvert.DeserializeObject<List<SelectedButtons>>(json);
                foreach (var item in buttonStates)
                {
                    foreach (var temp in uc.myGrid.Children)
                    {
                        if (temp is ToggleButton toggleButton)
                        {
                            if (item.ButtonName == toggleButton.Name && item.Movie.MovieName == current.MovieName && item.Movie.MovieDate == current.MovieDate && item.Movie.MovieDateTime == current.MovieDateTime)
                            {
                                toggleButton.IsChecked = true;
                                toggleButton.IsEnabled = false;
                                break;
                            }
                        }
                    }
                }
               
                uc.DataContext = vm;
                App.MyGrid.Children.Add(uc);
            });
            DeleteMovieCommand = new RelayCommand(async (obj) =>
            {
                string apiUrl = "http://21521809.pythonanywhere.com/movies";

                HttpClient client = new HttpClient();

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                string responseContent = await response.Content.ReadAsStringAsync();

                List<Movie> itemList = JsonConvert.DeserializeObject<List<Movie>>(responseContent);
                //string json = File.ReadAllText("movies.json");

                //List<Movie> itemList = JsonConvert.DeserializeObject<List<Movie>>(json);
                Movie itemToDelete = itemList.FirstOrDefault(item => item.Id == Movie.Id);

                if (itemToDelete != null)
                {
                    string jsonString = JsonConvert.SerializeObject(itemToDelete);
                    using (var client1 = new HttpClient())
                    {
                        var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                        var response1 = await client1.DeleteAsync($"http://21521809.pythonanywhere.com/deletemovie/{itemToDelete.Id}");

                    }
                    itemList.Remove(itemToDelete);
                }
                App.MovieRepo.Movies = itemList;
                //string updatedJson = JsonConvert.SerializeObject(itemList, Formatting.Indented);
                //File.WriteAllText("movies.json", updatedJson);
                //App.MyGrid.Children.RemoveAt(1);
                MessageBox.Show("You have deleted the Movie");
            });
        }
    }
}
