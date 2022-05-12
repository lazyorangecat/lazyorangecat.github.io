using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualitySample001
{
   class MyRectangle : IEquatable<MyRectangle>
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as MyRectangle);
        }

        public bool Equals(MyRectangle other)
        {
            return other != null &&
                   Width == other.Width &&
                   Height == other.Height;
        }

        public override int GetHashCode()
        {
            int hashCode = 859600377;
            hashCode = hashCode * -1521134295 + Width.GetHashCode();
            hashCode = hashCode * -1521134295 + Height.GetHashCode();
            return hashCode;
        }
    }   
}
