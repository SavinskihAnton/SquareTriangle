using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Triangle : Figure
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public Triangle(string type, double a, double b, double c):base(type)
        {
            if(Proverka1(a,b,c))
            Side1 = a;
            Side2 = b;
            Side3 = c;
        }
        public override double Square()
        {
            double p = (Side1 + Side2 + Side3) / 2;
            double square = Math.Sqrt(p*(p-Side1)*(p-Side2)*(p-Side3));
            return square;
        }
        public bool Proverka1(double a, double b, double c)
        {
            string message1 = "Не существует треугольника с отрицательной стороной";
            string message2 = "Не существует треугольника со стороной больше суммы двух других сторон";
            if (a < 0 || b < 0 || c < 0)
            {
                throw new MyException(message1);
            }
            if (a > (b + c) || b > (a + c) || c > (a + b))
            {
                throw new MyException(message2);
            }
            return true;
        }
        public string RightTriangle() //Теорема Пифагора, используем для определения прямоугольного треугольника
        {
            if (Side1 == Math.Sqrt(Math.Pow(Side2, 2) + Math.Pow(Side3, 2))
              || (Side2 == Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side3, 2))
              || (Side3 == Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side2, 2)))))
            {
                Console.WriteLine("Треугольник является прямоугольным");
            }
            else
            {
                Console.WriteLine("Треугольник не является прямоугольным");
            }
            return "Проверка определения треугольника завершена";
        }
    }
}
