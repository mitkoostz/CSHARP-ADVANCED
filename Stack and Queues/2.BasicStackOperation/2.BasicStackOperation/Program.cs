using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BasicStackOperation
{
    public class Program
    {
        public static void Main()
        {

            Stack<int> stack = new Stack<int>();

            var firstInput = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var n = firstInput[0];
            var s = firstInput[1];
            var x = firstInput[2];

            int[] numbersToPush = new int[n];
         

              
              numbersToPush = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            foreach (var number in numbersToPush)
            {
                stack.Push(number);
            }

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }

        }
    }
}
