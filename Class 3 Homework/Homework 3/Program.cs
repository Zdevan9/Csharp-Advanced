using Homework_3;

DB<Shape> db = new DB<Shape>();
Circle circle = new Circle {Radius = 55 };
Rectangle rectangle = new Rectangle { SideA = 15, SideB = 100 };
db.Add(circle);
db.Add(rectangle);
db.PrintAreas();
db.PrintPerimeters();
circle.PrintInfo();
rectangle.PrintInfo();