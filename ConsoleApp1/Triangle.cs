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
            Side1 = a;
            Side2 = b;
            Side3 = c;
        }
        
    }
}
