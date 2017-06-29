using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    public class Program
    {
        public static void Main()
        {

            string[] words = File.ReadAllText("../../Words.txt").Split(' ');
            string[] textLines = File.ReadAllLines("../../Text.txt");

            Dictionary<string, int> result = new Dictionary<string, int>();
            List<string> allWords = new List<string>();


            for (int i = 0; i < textLines.Length; i++)
            {
                string[] wordsInLine = textLines[i].Split(' ');

                for (int a = 0; a < wordsInLine.Length; a++)
                {
                    allWords.Add(wordsInLine[a]);
                }
            }


            string[] allWordsMas = allWords.ToArray();

            for (int c = 0; c < allWordsMas.Length; c++)
            {
                for (int b = 0; b < words.Length; b++)
                {
                    if (allWordsMas[c].Contains(words[b]))
                    {
                        if (!result.ContainsKey(words[b]))
                        {
                            result.Add(words[b], 1);
                        }else
                            result[words[b]] += 1;
                    }
                }

            }


            //result = result.OrderByDescending(x => x.Key).ToDictionary(x => x.Key , y => y.Value);

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }


        }
    }
}
