using System;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double width = Math.Max(x1, y1) - Math.Min(x1, y1);
            double height = Math.Max(x2, y2) - Math.Min(x2, y2);

            double area = width * height;
            double perimeter = 2 * (width + height);

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
