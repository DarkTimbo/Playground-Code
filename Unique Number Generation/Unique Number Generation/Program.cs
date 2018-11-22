using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_Number_Generation {
    class Program {
        static Random randomValue = new Random();

        static void Main(string[] args) {

            int length;
            int[] Numbers;

            length = Welcome();
            Numbers = InitializeArrayWithNoDuplicates(length);
            Display(Numbers);
            Exit();



        }


        static int Welcome() {

            int length;

            Console.WriteLine("Hi there, welcome to the random number generator.");
            Console.WriteLine("\nHow many random numbers would you like to print out?");

            length = int.Parse(Console.ReadLine());
            return length;

        }




        /// <summary>
        /// Creates an array with each element a unique integer
        /// between 1 and 45 inclusively.
        /// </summary>
        /// <param name="size"> length of the returned array < 45
        /// </param>
        /// <returns>an array of length "size" and each element is
        /// a unique integer between 1 and 45 inclusive </returns>
        static int[] InitializeArrayWithNoDuplicates(int size) {

            int[] Numbers = new int[size];
            int number, i = 0;

            do {

                number = randomValue.Next(1, 46);


                if (!Numbers.Contains(number)) {
                    Numbers[i] = number;
                    i++;

                }

            } while (i < size );

            return Numbers;

        }

        static void Display(int[] array) {

            Console.WriteLine("The array is: ");
            for(int i = 0; i < array.Length; i++) {
                Console.Write(" "+array[i]);
            }
        }




        static void Exit() {

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }



    }
}
