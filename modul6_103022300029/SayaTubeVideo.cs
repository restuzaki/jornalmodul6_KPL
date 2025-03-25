using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(!string.IsNullOrEmpty(title) && title.Length <= 200, "Judul video harus tidak null dan maksimal 200 karakter.");
            Random ran = new Random();
            this.title = title;
            this.id = ran.Next(10000, 99999);
            this.PlayCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count > 25000000)
            {
                throw new ArgumentException("Jumlah play count maksimal adalah 25.000.000 per panggilan.");
            } else if (count < 0)
            {
                throw new ArgumentException("Error: Play Count tidak boleh minus");
            }

            try
            {
                checked
                {
                    this.PlayCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Play count melebihi batas maksimum integer.");
            }
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
