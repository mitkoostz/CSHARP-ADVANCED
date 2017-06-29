using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets_of_Elements
{
    public class SetsOfElements
    {
       public  static void Main()
        {

            var input = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();


            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                firstSet.Add(currentNumber);
            }

            for (int a = 0; a < m; a++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                secondSet.Add(currentNumber);
            }


           firstSet.IntersectWith(secondSet);

            foreach (var number in firstSet)
            {
                Console.Write(number + " ");
            }

        }
    }
}
