using System;

namespace LabFourB
{
    internal class Program
    {
        public static void Main(string[] args){
            const string p = "racecar";
            Console.WriteLine("Palindrome: " + RecursivePalindrome(p));
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