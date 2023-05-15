namespace ConsoleApp1
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"The vehicle has an ID of: {Id}, it's a {Type}, and was produced in {YearOfProduction}");
        }

    }
}
