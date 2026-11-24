public class ElectricKettle : Appliance
{
    public override string Name {get;set;}

    public override double CalcultePowerConsumtion(int hours)
    {
        return 1.5 * hours;
    }
}