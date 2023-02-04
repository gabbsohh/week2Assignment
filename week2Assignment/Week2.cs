using System;

namespace Week_2
{
    class Week2
    {
        static void Main(string[] args)
        {
            //user input needed for variable
            Console.WriteLine("Enter a variable: ");
            //because it starts as string, needs to be converted to int
            int myVar = Convert.ToInt32(Console.ReadLine());

            //begin equations
            int equa1 = -1 + 4 * myVar;
            int equa2 = (35 + 5) % myVar;
            int equa3 = 14 + -4 * 6 / 12;
            int equa4 = 2 + 12 / 6 * 1 - myVar % 2;

            //display answers
            Console.WriteLine(equa1);
            Console.WriteLine(equa2);
            Console.WriteLine(equa3);
            Console.WriteLine(equa4);

            //If statement
            if (myVar * myVar < 10)
            {
                Console.WriteLine("myVar is less than 4");
            }
            else
            {
                Console.WriteLine("myVar is greater than 4");
            }
        }
    }
}