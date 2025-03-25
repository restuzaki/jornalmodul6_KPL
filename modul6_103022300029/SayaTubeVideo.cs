using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300029
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int PlayCount;

        public SayaTubeVideo(string title)
        {
            Random ran = new Random();
            this.title = title;
            this.id = ran.Next(10000, 99999);
            this.PlayCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.PlayCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"Id Video: {id}");
            Console.WriteLine($"Judul: {title}");
            Console.WriteLine($"Play Count: {PlayCount}");
        }

        public int GetPlayCount()
        {
            return this.PlayCount;
        }

        public string GetTitle()
        {
            return this.title;
        }
    }
}
