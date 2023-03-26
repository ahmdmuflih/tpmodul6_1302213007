using System;
namespace tpmodul6_1302213007;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random rand = new Random();
        id = rand.Next(10000, 99999);
        this.title = title;
        playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Video ID : {0} ", id);
        Console.WriteLine("Title : {0} ", title);
        Console.WriteLine("Play Count : {0} ", playCount);
    }
}