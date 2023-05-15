using System.Xml.Linq;

namespace Class_4_Homework
{
    public class Dog
    {
       
        public string DogName { get; set; } 
        public int DogAge { get; set; } 
        public string Color { get; set; }   
        public string Breed { get; set; }
        public Person Owner { get; set; }

        public Dog(string dogname, int age, string color, string breed, Person owner) 
        {
            DogName = dogname;
            DogAge = age;
            Color = color; 
            Breed = breed;
            Owner = owner;


        }

        public override string ToString()
        {
            return $"Name: {DogName}, Breed: {Breed}, Age: {DogAge}, Color: {Color} owned by {Owner.FirstName} {Owner.LastName}";
        }
    }
}
