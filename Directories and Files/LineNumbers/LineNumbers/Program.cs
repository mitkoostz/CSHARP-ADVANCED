using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        public static void Main()
        {

            string[] lines = File.ReadAllLines("../../input.txt");

            int id = 1;
            
            for (int i = 0; i < lines.Length; i++)
            {
                string counter = id.ToString();

                lines[i] = counter + ". " + lines[i];

                id++;

            }


            File.AppendAllLines("../../output.txt", lines);


        }
    }
}
