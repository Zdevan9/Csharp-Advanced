using System.Xml.Linq;

namespace Class_4_Homework
{
    public static class PersonStatic
    {
        public static List<Person> people = new List<Person>();

        static PersonStatic()
        {
            Person human = new("John", "Doe");
            Person human2 = new("Jane", "Smith");
            Person human3 = new("Bob", "Johnson");
            Person human4 = new("Alice", "Robertson");
            Person human5 = new("Rob", "Robsky");
            Person human6 = new("Freddy", "Mercury");
            Person human7 = new("Cristofer", "Columbus");
            Person human8 = new("Erin", "Earhart");
            Person human9 = new("Amelia", "Heart");
            people.Add(human);
            people.Add(human2);
            people.Add(human3);
            people.Add(human4);
            people.Add(human5);
            people.Add(human6);
            people.Add(human7);
            people.Add(human8);
            people.Add(human9);
        }

        // Methods here
        public static List<Person> PersonsWithR()
        {
            var result = PersonStatic.people
        .Where(p => p.FirstName.Contains('R'))
        .OrderByDescending(p => p.FirstName).ToList();

            Console.WriteLine("Persons whose name starts with R:");

            return result;

        }

    }
    
}
