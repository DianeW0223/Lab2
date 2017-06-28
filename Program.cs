using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Odd and Even Number Idenitifier");
            string Input2 = "y";

            while (Input2 == "y")
                
            
            {
                int Input1 = 0;
                Console.WriteLine("Please enter a number between 1 and 100");
                Input1 = int.Parse(Console.ReadLine());
                
                
                if (((Input1 <= 25) && (Input1 > 0) && (Input1 % 2 == 0)))
                {
                    Console.WriteLine(Input1 + " is even and less than 25");
                }
                else if ((Input1 >=26) && (Input1 % 2 == 0))
                {
                    Console.WriteLine(Input1 + " is even");
                }
                else if (Input1 <= 0)
                {
                    Console.WriteLine("Negative numbers are not accepted");
                }
                else
                {
                    Console.WriteLine(Input1 + " is odd");
                }
                Console.WriteLine("Do you want to Continue? y/n");
                Input2 = Console.ReadLine();

            } 
            
        }

    }
}
