using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int b = 0;

            a = 10;

            b = 20;

            System.Diagnostics.Debug.WriteLine("Original Display :: a: " + a + "b: " + b);

            a = a + b;
            b = a - b;
            a = a - b;


            System.Diagnostics.Debug.WriteLine("New Display :: a: " + a + "b: " + b);




        }
    }
}
