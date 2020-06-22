using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.Design;
using System.Xml;

/// <summary>
/// Created By: Gaurav Tayade, 
///             Thanh  Tran,
///             Robin Lansiquot,
///             Bilaal Rashid
/// Description: This console application takes two numbes as input from user
///              and performs opearation on them wanted by user.
/// Inputs: n1 and n2.
/// Output: result gerated fron arithematic operation performed on numbers n1 and n2.
/// </summary>

namespace Calculator
{
    class Calculatorv2
    {

        static void Main(string[] args)
        {
            double n1 = 0;
            double n2 = 0;

            //flag to determine if the program should run or not
            bool isRunning = true;

            while (isRunning) {

                // instantiate an instance object from the result class
                Result result = new Result();

                Console.Write("Enter an Integer: ");
                if (double.TryParse(Console.ReadLine(), out n1)) 
                {
                    Console.Write("Enter a second integer: ");
                    if (double.TryParse(Console.ReadLine(), out n2))
                    {
                        Console.Write("Enter an operator or QUIT (+, -, *, /, %): ");
                        // read user input on operator
                        string op = Console.ReadLine();

                        // call the result instance's setResult method 
                        result.setResult(n1, n2, op);
                        Console.Write($"{n1} {op} {n2} = {result.getResult()}\n");

                    }
                    else
                    {
                        Console.WriteLine("Not a Number! Try Again!");
                    }
                }
                else
                {
                    Console.WriteLine("Not a Number! Try again!");
                }
                
                    
            } // end of while loop

            //terminal will sleep in 9secs
            Thread.Sleep(9000);
            // terminate system
            System.Environment.Exit(0);
        } // end of main
    }   // end of class
}  // end of namespace
