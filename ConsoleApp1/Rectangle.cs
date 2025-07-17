using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    internal class Rectangle: IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double Area => Width * Height;
        public string DisplayShapeInfo()
        {
            return $"Rectangle with width {Width} and height {Height} has an area of {Area}.";
        }
    }
   
}
