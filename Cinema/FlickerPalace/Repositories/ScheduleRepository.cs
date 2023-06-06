using Newtonsoft.Json;
using FlickerPalace.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FlickerPalace.Repositories
{
    public class ScheduleRepository
    {
        public List<MovieSchedule> MovieSchedules { get; set; }

        public ScheduleRepository()
        {

            MovieSchedules = ReadMovieSchedules();

        }
        public List<MovieSchedule> ReadMovieSchedules()
        {
            Task<List<MovieSchedule>> task = ReadMovieSchedulesAsync();
            task.Wait(); // Chờ phương thức hoàn thành

            List<MovieSchedule> movieschedule = task.Result; // Lấy kết quả trả về

            return movieschedule;
        }
        public static async Task<List<MovieSchedule>> ReadMovieSchedulesAsync()
        {
            string apiUrl = "http://21521809.pythonanywhere.com/schedule";

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(apiUrl);
            string responseContent = await response.Content.ReadAsStringAsync();

            List<MovieSchedule> movieschedule = JsonConvert.DeserializeObject<List<MovieSchedule>>(responseContent);

            return movieschedule;
        }
    }
}
