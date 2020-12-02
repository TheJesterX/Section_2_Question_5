// Jacobus Rothmann

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0,num2 = 1,result = 0;
            int end = 4000000;
            // Adding each step of the Fibonacci sequence
            // result  <= end stops the for loop when the result is still smaller the the end number 
            for (int i = 0; result <= end; i++)
            {           
                // Adding the number to each other to 
                result = num1 + num2;
                if (result < end)
                {
                    // Steps of the Fibonacci Sequence
                    num1 = num2;
                    num2 = result;
                }
                else
                {
                    // Ensures the the result ends under the end value 
                    result = result - num1;
                    break;
                }                            
            }            
            Console.WriteLine("The sum value of the Fibonacci sequence below then 4000000 is :" + result);
            Console.ReadKey();
        }
    }
}
