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
            
            Console.WriteLine("With loop: " +  loopVowels(s));
            
            Console.WriteLine("With recursion: " + RecursiveVowels(s));

            const string p = "racecar";

            Console.WriteLine("Palidrome: " + RecursivePalindrome(p));
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
        

        private static int loopVowels(string word) {
            
            word = word.ToLower();
            
            var totalVowels = 0;
            
            foreach (var c in word) {
                if ("aeiou".Contains(c)) {
                    totalVowels++;
                }
            }

            return totalVowels;
        }

        private static bool RecursivePalindrome(string s){
            s = s.ToLower();

            if (s.Length < 1)
            {
                return true;
            }
            
            if (s[0].Equals(s[s.Length - 1]))
            {
                s = s.Remove(0, 1);

                if (s.Length > 1)
                {
                    s = s.Remove(s.Length - 1);    
                }
                
                return RecursivePalindrome(s);
            }
            
            return false;
            
        }
    }
}
