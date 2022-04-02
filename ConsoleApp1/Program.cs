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
            MyClass my = new MyClass();
            my.Square();
            my.Triangle();

            Console.ReadLine();
        }
    }
}
