using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Circle:Figure
    {
        public double Radius { get; set; }
        public Circle(string type, double r) : base(type) 
        {
            Radius = r;
        }
        public override double Square()
        {
            return 3.14f*Math.Pow(Radius,2);
        }
    }
}
