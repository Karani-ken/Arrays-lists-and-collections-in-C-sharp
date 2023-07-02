using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_lists_and_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrays
           /* string[] friends = new string[4] { "John", "james", "Jane", "Joe" };
            friends[0] = "Jack";
            friends[1] = "Julius";
           Console.WriteLine(friends[0])*/
            var names = new List<string> {"Kenneth","Jimmy","Grace","Miriam","Maureen"};
            names.Add("Teddy");
            //names.Remove("Kenneth");
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name}!");               

            }
            //index
            var index = names.IndexOf("Kenneth");
            if(index == -1)
            {
                Console.WriteLine($"when a item is not found IndexOf retuns {index}");
            }
            else
            {
                Console.WriteLine($"the {names[index]} is found at index {index}");
            }

            //fibonaci numbers

            var fibonacciNumbers = new List<int> { 1, 1 };

            Console.WriteLine("Fibonacci numbers");
            while( fibonacciNumbers.Count < 20)
            {

                var previous1 = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous1 + previous2);
            }
            foreach (var number in fibonacciNumbers)
            {
                Console.WriteLine(number);
            }


            Console.ReadLine();
        }
    }
}
