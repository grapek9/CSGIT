using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String input; int digit=0; //declaration of variables 
            Console.WriteLine("Welcome To Factorial Program");
            Console.WriteLine("Enter Digit");
            input= Console.ReadLine(); // read from input
            Console.Clear();
            Int32.TryParse(input, out digit); //parse from string to int
            Console.WriteLine("The Result of Factorial for "+digit +" is:"); // show the results
            Console.WriteLine("Recursion :"+recursive(digit));
            Console.WriteLine("Iteration :" + iteration(digit));
            Console.ReadKey(); // wait for user interaction to end program

        }
        static int recursive(int digit) // recursive version of function
        {
            
            if (digit == 0) return 1;
            
            return recursive(digit - 1) * digit;
        }
        static int iteration(int digit) //iterational version of factorial
        {
            int result=1;
            for (int i = 1; i <= digit; i++)
            {
                result *= i;
            }
                return result;
        }

    }
}
