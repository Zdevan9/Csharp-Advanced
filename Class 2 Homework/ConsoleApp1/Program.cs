using ConsoleApp1;
Car car = new Car();
Bike bike = new Bike();
foreach (Vehicle vehicle in VehicleDB.Vehicles)
{
    vehicle.PrintVehicle();
    
}
Validator.Validate(car);
bike.Id = 10;
bike.Type = "Normal Bike";
bike.YearOfProduction = 2015;
Validator.Validate(bike);