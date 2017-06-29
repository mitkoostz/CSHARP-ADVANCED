using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Directories_and_Files
{
    public class FilesandDirectories

    {
        public static void Main()
        {

            string[] lines = File.ReadAllLines("../../input.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                if(i%2 != 0)
                {
                    File.AppendAllText("../../output.txt", lines[i] + Environment.NewLine);
                }
            }
            

        }
    }
}
