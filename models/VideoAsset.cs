public class VideoAssed:MediaAsset
{
    public VideoAssed(string title):base(title) // constructor
    {}

    public override void Play() //video kursatadi
    {
        Console.WriteLine("Video kursatadi");
    }
    public override string GetFormat()
    {
        Console.WriteLine("Mp4");
    }
}