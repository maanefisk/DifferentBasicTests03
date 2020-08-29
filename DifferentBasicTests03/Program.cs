using System;

namespace DifferentBasicTests03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test19 Compute the sum of two integers, if two values are equal :return the triple.
            Console.Write("\nInsert Digit: ");
            int digitOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInsert Digit: ");
            int digitTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nYour sum is: " + compareDigits(digitOne,digitTwo) + " ( x3 if alike )");
        }

        public static int compareDigits(int dOne, int dTwo)
        {
            int sum = dOne + dTwo;
            if (dOne == dTwo) return sum + (sum / 2);
            else
            {
                return sum;
            }
        }
    }
}
