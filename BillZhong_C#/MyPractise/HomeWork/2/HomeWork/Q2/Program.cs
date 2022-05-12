using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Enumerable.Range(3, input);
            Enumerable.Repeat('a', input);

            var row_reverse=Enumerable.Range(1, input)
                .Reverse()
                .Select(x=>string.Concat( Enumerable.Repeat(x,input+1-x)));

            //不reverse
            var rows= Enumerable.Range(1,input)
                .Select(x=> string.Concat(Enumerable.Repeat(input+1-x,x)));

            var rows_negative = Enumerable.Range(-input,input)
                .Select(x=> string.Concat(Enumerable.Repeat(-x,input+1-(-x))));
            
            //多載

            var rows_index = Enumerable.Range(1,input)
                .Reverse()
                .Select((x,index)=> string.Concat(Enumerable.Repeat(x,index+1)));


            int NN = 20;
            var row_align = Enumerable.Range(1, NN)
                .Select(x=>string.Concat(Enumerable.Repeat((NN+1-x).ToString().PadLeft(3),x)));

            Console.WriteLine(string.Join(Environment.NewLine,rows));

            Console.ReadLine();
        }
    }
}
