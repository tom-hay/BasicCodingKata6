using System;
using System.Linq;

namespace BasicCodingKata6
{
    class Program
    {
        static void Main(string[] args)
        {
            // user inputs number
            Console.WriteLine("Please choose a number");
            var input = Convert.ToInt32(Console.ReadLine());

            // user decides whether they want sum or product
            var message = string.Format("Would you like to see the sum, or the product of 1 to {0}?", input);
            Console.WriteLine(message);
            Console.WriteLine("Please type sum then press enter, or type product then press enter");
            var sumOrProduct = Console.ReadLine();

            // create a list from a range of 1..input
            var numbers = Enumerable.Range(1, input);

            // sum all items in the list
            var sum = numbers.Sum() + 1;

            // multiply all items in the list
            int product = 1;
            foreach (int number in numbers)
                product *= number;

            // execute the chosen operation
            if (sumOrProduct == "sum")
                Console.WriteLine(sum);
            else
                Console.WriteLine(product);
        }
    }
}
