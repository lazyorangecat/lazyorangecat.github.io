using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleLibrary2
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int Compute()
        {
            return Width * Height;
        }
    }
}
