using FlickerPalace.Commands;
using FlickerPalace.Models;
using FlickerPalace.Views.UserControls;
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
using System.Net.Http;
using System.Windows.Documents;

namespace FlickerPalace.ViewModels
{

    public class SeatUCViewModel : BaseViewModel
    {
        private async Task<List<SelectedButtons>> LoadListFromFileAsync()
        {
            // Load the list from the file, or create a new list if the file doesn't exist
            string apiUrl = "https://21521809.pythonanywhere.com/toggleButtonState";

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(apiUrl);
            string responseContent = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<SelectedButtons>>(responseContent);
            //string filePath = "toggleButtonState.json";
            //if (File.Exists(filePath))
            //{
            //    string json = File.ReadAllText(filePath);
            //    return JsonConvert.DeserializeObject<List<SelectedButtons>>(json);
            //}
            //else
            //{
            //    return new List<SelectedButtons>();
        }
    
        private async void SaveListToFile(List<SelectedButtons> list)
        {
            // Load the existing data from the file, or create a new list if the file doesn't exist
            string jsonString = JsonConvert.SerializeObject(list);
            using (var client = new HttpClient())
            {
                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://21521809.pythonanywhere.com/addtogglebutton", content);

            }
            //string filePath = "toggleButtonState.json";
            //List<SelectedButtons> existingData = new List<SelectedButtons>();
            //if (File.Exists(filePath))
            //{
            //    string json = File.ReadAllText(filePath);
            //    existingData = JsonConvert.DeserializeObject<List<SelectedButtons>>(json);
            //}

            //// Add the new list to the existing data
            //existingData.AddRange(list);

            //// Serialize the combined data to JSON and write it to the file
            //string combinedJson = JsonConvert.SerializeObject(existingData);
            //File.WriteAllText(filePath, combinedJson);
        }
        public RelayCommand SelectedCommand { get; set; }
        public RelayCommand NextPlacesButtonClickCommand { get; set; }
        public RelayCommand BackSessionButtonClickCommand { get; set; }
        public RelayCommand BackPlacesButtonClickCommand { get; set; }
        public RelayCommand BackSignUpButtonClickCommand { get; set; }
        public RelayCommand BackCardButtonClickCommand { get; set; }
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
        private int totalprice;
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
        public int TotalPrice
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
                MessageBox.Show("Số thẻ phải có 16 chữ số");
                IsCardAvailable = false;
            }
            if (Month > 12 || Month < 1)
            {
                MessageBox.Show("Tháng phải từ 1 đến 12!");
                IsCardAvailable = false;
            }
            if (Year.ToString().Length != 4)
            {
                MessageBox.Show("Năm phải có độ dài là 4!");
                IsCardAvailable = false;
            }
            if (Year < DateTime.Now.Year)
            {
                MessageBox.Show("Tháng không được trễ hơn hiện tại!");
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
        //private async void PlaceClick(Grid grid)
        //{
        //    List<int> numbers = new List<int>();
        //    string apiUrl = "https://21521809.pythonanywhere.com/toggleButtonState";

        //    HttpClient client = new HttpClient();

        //    HttpResponseMessage response = await client.GetAsync(apiUrl);
        //    string responseContent = await response.Content.ReadAsStringAsync();

        //    var data = JsonConvert.DeserializeObject<List<SelectedButtons>>(responseContent);
        //    foreach (UIElement child in grid.Children)
        //    {
        //        numbers = new List<int>();
        //        ToggleButton toggleButton = child as ToggleButton;
        //        if (toggleButton != null && !AllSeatNames.Any(m => m.ButtonName == toggleButton.Name))
        //        {
        //            //string jsonString = File.ReadAllText("toggleButtonState.json");

        //            //var data = JsonConvert.DeserializeObject<List<SelectedButtons>>(jsonString);
        //            if (data != null)
        //                {
        //                    foreach (var btn in data)
        //                    {
        //                        if (btn.Movie.MovieName == Movie.MovieName && btn.Movie.MovieDate == Movie.MovieDate && btn.Movie.MovieDateTime== Movie.MovieDateTime &&  btn.Movie.Theater == Movie.Theater && !AllSeatNames.Any(m => m.ButtonName == toggleButton.Name && m.Movie == Movie))
        //                        {
        //                            if (toggleButton.IsChecked == true && toggleButton.Name != btn.ButtonName)
        //                            {
        //                                IsSame = true;
        //                            }
        //                            else
        //                            {
        //                                IsSame = false;
        //                            }
        //                            numbers.Add(0);
        //                        }
        //                        else
        //                        {
        //                            numbers.Add(1);
        //                        }
        //                    }
        //                }
        //             if (IsSame || !numbers.Contains(0))
        //                {
        //                    if (toggleButton.IsChecked == true)
        //                    {
        //                        Places(toggleButton);
        //                        var current = new SelectedButtons { Movie = Movie, ButtonName = toggleButton.Name, IsChecked = (bool)toggleButton.IsChecked };
        //                        AllSeatNames.Add(current);
        //                        data.Add(current);
        //                        toggleButton.IsEnabled = false;
        //                        SelectedRows.Add(SelectedRow);
        //                        SelectedColumns.Add(SelectedColumn);

        //                        string jsonString = JsonConvert.SerializeObject(current);
        //                        using (var client1 = new HttpClient())
        //                        {
        //                            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

        //                            var response1 = await client1.PostAsync("https://21521809.pythonanywhere.com/addtogglebutton", content);

        //                        }

        //                    //jsonString = JsonConvert.SerializeObject(data);
        //                    //File.WriteAllText("toggleButtonState.json", jsonString);
        //                    break;
        //                    }
        //                }
        //        }
        //        //else
        //        //    {
        //        //        if (toggleButton.IsChecked == true)
        //        //        {
        //        //            Places(toggleButton);
        //        //            var current = new SelectedButtons { Movie = Movie, ButtonName = toggleButton.Name, IsChecked = (bool)toggleButton.IsChecked };
        //        //            AllSeatNames.Add(current);
        //        //            toggleButton.IsEnabled = false;
        //        //            SelectedRows.Add(SelectedRow);
        //        //            SelectedColumns.Add(SelectedColumn);
        //        //            string jsonString = JsonConvert.SerializeObject(current);
        //        //            using (var client1 = new HttpClient())
        //        //            {
        //        //                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

        //        //                var response1 = await client1.PostAsync("https://21521809.pythonanywhere.com/addtogglebutton", content);

        //        //            }
        //        //        //string jsonString = JsonConvert.SerializeObject(AllSeatNames);
        //        //        //File.WriteAllText("toggleButtonState.json", jsonString);
        //        //        }
        //        //    }
        //    }
        //}
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
                    MessageBox.Show("Bạn phải chọn số lượng vé!");
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
                    MessageBox.Show("Số lượng đặt chổ phải bằng số lượng vé bạn đã chỉ định!");
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

            BackSignUpButtonClickCommand = new RelayCommand((obj) =>
            {
                if (Count > 0)
                {
                    SignUpVisibility = Visibility.Hidden;
                    PaymentVisibility = Visibility.Visible;
                    PlacesBackground = "#7c2121";
                    PaymentBackground = "Red";
                }

            });

            BackCardButtonClickCommand = new RelayCommand((obj) =>
            {
                if (Count > 0)
                {
                    PaymentVisibility = Visibility.Visible;
                    CardVisibility= Visibility.Hidden;
                    PlacesBackground = "#7c2121";
                    PaymentBackground = "Red";
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
            SignedCommand = new RelayCommand(async (obj) =>
            {
                IsAvailable = true; 
                var data2 = new List<string>(); // Tạo một danh sách mới để lưu trữ các emails

                foreach (var item in App.EmailRepo.Emails)
                {
                    data2.Add(item.UserEmail);
                }
                if (EmailName == null || Password == null || UserName == null || Surname == null)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin ");
                    IsAvailable = false;
                }
                else if (EmailName != null && Password != null)
                {
                    
                    if (!EmailName.Contains("@gmail.com"))
                    {
                        MessageBox.Show("Gmail không chính xác !");
                        IsAvailable = false;
                    }
                    else if (data2.Contains(EmailName))
                    {
                        MessageBox.Show("Gmail đã được sử dụng. Vui lòng chọn gmail khác!");
                        IsAvailable = false;
                    }

                    if (Password.Length < 8)
                    {
                        MessageBox.Show("Password phải có độ dài lớn hơn hoặc bằng 8!");
                        IsAvailable = false;
                    }
                    if (!Password.ToString().Any(char.IsUpper))
                    {
                        MessageBox.Show("Password phải chứa ít nhất 1 ký tự in hoa!");
                        IsAvailable = false;
                    }
                }

                
                if (IsAvailable == true)
                {
                    var mail = new Email();
                    
                    mail.Id = App.EmailRepo.Emails[App.EmailRepo.Emails.Count - 1].Id + 1;
                    mail.UserEmail = EmailName;
                    mail.UserName = UserName;
                    string plainText = Password;
                    byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                    string encodedText = Convert.ToBase64String(plainTextBytes);
                    mail.UserPassword = encodedText;
                    mail.UserSurname = Surname;
                    
                    
                    
                    App.EmailRepo.Emails.Add(mail);
                    string jsonString = JsonConvert.SerializeObject(mail);
                    using (var client = new HttpClient())
                    {
                        var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                        var response = await client.PostAsync("http://21521809.pythonanywhere.com/register", content);

                    }

                    //var data = new List<Email>(); // Tạo một danh sách mới để lưu trữ các emails

                    //foreach (var item in App.EmailRepo.Emails)
                    //{
                    //    data.Add(item);
                    //}

                    //string jsonString = JsonConvert.SerializeObject(data);
                    //File.WriteAllText("emails.json", jsonString);

                    MessageBox.Show("Email đăng ký thành công!");
                    PaymentVisibility = Visibility.Visible;
                    SignUpVisibility = Visibility.Hidden;
                }
            });
            LoginCommand = new RelayCommand((obj) =>
            {
                int i = 0;
                foreach (var item in App.EmailRepo.Emails)
                {
                    string encodedText = item.UserPassword;
                    byte[] encodedBytes = Convert.FromBase64String(encodedText);
                    string decodedText = Encoding.UTF8.GetString(encodedBytes);
                    if (item.UserEmail == EmailName && decodedText == Password.ToString())
                    {
                        i = i + 1;
                        PaymentVisibility = Visibility.Hidden;
                        CardVisibility = Visibility.Visible;
                    }
                }
                if (i == 0)
                {
                    MessageBox.Show("Thông tin đăng nhập không chính xác!");
                }
            });
            OrderCommand = new RelayCommand((obj) =>
            {
                Order();

            });
            PlaceClickCommand = new RelayCommand(async (obj) =>
            {
                if (counter < Count-1)
                {
                    counter++;
                }
                else
                {
                    IsButtonEnabled = false;
                    counter = 0;
                }

                ToggleButton clickedToggleButton = obj as ToggleButton;
                if (clickedToggleButton == null) return;
                Places(clickedToggleButton);
                var current = new SelectedButtons { Movie = Movie, ButtonName = clickedToggleButton.Name, IsChecked = (bool)clickedToggleButton.IsChecked };
                AllSeatNames.Add(current);
                clickedToggleButton.IsEnabled = false;
                SelectedRows.Add(SelectedRow);
                SelectedColumns.Add(SelectedColumn);

                string jsonString = JsonConvert.SerializeObject(current);
                using (var client1 = new HttpClient())
                {
                    var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                    var response1 = await client1.PostAsync("https://21521809.pythonanywhere.com/addtogglebutton", content);

                }
            });

        }
    }
}





