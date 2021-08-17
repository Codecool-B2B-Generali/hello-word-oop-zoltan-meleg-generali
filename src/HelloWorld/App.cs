using System;
using System.Collections.Generic;
using System.Text;

namespace Codecool.HelloWorld
{
    class App
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                HelloWorld helloWorld = new HelloWorld();
                helloWorld.Welcome(args[0]);
            } else
            {
                Console.WriteLine("hasznalat: HelloWorld <nevargument>");
            }
        }
    }
}
