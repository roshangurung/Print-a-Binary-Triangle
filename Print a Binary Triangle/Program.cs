using System;

namespace Print_a_Binary_Triangle///In this C# program, we are reading the number of rows using ‘input’ variable. Binary Triangle is a triangle formed with 1’s and 0’s. Number of rows in the binary triangle is obtained from the user. Nested-if else condition statement is used to check that the value of ‘lastInt’ variable is equal to 1. If the condition is true, then execute the statement print the value as 0.///
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, lastInt = 0, input;
            Console.WriteLine("Enter the Number of Rows : ");
            input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)////Otherwise, if the condition is false, then execute the else if condition statement and check the value of ‘lastInt’ variable is equal to 0. If the condition is true, then execute the statement and print the statement value as 1 and again initialize the value of ‘lastInt’ variable as 1. Print the Binary Triangle from the given number.///
            {
                for (p = 1; p <= i; p++)
                {
                    if (lastInt == 1)
                    {
                        Console.Write("0");
                        lastInt = 0;
                    }
                    else if (lastInt == 0)
                    {
                        Console.Write("1");
                        lastInt = 1;
                    }
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
///Ouptput
///
///Enter the Number of Rows: 5 
///1
///01
///010
///1010
///10101
