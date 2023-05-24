using Newtonsoft.Json;
using ParkCinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ParkCinema.Services
{
    public class AddMovie
    {
        public static dynamic Data { get; set; }
        public static dynamic SingleData { get; set; }

        public static List<Movie> GetMovies(string movie)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = new HttpResponseMessage();

            response = httpClient.GetAsync($@"http://www.omdbapi.com/?apikey=3eb9dfa5&s={movie}&plot=full").Result;
            var str = response.Content.ReadAsStringAsync().Result;
            Data = JsonConvert.DeserializeObject(str);

            List<Movie> movies = new List<Movie>();

            try
            {
                for (int i = 0; i < 3; i++)
                {
                    response = httpClient.GetAsync($@"http://www.omdbapi.com/?apikey=3eb9dfa5&t={Data.Search[i].Title}&plot=full").Result;
                    str = response.Content.ReadAsStringAsync().Result;
                    SingleData = JsonConvert.DeserializeObject(str);

                    var myMovie = new Movie
                    {
                        About = SingleData.Plot,
                        ImagePath = SingleData.Poster,
                        MovieName = SingleData.Title,
                        Rating = SingleData.imdbRating,
                    };
                    movies.Add(myMovie);
                }
            }
            catch (Exception)
            {
            }
            return movies;
        }
    }
}
