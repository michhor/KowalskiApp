using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KowalskiApp.StdLibrary.Models;

namespace KowalskiApp.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello world from console!");
            Person person = new Person()
            {
                FirstName = "Jan",SecondName = "Kowalski"
            };
            System.Console.WriteLine(person.ToString());
        }
    }
}
