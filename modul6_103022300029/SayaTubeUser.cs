using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300029
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> UploadedVideos;
        private String username;
        
        public SayaTubeUser(string username)
        {
            Debug.Assert(!string.IsNullOrEmpty(username) && username.Length <= 100, "Username User harus tidak null dan maksimal 100 karakter.");
            this.username = username;
            this.UploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (var video in this.UploadedVideos)
            {
                total = video.GetPlayCount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            
            if (video == null) 
            {
                throw new ArgumentException("Username User harus tidak null");
            }
            UploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayerCount()
        {
            Console.WriteLine("User: " + username);
            for (int i = 0; i < this.UploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " judul: " + UploadedVideos[i].GetTitle());
            }
        }
    }
}
