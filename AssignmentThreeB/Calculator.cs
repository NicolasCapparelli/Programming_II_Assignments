using System;
using System.Collections.Generic;

/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Assignment#: 3B
 */


namespace AssignmentThreeB {

    public class Calculator {

        // Stores entire operation 
        private readonly List<string> _values = new List<string>();

        public void Load(string value) {
            _values.Add(value);
        }

        public void Clear() {
            _values.Clear();
        }

        // Recursive method | Adheres to MDAS | Returns value of operation stored in _values
        public double Calculate() {
                        
            // Check if there are operations left to complete
            if (_values.Contains("*")) {
                
                // The index of the operator
                var mainIndex = _values.IndexOf("*");
                
                // Replace the operator symbol with the product of the two operands
                _values[mainIndex] = (double.Parse(_values[mainIndex - 1]) * double.Parse(_values[mainIndex + 1])).ToString();
                
                // Remove the operands 
                _values.RemoveAt(mainIndex - 1);
                _values.RemoveAt(mainIndex);
                
                // Call this method again to check if there are any operations left
                Calculate();

            } else if (_values.Contains("/")) {
                var mainIndex = _values.IndexOf("/");
                _values[mainIndex] = (double.Parse(_values[mainIndex - 1]) / double.Parse(_values[mainIndex + 1])).ToString();
                _values.RemoveAt(mainIndex - 1);
                _values.RemoveAt(mainIndex);
                Calculate();
                
            } else if(_values.Contains("+")) {
                var mainIndex = _values.IndexOf("+");
                _values[mainIndex] = (double.Parse(_values[mainIndex - 1]) + double.Parse(_values[mainIndex + 1])).ToString();
                _values.RemoveAt(mainIndex - 1);
                _values.RemoveAt(mainIndex);
                Calculate();
                
            } else if (_values.Contains("-")) {
                var mainIndex = _values.IndexOf("-");
                _values[mainIndex] = (double.Parse(_values[mainIndex - 1]) - double.Parse(_values[mainIndex + 1])).ToString();
                _values.RemoveAt(mainIndex - 1);
                _values.RemoveAt(mainIndex);
                Calculate();
            }
            
            // Once all operations are complete, the only value left is the answer
            return double.Parse(_values[0]);
        }

    }
}