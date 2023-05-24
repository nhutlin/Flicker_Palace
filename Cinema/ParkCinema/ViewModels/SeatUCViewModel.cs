using ParkCinema.Commands;
using ParkCinema.Models;
using ParkCinema.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.IO;
using System.Windows.Media.Imaging;
using System.Net.NetworkInformation;
using System.Drawing;

using Color = System.Windows.Media.Color;
using Newtonsoft.Json;
using Brushes = System.Windows.Media.Brushes;
using System.Windows.Markup;

namespace ParkCinema.ViewModels
{

    public class SeatUCViewModel : BaseViewModel
    {
        private List<SelectedButtons> LoadListFromFile()
        {
            // Load the list from the file, or create a new list if the file doesn't exist
            string filePath = "toggleButtonState.json";
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<SelectedButtons>>(json);
            }
            else
            {
                return new List<SelectedButtons>();
            }
        }
        private void SaveListToFile(List<SelectedButtons> list)
        {
            // Load the existing data from the file, or create a new list if the file doesn't exist
            string filePath = "toggleButtonState.json";
            List<SelectedButtons> existingData = new List<SelectedButtons>();
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                existingData = JsonConvert.DeserializeObject<List<SelectedButtons>>(json);
            }

            // Add the new list to the existing data
            existingData.AddRange(list);

