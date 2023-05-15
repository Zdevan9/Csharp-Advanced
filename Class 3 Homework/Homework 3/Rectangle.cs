namespace Homework_3
{
    public class Rectangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public override double GetArea()
        {
            return SideA * SideB;
        }

        public override double GetPerimeter()
        {
            return 2 * (SideA + SideB);
        }

    }
}
