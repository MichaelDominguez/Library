using static System.Console;
/*
 *  Lab #2 - "Create a Library" completed by Michael Dominguez.
 *  Course:  TECH 4982
 *  Section: 01
 *  Date: 2/2/2023
 */

namespace Library
{
    public class Power
    {
        //// <summary>
        ///The power method to check the power calculations of all 3 integer parameters.//
        /// </summary>
        public static int MyPower(int a, int b, int c)
        {
            //A power calculation between a and b.//
            int apowerb = (int)Math.Pow(a, b);

            //A power calculation between apowerb and c.//
            int apowerbpowerc = (int)Math.Pow(apowerb, c);

            //Returning the apowerbpowerc variable as the result.//
            return apowerbpowerc;
        }


        //// <summary>
        /// A power method to check the power calculations of the 2 integer parameters.//
        /// </summary>
        public static int MyPower(int a, int b)
        {
            //do a power calculation between a and b
            int apowerb = (int)Math.Pow(a, b);


            //return the apowerb variable as the result
            return apowerb;
        }
    }
}
