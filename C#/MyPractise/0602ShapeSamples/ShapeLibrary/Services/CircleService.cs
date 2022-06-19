using ShapeLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Services
{
    public class CircleService : IShapeService
    {
        public Circle Target { get; set; }
        public double ComputeArea()
        {
            return Target.Radius*Target.Radius*Math.PI;
        }

        public double ComputePerimeter()
        {
            return Target.Radius*2* Math.PI;
        }
    }
}
