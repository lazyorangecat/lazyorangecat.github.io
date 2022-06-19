using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhereSample001
{
    internal interface IPredicate<T>
    {
        bool Invoke(T item);
    }
}
