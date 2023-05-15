namespace ConsoleApp1
{
    internal class Bike : Vehicle
    {
    public string Color { get; set; }
        
    public override void PrintVehicle()
    {
        Console.WriteLine($"The bike was produced in {YearOfProduction}, and has a {Color} color.");
    }
    }
}
