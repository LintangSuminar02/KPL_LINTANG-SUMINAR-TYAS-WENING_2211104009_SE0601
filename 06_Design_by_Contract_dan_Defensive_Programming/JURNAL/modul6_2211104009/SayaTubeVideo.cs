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
            if (title == null || title.Length > 200) throw new ArgumentException("Judul tidak valid.");
            this.title = title;
            Random rnd = new Random();
            this.id = rnd.Next(10000, 99999);
            this.playCount = 0;
        }
        public string GetTitle()
        {
            return this.title;
        }


        public void IncreasePlayCount(int count)
        {
            if (count < 0 || count > 25000000) throw new ArgumentOutOfRangeException("Count tidak valid.");
            checked { this.playCount += count; }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {id}, Title: {title}, Play Count: {playCount}");
        }

        public int GetPlayCount() => playCount;
    }
}