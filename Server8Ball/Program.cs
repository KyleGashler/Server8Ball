using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("=====================");

            SynchronousSocketListener synchronous = new SynchronousSocketListener();
            synchronous.Startlistening();

            Console.WriteLine("");

        }
    }
}
