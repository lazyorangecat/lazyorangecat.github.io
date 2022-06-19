using ShapeLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Helpers
{
    public static class ShapeHelper
    {
        public static double ComputeArea(this Rectangle input)
        {
            return input.Width * input.Height;
        }
        public static double ComputeArea(this Circle input)
        {
            return Math.PI * Math.Pow(input.Radius, 2);
        }
        public static double ComputePerimeter(this Rectangle input)
        {
            return (input.Width + input.Height) * 2;
        }
        public static double ComputePerimeter(this Circle input)
        {
            return 2 * input.Radius * Math.PI;
        }
    }
}
