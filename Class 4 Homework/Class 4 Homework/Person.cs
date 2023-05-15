namespace Class_4_Homework
{
    public class Person
    {
        public string FirstName { get; set; }  
        public string LastName { get; set; }
        public int NumOfDogs { get; set; }

        public List<Dog> Dogs { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Dogs = new List<Dog>(); 

        }
    }
}
