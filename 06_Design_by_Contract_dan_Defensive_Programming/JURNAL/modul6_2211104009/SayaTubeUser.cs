using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_2211104009
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username { get; private set; }

        public SayaTubeUser(string username)
        {
            if (username == null || username.Length > 100) throw new ArgumentException("Username tidak valid.");
            this.Username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
            Random rnd = new Random();
            this.id = rnd.Next(10000, 99999);
        }
        public void AddVideo(SayaTubeVideo video)
        {
            if (video == null || video.GetPlayCount() > int.MaxValue)
                throw new ArgumentException("Video tidak valid.");
            this.uploadedVideos.Add(video);
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (var video in uploadedVideos)
                total += video.GetPlayCount();
            return total;
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"User: {Username}");
            for (int i = 0; i < uploadedVideos.Count && i < 10; i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetTitle()}");
            }
        }
    }
}