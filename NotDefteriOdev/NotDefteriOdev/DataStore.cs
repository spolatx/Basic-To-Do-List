using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteriOdev
{
    public class DataStore
    {
        public static AppUser appUser = new AppUser { Id = 1, Name = "admin", Password = "1" };
        public static List<Note> notes = new List<Note>()
        {
            new Note{Id=1,Description="Mvc ile Dinamik Cv sitesi Projesini Bitir."},
            new Note{Id=2,Description="Her gün LeetCode üzerinden bir soru çöz."},
            new Note{Id=3,Description="100 Derste Mvc Proje Kampına başla.(Eylül-Ekim) "},
            new Note{Id=4,Description="100 Derste Asp.Net Core Mvc Projesini Aralık sonuna kadar bitir. "}

        };
    }

    public class Note
    {
        public int Id { get; set; }
        public string Description { get; set; } 
    }

    public class AppUser
    {
        public string Password { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
