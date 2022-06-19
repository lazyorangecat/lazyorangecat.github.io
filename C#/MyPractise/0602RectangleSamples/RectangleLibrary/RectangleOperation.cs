using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleLibrary
{
    public class RectangleOperation
    {
        public Rectangle Target { get; set; }

        public int ComputeArea()
        {
            return Target.Width * Target.Height;
        }
    }
}
