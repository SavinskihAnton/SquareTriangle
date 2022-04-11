using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Circle circle1 = new Circle("Круг",r);
            Console.WriteLine(circle1.ToString());
            Console.WriteLine("Площадь круга равна: {0}", circle1.Square());
            Console.WriteLine("--");

            Console.Write("Введите первую сторону треугольника: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вторую сторону треугольника: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третью сторону треугольника: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Triangle triangle = new Triangle("Треугольник", a,b,c);
            Console.WriteLine(triangle.ToString());
            Console.WriteLine("Площадь треугольника равна: {0}", triangle.Square());
            Console.WriteLine("--");
            Console.WriteLine(triangle.RightTriangle());

            Console.ReadLine();
        }
    }
}
