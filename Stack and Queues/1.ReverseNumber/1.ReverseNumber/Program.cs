using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ReverseNumber
{
   public class ReverseNumbers
    {
        public static void Main()
        {

            var n = Console.ReadLine().Split(new[] { ' ' },
                                             StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>();

            foreach (var number in n)
            {
                numbers.Push(number);
            }

            while (numbers.Count != 0)
            {
                Console.Write(numbers.Pop() + " ");
            }

            Console.WriteLine();
        }
    }
}
