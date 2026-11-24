public class AudiAsset : MediaAsset
{
    public AudiAsset(string title):base(title)
    //obyektini yaratishda uning nomini (title) qabul qilib, ota class — MediaAsset ga uzatish uchun kerak.
    {

    }
    public override void Play()
    {
        Console.WriteLine("Audio aytilmoqda:");
    }
    public override string GetFormat() //Audio qanaqa formatda ekanligini qaytaradi
    {
        return "Mp3";
    }
}