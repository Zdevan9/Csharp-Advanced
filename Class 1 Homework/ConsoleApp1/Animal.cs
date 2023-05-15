namespace ConsoleApp1
{
    public abstract class Animal : IAnimal
    {
        public abstract void PrintAnimal();
    }
    public class Dog : Animal, IDog
    {
        public override void PrintAnimal()
        {
            Console.WriteLine("I am a dog");
        }
        public void Bark()
        {
            Console.WriteLine("The dog is barking: Woof! Woof!");
        }
    }
    public class Cat : Animal, ICat
    {
        public override void PrintAnimal()
        {
            Console.WriteLine("I am a cat!");
        }
        public void Eat(string food)
        {
            Console.WriteLine($"The cat is eating {food}");
        }
    }
}

