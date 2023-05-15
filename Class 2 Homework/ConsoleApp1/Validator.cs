namespace ConsoleApp1
{
    public static class Validator
    {
        public static void Validate(Vehicle vehicle)
        {
            if (vehicle.Id == 0 && vehicle.Type == null && vehicle.YearOfProduction == 0)  
            {
                Console.WriteLine("Vehicle does not exist");   
            }
            else
            {
                Console.WriteLine("Vehicle is valid");
            }
        }
    }
}