            // Serialize the combined data to JSON and write it to the file
            string combinedJson = JsonConvert.SerializeObject(existingData);
            File.WriteAllText(filePath, combinedJson);
        }
        public RelayCommand SelectedCommand { get; set; }
        public RelayCommand NextPlacesButtonClickCommand { get; set; }
        public RelayCommand BackSessionButtonClickCommand { get; set; }
        public RelayCommand BackPlacesButtonClickCommand { get; set; }
        public RelayCommand NextPaymentButtonClickCommand { get; set; }
        public RelayCommand PlaceClickCommand { get; set; }
        public RelayCommand CloseCommand { get; set; }
        public RelayCommand OrderCommand { get; set; }
        public RelayCommand SignUpCommand { get; set; }
        public RelayCommand SignedCommand { get; set; }
        public RelayCommand LoginCommand { get; set; }
        public List<int> Numbers { get; set; } = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private MovieSchedule movie;
        private int count;
        private Visibility sessionVisibility;
        private Visibility placesVisibility;
        private Visibility paymentVisibility;
        private string sessionBackground;
        private string placesBackground;
        private string paymentBackground;
        private bool isButtonEnabled;
        private decimal totalprice;
        static int counter = 0;
        private string seat;

        public List<int> SelectedRows { get; set; } = new List<int> { };
        public List<int> SelectedColumns { get; set; } = new List<int> { };
        public static List<SelectedButtons> AllSeatNames { get; set; } = new List<SelectedButtons> { };
        //public List<iTextSharp.text.Document> Documents { get; set; } = new List<iTextSharp.text.Document> { };
        public MovieSchedule Movie
        {
            get { return movie; }
            set { movie = value; OnPropertyChanged(); }
        }
        public int Count
        {
            get { return count; }
            set { count = value; OnPropertyChanged(); }
        }
        public Visibility SessionVisibility
        {
            get { return sessionVisibility; }
            set { sessionVisibility = value; OnPropertyChanged(); }
        }
        public Visibility PlacesVisibility
        {
            get { return placesVisibility; }
            set { placesVisibility = value; OnPropertyChanged(); }
        }
        public Visibility PaymentVisibility
        {
            get { return paymentVisibility; }
            set { paymentVisibility = value; OnPropertyChanged(); }
        }
        private Visibility signUp;

        public Visibility SignUpVisibility
        {
            get { return signUp; }
            set { signUp = value; OnPropertyChanged(); }
        }

        private Visibility cardVisibility;

        public Visibility CardVisibility
        {
            get { return cardVisibility; }
            set { cardVisibility = value; OnPropertyChanged(); }
        }

        private Visibility successVisibility;

        public Visibility SuccessVisibility
        {
            get { return successVisibility; }
            set { successVisibility = value; OnPropertyChanged(); }
        }

        public string SessionBackground
        {
            get { return sessionBackground; }
            set { sessionBackground = value; OnPropertyChanged(); }
        }
        public string PlacesBackground
        {
            get { return placesBackground; }
            set { placesBackground = value; OnPropertyChanged(); }
        }
        public string PaymentBackground
        {
            get { return paymentBackground; }
            set { paymentBackground = value; OnPropertyChanged(); }
        }
        public bool IsButtonEnabled
        {
            get { return isButtonEnabled; }
            set { isButtonEnabled = value; OnPropertyChanged(); }
        }
        public decimal TotalPrice
        {
            get { return totalprice; }
            set { totalprice = value; OnPropertyChanged(); }
        }
        private int row;

        public int SelectedRow
        {
            get { return row; }
            set { row = value; OnPropertyChanged(); }
        }
        private int column;

        public int SelectedColumn
        {
            get { return column; }
            set { column = value; OnPropertyChanged(); }
        }
        public string Seat
        {
            get { return seat; }
            set { seat = value; OnPropertyChanged(); }
        }
        private bool isPlaying;

        public bool IsPlaying
        {
            get { return isPlaying; }
            set { isPlaying = value; OnPropertyChanged(); }
        }

        private string emailname;

        public string EmailName
        {
            get { return emailname; }
            set { emailname = value; OnPropertyChanged(); }
        }
        private string username;

        public string UserName
        {
            get { return username; }
            set { username = value; OnPropertyChanged(); }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; OnPropertyChanged(); }
        }

        private string userPassword;

        public string Password
        {
            get { return userPassword; }
            set
            {
                userPassword = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private Email email;

        public Email Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged(); }
        }

        private long cardNumber;

        public long CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; OnPropertyChanged(); }
        }

        private int month;

        public int Month
        {
            get { return month; }
            set { month = value; OnPropertyChanged(); }
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; OnPropertyChanged(); }
        }

        private int cvc;

        public int CVC
        {
            get { return cvc; }
            set { cvc = value; OnPropertyChanged(); }
        }

        private void Order()
        {
            m = 0;
            n = -1000;
            IsCardAvailable = true;
            if (CardNumber.ToString().Length != 16)
            {
                MessageBox.Show("Card number must have 16 digits");
                IsCardAvailable = false;
            }
            if (Month > 12 || Month < 1)
            {
                MessageBox.Show("Month must be between 1 and 12");
                IsCardAvailable = false;
            }
            if (Year.ToString().Length != 4)
            {
                MessageBox.Show("Year length must be 4");
                IsCardAvailable = false;
            }
            if (Year < DateTime.Now.Year)
            {
                MessageBox.Show("Month must not be lated");
                IsCardAvailable = false;
            }

            if (IsCardAvailable == true)
            {
                IsPlaying = true;
                CardVisibility = Visibility.Hidden;
                SuccessVisibility = Visibility.Visible;
                for (int i = 0; i < Count; i++)
                {
                    var uc = new TicketUC();
                    uc.Margin = new Thickness(n, 0, 0, 0);
                    n += 200;
                    var vm = new TicketUCViewModel();
                    vm.Movie = Movie;
                    foreach (var img in App.MovieRepo.Movies)
                    {
                        if (Movie.MovieName == img.MovieName)
                        {
                            vm.ImagePath = img.ImagePath;
                            break;
                        }
                    }

                    vm.SelectedRow = SelectedRows[m];
                    vm.SelectedColumn = SelectedColumns[m];
                    uc.DataContext = vm;

                    App.MyGrid.Children.Add(uc);
                    m++;
                }
            }
        }
        private void Places(ToggleButton toggleButton)
        {

            SelectedRow = Grid.GetRow(toggleButton);
            SelectedColumn = Grid.GetColumn(toggleButton);
            if (SelectedRow == 0)
            {
                SelectedColumn++;
            }
            else if (SelectedRow > 0 && SelectedRow < 11)
            {
                SelectedColumn--;
            }
            else
            {
                SelectedColumn -= 2;
            }
            SelectedRow = Math.Abs(SelectedRow - 12);
            Seat += " Row - ";
            Seat += SelectedRow;
            Seat += " Seat - ";
            Seat += SelectedColumn;
            if (counter == Count)
            {
                Seat += ".";
            }
            else
            {
                Seat += ",";
            }

        }
        private void PlaceClick(Grid grid)
        {
            List<int> numbers = new List<int>();
            foreach (UIElement child in grid.Children)
            {
                numbers = new List<int>();
                ToggleButton toggleButton = child as ToggleButton;
                if (toggleButton != null && !AllSeatNames.Any(m => m.ButtonName == toggleButton.Name))
                {
                    if (File.Exists("toggleButtonState.json"))
                    {
                        string jsonString = File.ReadAllText("toggleButtonState.json");

                        var data = JsonConvert.DeserializeObject<List<SelectedButtons>>(jsonString);
                        if (data != null)
                        {
                            foreach (var btn in data)
                            {
                                if (btn.Movie.MovieName == Movie.MovieName && btn.Movie.MovieDate == Movie.MovieDate && btn.Movie.MovieDate == Movie.MovieDate && !AllSeatNames.Any(m => m.ButtonName == toggleButton.Name && m.Movie == Movie))
                                {
                                    if (toggleButton.IsChecked == true && toggleButton.Name != btn.ButtonName)
                                    {
                                        IsSame = true;
                                    }
                                    else
                                    {
                                        IsSame = false;
                                    }
                                    numbers.Add(0);
                                }
                                else
                                {
                                    numbers.Add(1);
                                }
                            }
                        }
                        else
                        {
                            data = new List<SelectedButtons>();
                        }
                        if (IsSame || !numbers.Contains(0))
                        {
                            if (toggleButton.IsChecked == true)
                            {
                                Places(toggleButton);
                                var current = new SelectedButtons { Movie = Movie, ButtonName = toggleButton.Name, IsChecked = (bool)toggleButton.IsChecked };
                                AllSeatNames.Add(current);
                                data.Add(current);
                                toggleButton.IsEnabled = false;
                                SelectedRows.Add(SelectedRow);
                                SelectedColumns.Add(SelectedColumn);
                                jsonString = JsonConvert.SerializeObject(data);
                                File.WriteAllText("toggleButtonState.json", jsonString);
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (toggleButton.IsChecked == true)
                        {
                            Places(toggleButton);
                            var current = new SelectedButtons { Movie = Movie, ButtonName = toggleButton.Name, IsChecked = (bool)toggleButton.IsChecked };
                            AllSeatNames.Add(current);
                            toggleButton.IsEnabled = false;
                            SelectedRows.Add(SelectedRow);
                            SelectedColumns.Add(SelectedColumn);
                            string jsonString = JsonConvert.SerializeObject(AllSeatNames);
                            File.WriteAllText("toggleButtonState.json", jsonString);
                            break;
                        }
                    }
                }
            }
        }
        bool IsAvailable = true;
        bool IsCardAvailable = true;
        bool IsSame = false;
        static int m = 0;
        static int n = 0;
        public SeatUCViewModel()
        {
            SessionVisibility = Visibility.Visible;
            PlacesVisibility = Visibility.Hidden;
            PaymentVisibility = Visibility.Hidden;
            SignUpVisibility = Visibility.Hidden;
            CardVisibility = Visibility.Hidden;
            SuccessVisibility = Visibility.Hidden;
            SessionBackground = "#7c2121";
            PlacesBackground = "Red";
            PaymentBackground = "Red";
            IsButtonEnabled = true;
            SelectedCommand = new RelayCommand((obj) =>
            {
                IsButtonEnabled = true;
                var count = obj;
                Count = (int)count;
                if (Count > 0)
                {
                    TotalPrice = Movie.Price * Count;
                }

            });
            NextPlacesButtonClickCommand = new RelayCommand((obj) =>
            {
                if (Count > 0)
                {
                    SessionVisibility = Visibility.Hidden;
                    PlacesVisibility = Visibility.Visible;
                    SessionBackground = "Red";
                    PlacesBackground = "#7c2121";
                }
                else
                {
                    MessageBox.Show("You have to choose count of person(people)");
                }
            });
            NextPaymentButtonClickCommand = new RelayCommand((obj) =>
            {
                if (IsButtonEnabled == false)
                {
                    SessionVisibility = Visibility.Hidden;
                    PlacesVisibility = Visibility.Hidden;
                    PaymentVisibility = Visibility.Visible;
                    SessionBackground = "Red";
                    PlacesBackground = "Red";
                    PaymentBackground = "#7c2121";
                }
                else
                {
                    MessageBox.Show("Place quantity must equal the number of tickets you've specified");
                }
            });
            BackSessionButtonClickCommand = new RelayCommand((obj) =>
            {
                if (Count > 0)
                {
                    SessionVisibility = Visibility.Visible;
                    PlacesVisibility = Visibility.Hidden;
                    PlacesBackground = "Red";
                    SessionBackground = "#7c2121";
                }
            });
            BackPlacesButtonClickCommand = new RelayCommand((obj) =>
            {
                if (Count > 0)
                {
                    PlacesVisibility = Visibility.Visible;
                    PaymentVisibility = Visibility.Hidden;
                    PlacesBackground = "#7c2121";
                    PaymentBackground = "Red";
                }

            });
            CloseCommand = new RelayCommand((obj) =>
            {
                App.MyGrid.Children.RemoveAt(1);

            });
            SignUpCommand = new RelayCommand((obj) =>
            {
                PaymentVisibility = Visibility.Hidden;
                SignUpVisibility = Visibility.Visible;

            });
            SignedCommand = new RelayCommand((obj) =>
            {
                IsAvailable = true;
                if (EmailName != null)
                {
                    if (!EmailName.Contains("@gmail.com"))
                    {
                        MessageBox.Show("You can only add Gmail!");
                        IsAvailable = false;
                    }
                }
                if (Password.Length < 8)
                {
                    MessageBox.Show("Password Length must be greater than or equal to 8");
                    IsAvailable = false;
                }
                else if (!Password.ToString().Any(char.IsUpper))
                {
                    MessageBox.Show("Password must contain at least one uppercase letter!");
                    IsAvailable = false;
                }
                if (IsAvailable == true)
                {
                    var mail = new Email();
                    mail.Id = App.EmailRepo.Emails[App.EmailRepo.Emails.Count - 1].Id + 1;
                    mail.UserName = UserName;
                    mail.UserPassword = Password;
                    mail.UserSurname = Surname;
                    mail.UserEmail = EmailName;
                    Email = mail;
                    App.EmailRepo.Emails.Add(Email);
                    MessageBox.Show("Email is added successfully!");
                }

            });
            LoginCommand = new RelayCommand((obj) =>
            {
                foreach (var item in App.EmailRepo.Emails)
                {
                    if (item.UserEmail == EmailName && item.UserPassword == Password.ToString())
                    {
                        PaymentVisibility = Visibility.Hidden;
                        CardVisibility = Visibility.Visible;
                    }
                }
            });
            OrderCommand = new RelayCommand((obj) =>
            {
                Order();

            });
            PlaceClickCommand = new RelayCommand((obj) =>
            {

                Grid grid = obj as Grid;
                if (grid == null) return;

                if (counter + 1 < Count)
                {
                    counter++;
                }
                else
                {
                    IsButtonEnabled = false;
                    counter = 0;
                }
                PlaceClick(grid);
            });

        }
    }
}





