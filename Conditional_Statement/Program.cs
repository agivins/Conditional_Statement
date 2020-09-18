/*ISM 4300 Console Program- Submitted by Alexandra Givins
 Comments: This code demonstrates the use of Conditional statements after getting input from users. 
*/
using System;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input 
            Console.WriteLine("What grade you expert to get in ISM 4300 ?..");
            /*
              Use the cath block to validate user input. 
            */
            try
            {
                // This variable will gather the user input 
                string input = Console.ReadLine();
                /*
                   This variable will be used to store sales 
                after the input 
                */
                decimal grade = decimal.Parse(input);
                // this variable will be used to calculate the bonus 

                decimal GPA = 0;
                // This variable will be used to get the number of years user has been in sales
                int grade_in_book = 0;
                /* 
                    This If/ELSE if ELSE statement
                */
                if (GPA < 200)
                {

                    GPA += 1.0m * grade;
                    Console.WriteLine("Calculating:" + String.Format("{0:}  ", grade) + "Your GPA in this class is: " + String.Format("{0:}", GPA));

                    Console.WriteLine(" Please type in the first digit...");
                    //Assign the number of years the user has input to the years_in_sales variable
                    grade_in_book = int.Parse(Console.ReadLine());
                    /* Excuse the conditional switch statement to output different messages
                     depending on integar value entered for years in sales 
                    */
                    switch (grade_in_book)
                    {
                        case (0):
                            Console.WriteLine("F");
                            Console.WriteLine("Press any key to exit the program...");
                            // Pause the program and wait for the user to press a key to end the program
                            Console.ReadKey(true);
                            break;

                        case (1):
                            Console.WriteLine("D");
                            Console.WriteLine("Press any key to exit the program...");
                            // Pause the program and wait for the user to press a key to end the program
                            Console.ReadKey(true);
                            break;

                        case (2):
                            Console.WriteLine("C");
                            Console.WriteLine("Press any key to exit the program...");
                            // Pause the program and wait for the user to press a key to end the program
                            Console.ReadKey(true);
                            break;

                        case (3):
                            Console.WriteLine("B");
                            Console.WriteLine("Press any key to exit the program...");
                            // Pause the program and wait for the user to press a key to end the program
                            Console.ReadKey(true);
                            break;

                        case (4):
                            Console.WriteLine("A");
                            Console.WriteLine("Press any key to exit the program...");
                            // Pause the program and wait for the user to press a key to end the program
                            Console.ReadKey(true);
                            break;


                    } // end of switch
                }
            }// end of try 
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }// End of catch 
        }// End of Main 
    }// End of Class 
}// End of namesplace 









