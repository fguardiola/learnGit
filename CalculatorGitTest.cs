using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * LAB4 1.
 * 
 * 1.	Write a Calculator class which contains a static method which divides 2 
 * floating point numbers and returns the answer. If the second number is 0 throw 
 * an ArgumentException since division by 0 is undefined. 

Use a test class to call the method. Pass in 2 numbers which have been input by the user.
 * The test class should validate the inputs by using Double.Parse() 
 * to convert the inputs to floating point numbers catching FormatException or 
 * OverflowExceptions if the inputs are invalid. If valid then call the static 
 * method to divide the numbers and display the result. Catch any exceptions 
 * that may arise.--> Estas dos excepciones las lanza solo Double.Parse() 
*/
namespace Calculator
{
    public class CalculatorClass
    {
        public static double Divides2Double(double x,double y) 
        {
            if (y == 0)
                throw new ArgumentException("Dividend y cannot be null", "y");
            return x / y; 
        }
       
    }
}
