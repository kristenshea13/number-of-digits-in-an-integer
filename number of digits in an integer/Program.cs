using System;

namespace number_of_digits_in_an_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that will return the number of digits in an integer.
            Console.WriteLine("How many digits in a value?");
            Console.Write("Enter number: ");

            //convert number entered from string to int and declare it as a variable
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("The number of digits in value: {0}", Digits(number));

            Console.ReadLine();

        }

        /// <summary>
        /// return the number of digits in the user-entered integer from above
        /// </summary>
        /// <param name="number"></param>
        /// <returns>number of digits</returns>
        private static int Digits(int number)
        {
            return number.ToString().Length;
        }




    }
}
