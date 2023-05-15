namespace Homework_3
{
    public abstract class Shape
    {
        public int Id { get; set; }

        public abstract double GetArea();
        public abstract double GetPerimeter(); 
    }
}
