using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWord
{
    public class StartUp
    {
        public static void Main()
        {

            string inputedWord = Console.ReadLine();

           var reversed =  inputedWord.Reverse();

            Console.WriteLine(string.Join("",reversed));
        }
    }
}
