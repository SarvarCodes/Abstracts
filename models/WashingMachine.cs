public class WashingMachine: Appliance
{
    public override string Name{get;set;} // abstract name propertysini averride qilinadi

    public override double CalcultePowerConsumtion(int hours)
    {
        return 1* hours; // 1 soatda 1 kWt safrlawi va natijani qaytaradi
    }
}