using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorLabs
{
    public class Operators
    {

        public double BODMAS(double inputNumber)
        {

            /*
             * Operator Labs
             * 
             *  1. BODMAS
             * 
             *  Write a method which takes a double as an input, 
             *  squares it, adds 101, divides by 10 then subtracts 4.  
             *  Return a double rounded to 3 decimal places.
             *  
             */

            double result = ((Math.Pow(inputNumber, 2) + 101) / 10) -4;

            
        
            return Math.Round(result, 3);

        }

        public double Modulus(int inputNumber)
        {
            /*
             *  2. Modulus
             *  
             *  Write a method which returns the remainder of any integer divided by 8.
             * 
             */

            return inputNumber % 8;
        }

        public bool XOR(bool inputOne, bool inputTwo)
        {
            /*
             *  3. XOR
             * 
             *  Create a truth table that returns the XOR of two inputs.
             *
             */

            return (inputOne ^ inputTwo);
        }
    }
}
