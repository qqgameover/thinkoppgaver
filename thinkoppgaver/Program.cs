using System;
using System.Collections.Generic;
using System.Linq;

namespace thinkoppgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            //MakeFirst();
            //MakeSecond();
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            MakeThird();
            Console.WriteLine();
            GetSentenceInfo(vowels);
        }

        private static void GetSentenceInfo(HashSet<char> vowels)
        {
            string text = Console.ReadLine().ToLower();
            int totalVowels = text.Count(vowels.Contains);
            string[] split = text.Split(" ");
            string longest = split.OrderByDescending(word => word.Length).First();
            Console.WriteLine(
                $"Total number of words: {split.Length}, the longest word is: {longest} and is {longest.Length} letters long. There are {totalVowels} vowels in this text.");
        }

        /*
         * ########
            ######
             ####
              ##

         #            #
          ##        ##
           ###    ###
            ########
            ########
           ###    ###
          ##        ##
         #            # 
         */
        static void MakeHash()
        {
            Console.Write("#");
        }

        static void MakeSpace()
        {
            Console.Write(" ");
        }

        static void MakeFirst()
        {

            MakeNewLine(0, 8, false);
            MakeNewLine(1, 6);
            MakeNewLine(2, 4);
            MakeNewLine(3, 2);
        }

        static void MakeSecond()
        {
            MakeNewLine(3, 2);
            MakeNewLine(2, 4);
            MakeNewLine(1, 6);
            MakeNewLine(0, 8);
            MakeNewLine(0, 8);
            MakeNewLine(1, 6);
            MakeNewLine(2, 4);
            MakeNewLine(3, 2);
        }

        static void MakeThird()
        {
            MakeNewInvertedLine(12, 2);
            MakeNewLine(1, 0);
            MakeNewInvertedLine(8, 4, false);
            MakeNewLine(2, 0);
            MakeNewInvertedLine(4, 6, false);
            MakeNewLine(3, 8);
            MakeNewLine(3, 8);
            MakeNewLine(2, 0);
            MakeNewInvertedLine(4, 6, false);
            MakeNewLine(1, 0);
            MakeNewInvertedLine(8, 4, false);
            MakeNewInvertedLine(12, 2);
        }

        static void MakeNewLine(int spaces, int hashes, bool newLine = true)
        {
            if(newLine) Console.Write("\n");
            for (int i = 0; i < spaces; i++)
            {
                MakeSpace();
            }
            for (int i = 0; i < hashes; i++)
            {
                MakeHash();
            }
        }

        static void MakeNewInvertedLine(int spaces, int hashes, bool newLine = true)
        {
            if(newLine) Console.Write("\n");
            for (var i = 0; i < hashes / 2; i++)
            {
                MakeHash();
            }

            for (int i = 0; i < spaces; i++)
            {
                MakeSpace();
            }

            for (int i = 0; i < hashes / 2; i++)
            {
                MakeHash();
            }
        }
    }
}
