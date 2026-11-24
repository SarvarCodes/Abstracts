//**--1-media asset--**//
AudiAsset audio =new AudiAsset("My music");
VideoAssed video = new VideoAssed("My video");
PodcastAsset podcast = new PodcastAsset("My podkast");

MediaAsset[] assets = {audio,video,podcast};

foreach(MediaAsset asset in assets)
{
    asset.ShowTitle(); //media nomini chiqaradi
    Console.WriteLine($"{asset.GetFormat()} formatida chiqayapti");
    asset.Play();      //mediani play metodi chiqaradi
}

audio.ShowTitle();
audio.Play();
Console.WriteLine(audio.GetFormat());

video.ShowTitle();
video.Play();
Console.WriteLine(video.GetFormat());

podcast.ShowTitle();
podcast.Play();
Console.WriteLine(podcast.GetFormat());

//**--2-appliansce--**//

WashingMachine washingMachine = new WashingMachine();
AirHeater airheater = new AirHeater();
ElectricKettle elektric = new ElectricKettle();

Console.WriteLine($"WashingMachine: {washingMachine.PowerConsumtion} kWt/soat");
Console.WriteLine($"AirHeater: {airheater.PowerConsumtion} kWt/soat");
Console.WriteLine($"ElektricKette: {elektric.PowerConsumtion} kWt/soat");

Appliance[] appliances = {
    washingMachine,
    airheater,
    elektric
};

int hoursPerDay = 3;

foreach(Appliance appliance)
{
    appliance.ShowName(); // qurilma nomi chiqadi
    double dailyConsumption = appliance.CalcultePowerConsumtion(hoursPerDay); // 3 soatlik elektr sarfi hisoblanadi.

    Console.WriteLine($"3 soatlik sarf:{dailyConsumption} kWt");

    double weeklyConsumption = appliance.CalculateWeeklyConsumption(hoursPerDay); // 1 haftalik elektr sarfi hisoblanadi

    Console.WriteLine($"1 haftalik elektr sarfi {weeklyConsumption} kWt");
} 