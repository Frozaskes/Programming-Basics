using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you name:" );
             string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);

            if (name == "SoftUni")
            {
                Console.WriteLine("Soft Uni University");
            }
            else
            {
                
            }
        }
    }
}
