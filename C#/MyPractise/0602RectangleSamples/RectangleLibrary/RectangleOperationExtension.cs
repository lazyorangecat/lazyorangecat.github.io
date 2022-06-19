using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleLibrary
{
    public static class RectangleOperationExtension
    {
        public static int ComputeArea(this Rectangle input)
        {
            return input.Width * input.Height;
        }
    }
}
