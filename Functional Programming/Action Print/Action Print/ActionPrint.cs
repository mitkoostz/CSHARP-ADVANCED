using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Print
{
   public  class ActionPrint

    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> myAction = Print;

            myAction(input);


        }

        public static void Print(string[] massive)
        {

            foreach (var word in massive)
            {
                Console.WriteLine(word);
            }


        }


    }
}
