using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    internal interface IShape
    {
        double Area { get; }
        string DisplayShapeInfo();


    }

    internal interface ICircle : IShape
    {
    }
    internal interface IRectangle : IShape
    {
    }
}
