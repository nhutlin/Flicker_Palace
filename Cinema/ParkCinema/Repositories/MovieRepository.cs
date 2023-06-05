using Newtonsoft.Json;
using ParkCinema.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ParkCinema.Repositories
{
    public class MovieRepository
    {

        public List<Movie> Movies { get; set; }

        public MovieRepository()
        {

            Movies = ReadMovies();

        }
        public List<Movie> ReadMovies()
        {
            Task<List<Movie>> task = ReadMoviesAsync();
            task.Wait(); // Chờ phương thức hoàn thành

            List<Movie> movies = task.Result; // Lấy kết quả trả về

            return movies;
        }
        public static async Task<List<Movie>> ReadMoviesAsync()
        {
            string apiUrl = "http://21521809.pythonanywhere.com/movies";

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(apiUrl);
            string responseContent = await response.Content.ReadAsStringAsync();

            List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(responseContent);

            return movies;
        }  
    }
}
