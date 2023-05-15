namespace ConsoleApp1
{
    public static class VehicleDB
    {
        public static List<Vehicle> Vehicles = new List<Vehicle>
        {
            new Car
            {
                Id = 1,
                Type = "Sports Car",
                YearOfProduction = 2020,
                BatchNumber = 1,
                Fuel = 60,
                Country = "France"
            },
            new Car {
                Id = 2,
                Type = "SUV",
                YearOfProduction = 2018,
                BatchNumber = 2,
                Fuel = 100,
                Country = "USA"
            },
            new Bike
            {
                Id = 3,
                Type = "Mountain Bike",
                YearOfProduction = 2016,
                BatchNumber = 3,
                Color = "Green"
            }
        };

        
    }
}
