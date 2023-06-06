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
    public class EmailRepository
    {
        public List<Email> Emails { get; set; }

        public EmailRepository()
        {

            Emails = ReadEmails();

        }
        public List<Email> ReadEmails()
        {
            Task<List<Email>> task = ReadEmailAsync();
            task.Wait(); // Chờ phương thức hoàn thành

            List<Email> emails = task.Result; // Lấy kết quả trả về

            return emails;
        }
        public static async Task<List<Email>> ReadEmailAsync()
        {
            string apiUrl = "http://21521809.pythonanywhere.com/users";

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(apiUrl);
            string responseContent = await response.Content.ReadAsStringAsync();

            List<Email> emails = JsonConvert.DeserializeObject<List<Email>>(responseContent);

            return emails;
        }

    }
}
