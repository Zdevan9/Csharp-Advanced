using System.Buffers;
using System.Linq;

namespace Class_4_Homework
{
    public static class DogStatic
    {
        public static List<Dog> dogs = new List<Dog>();

        static DogStatic()
        {
            Dog myDog = new("Fido", 5, "brown", "Labrador", PersonStatic.people.SingleOrDefault(p => p.FirstName == "Cristofer" && p.LastName == "Columbus"));
            Dog myDog2 = new("Buddy", 3, "black", "German Shepherd", PersonStatic.people.SingleOrDefault(p => p.FirstName == "Cristofer" && p.LastName == "Columbus"));
            Dog myDog3 = new("Charlie", 2, "white", "Poodle", PersonStatic.people.SingleOrDefault(p => p.FirstName == "Freddy" && p.LastName == "Mercury"));
            Dog myDog4 = new("Max", 7, "golden", "Golden Retriever", PersonStatic.people.SingleOrDefault(p => p.FirstName == "Amelia" && p.LastName == "Heart"));
            Dog myDog5 = new("Rocky", 4, "gray", "Bulldog", PersonStatic.people.SingleOrDefault(p => p.FirstName == "Amelia" && p.LastName == "Heart"));
            Dog myDog6 = new("Luna", 1, "black and white", "Siberian Husky", PersonStatic.people.SingleOrDefault(p => p.FirstName == "Erin" && p.LastName == "Earhart"));
            Dog myDog7 = new("Bentley", 6, "brown", "Boxer", PersonStatic.people.SingleOrDefault(p => p.FirstName == "Amelia" && p.LastName == "Heart"));
            Dog myDog8 = new("Chloe", 2, "white", "Maltese", PersonStatic.people.SingleOrDefault(p => p.FirstName == "Alice" && p.LastName == "Robertson"));
            Dog myDog9 = new("Milo", 3, "brown and black", "Beagle", PersonStatic.people.SingleOrDefault(p => p.FirstName == "Bob" && p.LastName == "Robsky"));
            dogs.Add(myDog);
            dogs.Add(myDog2);
            dogs.Add(myDog3);
            dogs.Add(myDog4);
            dogs.Add(myDog5);
            dogs.Add(myDog6);
            dogs.Add(myDog7);
            dogs.Add(myDog8);
            dogs.Add(myDog9);
        }


        //Methods Here
        public static List<Dog> BrownDogs()
        {
            var brownDogs = DogStatic.dogs
                .Where(d => d.Color == "brown").ToList();

            Console.WriteLine("List of all the brown dogs:");

            return brownDogs;
        }
        public static List<Person> PersonsWithTwoDogs()
        {
            Console.WriteLine("People who have 2 or more dogs:");
            var personsWithTwoDogs = PersonStatic.people
                .Where(p => DogStatic.dogs.Count(d => d.Owner != null && d.Owner.FirstName == p.FirstName && d.Owner.LastName == p.LastName) >= 2)
                .ToList();
            return personsWithTwoDogs;
        }
        public static  List<Dog> FreddysDogs()
        {
            Console.WriteLine("Dogs owned by Freddy");
            var freddydogs = DogStatic.dogs
                .Where(o => o.Owner != null && o.Owner.FirstName == "Freddy")
                .ToList();

            foreach (var dog in freddydogs)
            {
                Console.WriteLine(dog);
            }

            return freddydogs; 
        }
        public static List <Dog> NathensDogs()
        {
            Console.WriteLine("Nathen's first dog is: ");
            var nathensdogs = DogStatic.dogs
                .Where(n => n.Owner != null && n.Owner.FirstName == "Nathen")
                .ToList();

            if(nathensdogs.Count == 0) 
            {
                Console.WriteLine("Nathen doesn't have any dogs");
            }
            return nathensdogs;
        }
        public static List <Dog> WhiteDogs() 
        {
            Console.WriteLine("All of the dogs with white color and their owners");
            var whitedogs = DogStatic.dogs
                .Where(w=> w.Color == "white")
                .ToList();
            foreach (var dog in whitedogs)
            {

                Console.WriteLine($"{dog.DogName} (owned by {dog.Owner.FirstName} {dog.Owner.LastName})");
            }
            return whitedogs;
                
        }
    }
}
