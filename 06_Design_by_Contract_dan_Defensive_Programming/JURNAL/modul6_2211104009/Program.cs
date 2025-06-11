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
            SayaTubeUser user = null;
            try
            {
                user = new SayaTubeUser("Lintang Suminar Tyas Wening");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error pada user: " + ex.Message);
            }

            string[] judulFilm = {
            "Devdas", "The Shawsank Redemption", "A Beautiful Mind", "Parasite",
            "Mohabbatein", "Thor 1,2,3", "Spiderman: No Way Home", "Kungfu Panda", 
            "The Godfather", "3 idiots"
            
            };

            foreach (string judul in judulFilm)
            {
                try
                {
                    SayaTubeVideo video = new SayaTubeVideo($"Review Film oleh Lintang: {judul}");
                    video.IncreasePlayCount(new Random().Next(1000000, 9000000));
                    user?.AddVideo(video);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error pada video: " + ex.Message);
                }
            }

            // ✅ Menguji postcondition: hanya 8 video yang di-print
            user?.PrintAllVideoPlaycount();

            Console.WriteLine($"Total Play Count: {user?.GetTotalVideoPlayCount()}");

            // ✅ Simulasi Overflow: Uji exception handling
            try
            {
                SayaTubeVideo videoOverflow = new SayaTubeVideo("Uji Overflow");
                for (int i = 0; i < 20; i++)
                {
                    videoOverflow.IncreasePlayCount(int.MaxValue / 10);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception saat overflow: " + ex.Message);
            }
        }
    }
}