using modul6_103022300029;

class main
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Damai Putra Yudha");
        List<SayaTubeVideo> videos = new List<SayaTubeVideo>();

        for (int i = 0; i < 10; i++)
        {
            videos.Add(new SayaTubeVideo("Review film Naruto " + (i + 1) + " Oleh Damai Putra Yudha"));
            user.AddVideo(videos[i]);
        }
        user.PrintAllVideoPlayerCount();
    }
}