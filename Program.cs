using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    namespace LongestWord
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                string sentence = "Some line with text";
                int sentLeng = sentence.Length;
                string[] sent = sentence.Split(' ');
                string longWord = "";
                foreach (string word in sent)
                {
                    //For each word in the sentence array
                    //count the characters chars in each word
                    //determine which has the most chars

                    int wordLength = word.Length;
                    int longWordLength = longWord.Length;
                    if (wordLength > longWordLength)
                    {
                        longWordLength = wordLength;
                        longWord = word;
                    }
                }
                Console.WriteLine(longWord);
            }
        }
    }
}