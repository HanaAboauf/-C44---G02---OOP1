using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Area => Math.PI * Radius * Radius;
        public string DisplayShapeInfo()
        {
            return $"Circle with radius {Radius} has an area of {Area}.";
        }
    }
   
}
