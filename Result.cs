using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Result
    {
        // field for doubleResult
        private double doubleResult;

        // determines computation depending on operation
        public void setResult(double x, double y, string op)
        {
            if (op == "+")
            {
                doubleResult = x + y;
            }
            else if (op == "-")
            {
                doubleResult = x - y;
            }
            else if (op == "*")
            {
                doubleResult = x * y;
            }
            else if (op == "/")
            {
                // check if two numbers are divisable
                if (y != 0)
                    doubleResult = x / y;
                else
                    Console.Write($"ERROR: {x} and {y} is not divisable! ");

            }
            else if (op == "%")
            {
                // check if two numbers are divisable
                if (y != 0)
                    doubleResult = x % y;
                else
                    Console.Write($"ERROR: {x} and {y} is not divisable! ");
            }
            else if (op.ToUpper() == "QUIT")
            {
                System.Environment.Exit(0);
            }
            else
            {
                // in the case that the user enters something else other than the recommended inputs
                Console.Write("Wrong input! Please try again.");
            }
        }

        // getter for doubleResult
        public double getResult()
        {
            return doubleResult;
        }
    }
}

