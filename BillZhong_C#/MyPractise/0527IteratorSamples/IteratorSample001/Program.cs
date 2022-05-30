using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSample001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach(var item in Exec())
            //{
            //    Console.WriteLine(item);
            //}
            //using(var enumerator=Exec().GetEnumerator())
            //{
            //    while(enumerator.MoveNext())
            //    {
            //        Console.WriteLine(enumerator.Current);
            //    }
            //}
            var enumerator = Exec().GetEnumerator();
            try
            {
                while(enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }
            }
            finally
            {
                enumerator.Dispose();
            }
            Console.ReadLine();
        }

        static IEnumerable<string> Exec()
        {
            yield return "A";
            yield return "B";
            yield return "C";
            //return new EnumerableString();
        }
    }

    internal class EnumerableString : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            return new Enumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class Enumerator : IEnumerator<string>
        {
            public string Current {get;private set;}

            object IEnumerator.Current
            {
                get { return Current; }
            }

            public void Dispose()
            {
                
            }

            int index=0;
            public bool MoveNext()
            {
                switch(index)
                {
                    case 0:
                        Current = "A";
                            index++;
                        return true;
                    case 1:
                        Current = "B";
                        index++;
                        return true;
                    case 2:
                        Current = "C";
                        index++;
                        return true;
                    default: return false;
                }
            }

            public void Reset()
            {
                throw new NotSupportedException();
            }
        }
    }
}
