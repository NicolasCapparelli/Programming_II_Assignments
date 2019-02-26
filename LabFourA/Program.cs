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
        
        public static void Main(string[] args) {
            Console.WriteLine(cVowels("The string went over the moon"));
        }

        private static int recursiveVowels(string word) {
               
            if (!(word.Length > 0)) {
                return 0;
            }

            if ("aeiou".Contains(word[0])) {
                recursiveVowels("");
            }
            
            
            return 0;
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
        
        public static bool isVowel (char ch) {
            if (ch=='a' || 
                ch=='e' ||
                ch=='i' ||
                ch=='o' ||
                ch=='u') 
            {
                return true;
            } else{
                return false;
            }
        }
        
        public static int cVowels (string s) {
            
            if (s.Length == 0) {
                return 0;
            } else {
                int counter = cVowels(s.Substring(1));
                if (isVowel(s[0])) {
                    return 1+counter;
                } else 
                    return counter;
            }
        }
    }
}
