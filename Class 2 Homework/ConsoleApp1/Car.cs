namespace ConsoleApp1
{
    public class Car : Vehicle
    {
        public int Fuel { get; set; }
        public string Country { get; set; }

        public override void PrintVehicle()
        {
            Console.WriteLine($"The car was produced in {Country} and has a fuel capacity of {Fuel}.");
        }
    }
}
