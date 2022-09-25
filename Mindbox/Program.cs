using Mindbox;

string choice = String.Empty;
while (true)
{
    Console.WriteLine("Select a shape to calculate its area: ");
    Console.WriteLine("1 - triangle");
    Console.WriteLine("2 - circle");
    int figure = Convert.ToInt32(Console.ReadLine());
    switch (figure)
    {
        case 1:
            double sideAB, sideBC, sideAC;

            Console.Write("Enter side AB: ");
            sideAB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side BC: ");
            sideBC = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side AC: ");
            sideAC = Convert.ToDouble(Console.ReadLine());

            var triangle = new Triangle(sideAB, sideBC, sideAC);
            double area = triangle.Area();
            Console.WriteLine($"Area of a triangle: {area}");
            break;
        case 2:
            double radius;

            Console.Write("Enter radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            var circle = new Circle(radius);
            double areaCircle = circle.Area();
            Console.WriteLine($"Area of a circle: {areaCircle}");
            break;
        default:
            Console.WriteLine("Error. Enter 1 or 2");
            break;
    }
    Console.WriteLine("Recalculate? y/n");
    choice = Console.ReadLine();
    if (choice == "n")
        break;
}

