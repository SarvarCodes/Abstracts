public abstract class MediaAsset
{
    public string Title; //property
    
    public abstract void Play() // abstract metod child classlarda yoziliwi kerak
    {

    }
    public abstract void GetFormat() // media fayl formatini qaytaradi
    {

    }
    public void ShowTitle() // concrete metodi oddiy metod
    {
        Console.WriteLine($"Media nomi: {Title}");
    }
}