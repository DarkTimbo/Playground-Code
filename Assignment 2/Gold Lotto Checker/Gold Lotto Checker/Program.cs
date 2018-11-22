using System;

namespace Gold_Lotto_Checker {

    /// <summary>
    /// 
    /// An auto completing lotto number checker that matches how many
    /// normal numbers and supplimertary numbers are found in each game.
    /// This is then outputed for the user to see.
    /// 
    /// Author Tim Gaskell n9717676 April 2017
    /// 
    /// 
    /// </summary>

    class Program {

        static void Main() {

            int[,] lottoNumbers ={
                                  { 4, 7, 19, 23, 28, 36},
                                  {14, 18, 26, 34, 38, 45},
                                  { 8, 10,11, 19, 28, 30},
                                  {15, 17, 19, 24, 43, 44},
                                  {10, 27, 29, 30, 32, 41},
                                  { 9, 13, 26, 32, 37,  43},
                                  { 1, 3, 25, 27, 35, 41},
                                  { 7, 9, 17, 26, 28, 44},
                                  {17, 18, 20, 28, 33, 38}
                              };

            int[] drawNumbers =  {44, 9, 17, 43, 26, 7, 28, 19};

            int[] matches, supMatches;

            Welcome();

            displayNumbers(lottoNumbers, drawNumbers);

            matches = Checker(lottoNumbers, drawNumbers);

            supMatches = SupChecker(lottoNumbers, drawNumbers);

            DisplayOutcome(matches, supMatches);

            ExitProgram();

        }//end Main


        /// <summary>
        /// Displays a welcome message for the user upon start up.
        /// </summary>
        static void Welcome() {
            Console.WriteLine("\n\tWelcome to Lotto Checker");

        }// end welcome


        /// <summary>
        /// Displays the previously defined picked numbers and new draw numbers
        /// in the window.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="games"></param>
        /// <param name="draw"></param>
        static void displayNumbers(int[,] array, int[] draw) {

            int rowSize = 9, columnSize = 6, lottoSize = 8;

            for (int row = 0; row < rowSize; row++) {
                Console.Write("\nGame {0}:", (row +1));
                for (int column = 0; column < columnSize; column++) {
                    Console.Write("  " + array[0 + row, column]);                    
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nLotto Draw Numbers Are: ");
            for (int collumn = 0; collumn < lottoSize; collumn++) {
                Console.Write(" " + draw[collumn]);
            }

        }//end displayNumbers


        /// <summary>
        /// Looks through the picked numbers row by row, checking them 
        /// against the first 6 numbers of the draw numbers. If there is match
        /// it counts how many matches there are and saves that number to an array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="draw"></param>
        /// <returns> an array which contians the matches of every game </returns>
        static int[] Checker(int[,] array, int[] draw) {

            int[] matches = new int[9];
            int rowSize = 9, columnSize = 6, lottoSize = 6;

            for (int row = 0; row < rowSize; row++) {
                for (int column = 0; column < columnSize; column++) {
                    for (int lotto = 0; lotto < lottoSize; lotto++) {

                        if (array[row, column] == draw[lotto]) {
                            matches[row] += 1;
                        }
                    }
                }
            }
            return matches;

        }//end Checker


        /// <summary>
        /// Looks through the picked numbers row by row, checking them 
        /// against the last 2 numbers of the draw numbers. If there is match
        /// it counts how many matches there are and saves that number to an array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="draw"></param>
        /// <returns> an array which contians the matches of every game </returns>
        static int[] SupChecker(int[,] array, int[] draw) {

            int[] supMatches = new int[9];
            int rowSize = 9, columnSize = 6, lottoSize = 8;

            for (int row = 0; row < rowSize; row++) {
                for (int column = 0; column < columnSize; column++) {
                    for (int lotto = 6; lotto < lottoSize; lotto++) {

                        if (array[row, column] == draw[lotto]) {
                            supMatches[row] += 1;
                        }
                    }
                }
            }
            return supMatches;

        }//end SupChecker


        /// <summary>
        /// Displays the outcome of every game, showing the matches and
        /// suplimentary matches that were found.
        /// </summary>
        /// <param name="matches"></param>
        /// <param name="supMatches"></param>
        /// <param name="game"></param>
        static void DisplayOutcome(int[] matches, int[] supMatches) {

            int numberOfGames = 9;

            for (int line = 0; line < numberOfGames; line++) {
                Console.WriteLine("\n\n\tfound {0} winning numbers and {1} supplememtary numbers in game {2}", matches[line], supMatches[line], (line+1));
            }

        }//end DisplayOutcome


        /// <summary>
        /// Promts the user to exit gracefully
        /// </summary>
        static void ExitProgram() {
            Console.WriteLine("\n\n\n\tThanks for using Lotto Checker");
            Console.Write("\n\nPress any key to exit program: ");
            Console.ReadKey();

        }//end ExitProgram


    }//end class
}//end namespace
