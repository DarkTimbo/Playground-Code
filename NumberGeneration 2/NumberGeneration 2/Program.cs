using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGeneration_2 {
    class Program {
        static Random random = new Random();
        static void Main(string[] args) {

            int[] numbers;

            numbers = GenerateNumbers();
            display(numbers);

            Console.ReadKey();
        }

        public static int [] GenerateNumbers() {

            int[] myArray = new int[45];
            int randomValue = 0;
            
            for (int i = 0; i <45; i++) {
                bool nonDuplicate = true;
                while (nonDuplicate) {
                    randomValue = random.Next(1, 46);
                    nonDuplicate = CheckNoDuplicates(myArray, randomValue);
                    if (!nonDuplicate) {
                        myArray[i] = randomValue;
                    }
                }                
            }
            return myArray;

        }

        static void display(int[] array) {

            Console.WriteLine("The array is: ");
            for (int i = 0; i < array.Length; i++) {
                Console.Write(" " + array[i]);
            }
        }


        public static bool CheckNoDuplicates(int[] arr, int value) {
            
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] == value){
                    return true;
                }
            }
            return false;
        }
    }
}
