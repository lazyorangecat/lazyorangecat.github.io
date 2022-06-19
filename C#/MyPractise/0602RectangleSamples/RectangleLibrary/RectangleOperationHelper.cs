using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleLibrary
{
    public class RectangleOperationHelper
    {
        public static int ComputeArea(Rectangle input)
        {
            return input.Width * input.Height;
        }
    }
}
