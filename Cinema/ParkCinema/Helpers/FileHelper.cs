﻿using Newtonsoft.Json;
using ParkCinema.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace ParkCinema.Helpers
{
    public class FileHelper
    {
        public static void WriteEmails(List<Email> emails)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter("emails.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, emails);
                }
            }
        }

        public static List<Email> ReadEmails()
        {
            List<Email> emails = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("emails.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    emails = serializer.Deserialize<List<Email>>(jr);
                }
            }
            return emails;
        }

        public static void WriteMovies(List<Movie> movies)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter("movies.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, movies);
                }
            }
        }
        public static List<Movie> ReadMovies()
        {
            List<Movie> movies = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("movies.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    movies = serializer.Deserialize<List<Movie>>(jr);
                }
            }
            return movies;
        }
        public static void WriteMovieSchedule(List<MovieSchedule> movies)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter("moviesSchedule.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, movies);
                }
            }
        }
        public static List<MovieSchedule> ReadMovieSchedule()
        {
            List<MovieSchedule> movies = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("moviesSchedule.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    movies = serializer.Deserialize<List<MovieSchedule>>(jr);
                }
            }
            return movies;
        }
        
    }
}
