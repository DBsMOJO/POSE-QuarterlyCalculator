/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 3.ACIF
 *--------------------------------------------------------------
 *              Daniel Binder, 11.11.2023
 *--------------------------------------------------------------
 * Description:
 * Determination of the quarter using the date of birth
 *--------------------------------------------------------------
*/

using System;

namespace QuarterlyCalculator
{
    class Program
    {
        public static void Main()
        {
            int input,
                output = 0;
            bool check;
            string eva;

            // Head
            Console.WriteLine("************************");
            Console.WriteLine("* Quarterly Calculator *");
            Console.WriteLine("************************");

            // Input
            Console.WriteLine("\nGeben Sie bitte ihr Geburtsmonat in Form einer Zahl ein: ");
            input = Convert.ToInt32(Console.ReadLine());

            // Process
            if (input > 0 && input <= 12)
            {
                check = true;

                if (input <= 3)
                {
                    output = 1;
                }
                else if (input > 3 && input <= 6)
                {
                    output = 2;
                }
                else if (input > 6 && input <= 9)
                {
                    output = 3;
                }
                else
                {
                    output = 4;
                }
            }
            else
            {
                check = false;
            }

            // Output
            if (check)
            {
                Console.WriteLine($"Sie wurden im {output}. Quartal geboren.");
            }
            else
            {
                Console.WriteLine("Sie haben keine Zahl zwischen 1 und 12 eingegeben.");
            }
        }
    }
}
