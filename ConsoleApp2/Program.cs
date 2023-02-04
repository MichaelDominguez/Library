using Library;

using static System.Console;
/*
 *  Lab #2 - "Create a Library" completed by Michael Dominguez.
 *  Course:  TECH 4982
 *  Section: 01
 *  Date: 2/2/2023
 */

namespace ConsoleApp2
{
    class Program
    {

        /// <summary>
        ///The main starting function of the program.//
        /// </summary>
        static void Main(string[] args)
        {
            int num = 2;
            //Asking the user for the value of variable b.//
            Console.Write("Enter value 2 or 3 for the number of integers provided: ");
            String sNum = Console.ReadLine();

            //Converting the user input's into integer.//
            num = Int32.Parse(sNum);

            //Declaring all of the 3 variables that would be used.//
            int a;
            int b; 
            int c;

            //ask the user for the value of variable a
            Console.Write("Enter value for a, press enter: ");
            String firstNumber = Console.ReadLine();

            //ask the user for the value of variable b
            Console.Write("Enter value for b and press enter: ");
            String secondNumber = Console.ReadLine();


            //convert the firstNumber,and second number into integer
            a = Int32.Parse(firstNumber);
            b = Int32.Parse(secondNumber);


            if (num == 3)
            {
                //ask the user for the value of variable c
                Console.Write("Enter value for c and press enter ");
                String thirdNumber = Console.ReadLine();

                //Convert thirdNumber value into an integer.//
                c = Int32.Parse(thirdNumber);


                //Do the power calculation.//
                int apowerbpowerc = Power.MyPower(a, b, c);

                //Print the result.//
                Console.WriteLine("Provided Integers {0:G} and {1:G} and {2:G}, the power is {3:G}", a, b, c, apowerbpowerc);
            }
            else
            {
                //Do the power calculation.//
                int apowerb = Power.MyPower(a, b);

                //Print the result.//
                Console.WriteLine("Provided Integers {0:G} and {1:G}, the power is {2:G}", a, b, apowerb);
            }
            Console.ReadLine();

        }
    }
}
