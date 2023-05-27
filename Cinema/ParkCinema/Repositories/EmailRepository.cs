using ParkCinema.Helpers;
using ParkCinema.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkCinema.Repositories
{
    public class EmailRepository
    {
        public List<Email> Emails { get; set; }

        public EmailRepository()
        {
            if (!File.Exists("emails.json"))
            {
                Emails = new List<Email>
                {
                    new Email
                    {
                        Id=1,
                        UserName="Jack",
                        UserSurname="Rose",
                        UserEmail="user@gmail.com",
                        UserPassword="12345678A"
                    }
                };
                FileHelper.WriteEmails(Emails);
            }
            else
            {
                Emails = FileHelper.ReadEmails();
            }
        }
    }
}
