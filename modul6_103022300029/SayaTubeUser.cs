using System;
using System.Collections.Generic;
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
            this.username = username;
            this.UploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            return this.UploadedVideos.Count;
        }

        public void AddVideo(SayaTubeVideo video)
        {
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
