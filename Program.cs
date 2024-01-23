using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string name = "Lerato";
            int age;

            //Initialisation

            name = "Lerato";
            age = 15;
            //what will be on the console

            Console.WriteLine(" There was once a girl called " + name);
            Console.WriteLine(name + " was " + age + " of age.");
            Console.WriteLine(name + " really never liked her name.");

            //change variables values
            age = 18;
            name = "Karabo";

            Console.WriteLine("At age " + age + " she changed her name to " + name);

             // to freeze the console
            Console.ReadLine();
        }
    }
}
