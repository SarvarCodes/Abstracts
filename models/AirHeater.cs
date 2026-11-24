public class AirHeater : Appliance
{
    public override string Name {get;set;}

    public override double CalcultePowerConsumtion(int hours)
    {
        return 2* hours;
    }
}