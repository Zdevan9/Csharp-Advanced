namespace Homework_3
{
    public class DB<T> where T : Shape
    {
        private List<T> shapes;

        public DB()
        {
            shapes = new List<T>();
        }
        public void Add(T shape)
        {
            shapes.Add(shape);
        }
        public void PrintAreas()
        {
            foreach (T shape in shapes)
            {
                Console.WriteLine($"Shape area = {shape.GetArea()}");
            }
        }
        public void PrintPerimeters()
        {
            foreach (T shape in shapes)
            {
                Console.WriteLine($"Shape perimeter = {shape.GetPerimeter()}");
            }
        }

    }
    public static class ShapeExtensions
    {
        public static void PrintInfo(this Circle circle)
        {
            Console.WriteLine($"Circle radius = {circle.Radius}");
        }

        public static void PrintInfo(this Rectangle rectangle)
        {
            Console.WriteLine($"Rectangle sideA = {rectangle.SideA}, sideB = {rectangle.SideB}");
        }
    }
}
