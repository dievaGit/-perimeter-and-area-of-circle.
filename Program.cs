using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            float r = 0f; 
            double p = 0, a = 0;

            //Requesting data from the user
            Console.Write(" Write the radius of the circle");
            r = Convert.ToSingle(Console.ReadLine());

            //Calculated perimeter and surface;
            p = 2 * Math.PI * r;
            a = Math.PI * r * r;

            //Showing results
            Console.WriteLine(" The perimeter of the circle is {0}", p);
            //Showing results
            Console.WriteLine(" The surface of the circle is {0}", a);

            Console.ReadKey();

        }
    }
}
