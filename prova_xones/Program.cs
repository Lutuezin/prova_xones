using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_xones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h, p, div;
            h = double.Parse(Console.ReadLine());
            p = double.Parse(Console.ReadLine());
            div = h / p;
            Console.WriteLine(div) ;
            Console.ReadKey();
            

        }
    }
}
