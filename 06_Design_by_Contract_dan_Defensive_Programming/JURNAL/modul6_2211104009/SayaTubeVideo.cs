using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_2211104009
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            if (string.IsNullOrEmpty(title) || title.Length > 200)
                throw new ArgumentException("Judul video tidak valid.");

            this.title = title;
            this.playCount = 0;

            Random rnd = new Random();
            this.id = rnd.Next(10000, 99999);
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0 || count > 25000000)
                throw new ArgumentOutOfRangeException("Nilai play count harus 0 - 25.000.000");

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi overflow pada playCount!");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {id}, Title: {title}, Play Count: {playCount}");
        }

        public int GetPlayCount() => playCount;

        public string GetTitle() => title;
    }
}