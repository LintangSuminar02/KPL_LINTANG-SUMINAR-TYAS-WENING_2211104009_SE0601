using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_2211104009
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser user = new SayaTubeUser("Lintang Suminar");

            string[] judulFilm = {
            "Devdas",
            "The Shawsank Redemption",
            "A Beautiful Mind",
            "Parasite",
            "Mohabbatein",
            "Thor 1,2,3",
            "Spiderman: No Way Home",
            "Kungfu Panda",
            "The Godfather",
            "3 idiots"
        };

            foreach (string judul in judulFilm)
            {
                try
                {
                    SayaTubeVideo video = new SayaTubeVideo($"Review Film oleh Lintang Suminar: {judul}");
                    video.IncreasePlayCount(new Random().Next(1000, 10000));
                    user.AddVideo(video);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            user.PrintAllVideoPlaycount();
            Console.WriteLine($"Total Play Count: {user.GetTotalVideoPlayCount()}");
        }
    }
}