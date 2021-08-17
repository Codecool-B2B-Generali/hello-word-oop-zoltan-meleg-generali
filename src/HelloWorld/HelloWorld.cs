using System;

namespace Codecool.HelloWorld
{
    public class HelloWorld
    {
        public void Welcome(string name) {
            string invocation = name ?? "World";

            System.Console.WriteLine($"Hello {invocation}!");
        }
    }
}
