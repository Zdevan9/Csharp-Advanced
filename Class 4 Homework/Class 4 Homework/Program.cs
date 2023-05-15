using Class_4_Homework;


List<Person> peopleWithR = PersonStatic.PersonsWithR();
foreach (Person person in peopleWithR)
{
    Console.WriteLine(person.FirstName);
}

List<Dog> BrownDogs = DogStatic.BrownDogs();
foreach (Dog g in BrownDogs)
{
    Console.WriteLine(g);
}

var peopleWithTwoDogs = DogStatic.PersonsWithTwoDogs();
foreach (var person in peopleWithTwoDogs)
{
    Console.WriteLine($"Person {person.FirstName} {person.LastName} has {DogStatic.dogs.Count(d => d.Owner == person)} dogs");
}

List<Dog> freddysDogs = DogStatic.FreddysDogs();
List<Dog> nathensDogs = DogStatic.NathensDogs();
List<Dog> whiteDogs = DogStatic.WhiteDogs();