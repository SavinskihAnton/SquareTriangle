using System;

namespace ConsoleApp1
{
    public class MyClass
    { 
        public void Square() //S=3.14*r*r
        { 
            double s;
            Console.Write("Введите радиус круга ");
            double r = Convert.ToDouble(Console.ReadLine());
            s = 3.14f*Math.Pow(r,2);
            Console.WriteLine("Площадь круга равна {0}",s);
            Console.WriteLine('-');
        }
        public void Triangle() ////S = √ (p· (p - a)· (p - b)· (p - c)), P = (a+b+c)/2 - формула Герона
        {
            double a, b, c, p, s;
            Console.Write("Введите первую сторону треугольника ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вторую сторону треугольника ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третью сторону треугольника ");
            c = Convert.ToDouble(Console.ReadLine());
            p = (a + b + c) / 2;
            s = Convert.ToDouble(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
            Console.WriteLine("Площадь треугольника равна {0}", s);
        }
    }
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
