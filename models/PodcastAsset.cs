public class PodcastAsset:MediaAsset
{
    public PodcastAsset(string title): base(title)
    {}

    public override void Play()
    {
        Console.WriteLine("Podkast ewwitilmoqda");
    }
    public override string GetFormat()
    {
        Console.WriteLine("podcast");
    }
}