public class Appliansce
{
    public string Name; //property
    
    public abstract void CalcultePowerConsumtion(int hours); //abstract metod

    public void ShowName() //concrete qurilma nomini chiqaradi 
    {
        Console.WriteLine($"qurilma nomi:{Name}");
    }
     public double CalculateWeeklyConsumption(int hoursPerDay)
     {
        return CalcultePowerConsumtion(hoursPerDay *7); // haftalik sarfni qaytaradi
     }
}