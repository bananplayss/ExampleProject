using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args[0] == "-help")
            {
                Console.WriteLine("This is the first real github project I've written with C# bruv");
            }
            else
            {
                Console.WriteLine("Hello Vietnam");
            }
        }
    }
}
