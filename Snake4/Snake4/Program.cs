using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Point p1 = new Point(1, 3, '*');
             p1.Draw();

             Point p2 = new Point(4, 5, '#');
             p2.Draw();*/

            int x = 1;
            Func1( x );
            Console.WriteLine( "Call Func1.x = " + x );


            Console.ReadLine();
        }
    }
}
