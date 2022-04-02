using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Figure
    {
        public string Type { get; set; }
        public Figure(string type)
        {
            Type = type;
        }
        public abstract double Square();
        public override string ToString()
        {
            return $"Фигура: {Type}";
        }
    }

}
