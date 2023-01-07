//This is a programe to compute the areas of shapes

int option;
Shape shape = new Shape();
double area = 0;

Console.Clear();
Console.WriteLine("***********************************");
Console.WriteLine("Programe to compute area of shapes");
Console.WriteLine("***********************************");
Console.WriteLine();
Console.WriteLine("Shape Area - Select a shape:");
Console.WriteLine();

Console.WriteLine("1. Area of Circle");
Console.WriteLine("2. Area of Rectangle");
Console.WriteLine("3. Area of Triangle");
Console.WriteLine("4. Area of square");
Console.WriteLine();

Console.Write("Option: ");
option = Convert.ToInt32(Console.ReadLine());

switch (option)
{
    case 1:
    area = shape.CircleArea();
    break;

    case 2:
    area = shape.RectangleArea();
    break;

    case 3:
    area = shape.CircleArea();
    break;

}

//Area area = new Area();
//double answer = area.Rectangle(2,2);





public class Shape{
    
    public double CircleArea()
    {

        double aCircle = 0;
   
        return aCircle;
    }

    public double SquareArea()
    {

        double aSquare = 0;
   
        return aSquare;
    }
    
    public double TriangleArea()
    {

        double aTriangle = 0;
   
        return aTriangle;
    }

    public double RectangleArea(double l, double b)
    {
        double length = l;
        double breadth = b;
        double aRectangle = 0;

        aRectangle = length * breadth;

        return aRectangle;
    }

}



