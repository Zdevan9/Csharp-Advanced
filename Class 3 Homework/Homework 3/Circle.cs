namespace Homework_3
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
