/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Assignment#: 3B
 */

using System;
using System.Linq;

namespace LabFourA {
    internal class Program {
        
        public static void Main(string[] args)
        {
            const string s = "The string went over the moon";
            Console.WriteLine("With loop: " +  LoopVowels(s));
            Console.WriteLine("With recursion: " + RecursiveVowels(s));
        }

        private static int RecursiveVowels(string word, int c=0) {
               
            if (word.Length < 1) {
                return c;
            }

            if ("aeiou".Contains(word[0])){
                c++;
            }
            word = word.Remove(0,1);
            return RecursiveVowels(word, c);
        }

        private static int LoopVowels(string word) {
            
            word = word.ToLower();
            
            var totalVowels = 0;
            
            foreach (var c in word) {
                if ("aeiou".Contains(c)) {
                    totalVowels++;
                }
            }

            return totalVowels;
        }

        
    }
}
