using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_to_F {

    class Program {

        static void Main(string[] args) {

            double Celsius, Fahrenheit;

            Console.Write("Please input temperature in fahrenheit: ");
            Fahrenheit = double.Parse(Console.ReadLine());

            Celsius = 5.0 / 9.0 * (Fahrenheit - 32);

            Console.WriteLine("The current temperature in celsius is {0}.", Celsius);
            Console.WriteLine("\nPress any key to escape.");
            Console.ReadKey();
            
            

            }

        }
    }

