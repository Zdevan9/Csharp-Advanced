using Homework;
using Newtonsoft.Json;

Console.WriteLine("Enter the dog's name:");
string name = Console.ReadLine();

Console.WriteLine("Enter the dog's age:");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the dog's color:");
string color = Console.ReadLine();

Dog dog = new Dog()
{
    Name = name,
    Age = age,
    Color = color
};

string json = JsonConvert.SerializeObject(dog);
File.WriteAllText("dog.json", json);
string fileContents = File.ReadAllText("dog.json");
Console.WriteLine(fileContents);
