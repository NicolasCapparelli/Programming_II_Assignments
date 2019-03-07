using System;
/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Assignment#: 4
 */

namespace AssignmentFourB {
    public class Converter {

        private string _answer = "";

        /*
         * Process is as follows:
         * 1.) Take remainder of (d / targetBase) by using modulo (this is the conversion)
         * 2a.) If everything to the left side of the decimal in (d / targetBase) is greater than 0, set that value to 
         * d, append the remainder (conversion) to the answer string and repeat the function with by calling it recursively
         * with d and targetBase
         * 2b.) If the left side of the decimal is less than 0, the conversion is over.
         * Append the remainder (conversion) to the answer string and return that string reversed. 
         */
        public string Convert(decimal d, int targetBase) {

            // Holds conversion of the digit
            var conversion = (int)(d % targetBase);

            // Accounts for symbols after 9, then appends conversion to answer
            if (conversion > 9) {
                _answer += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"[conversion - 10];
            } else {
                _answer += conversion.ToString();    
            }
            
            // Stores everything to the left of the decimal after the division of d / targetBase 
            d = decimal.Truncate(d / targetBase);
            
            
            // Check if conversion is over by checking if everything to the left side of the decimal (d) is 0
            if (d != 0) {
                return Convert(d, targetBase);
            }

            // Copy answer to another variable, clear answer for future use, and return the reverse 
            var final = _answer;
            _answer = "";
            return Reverse(final);
        }
        
        // Reverses a string
        private string Reverse(string s ){
            var charArray = s.ToCharArray();
            Array.Reverse( charArray );
            return new string( charArray );
        }
    }
}