using System;
/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Lab#: 6B
 */

namespace LabSixB {
    public class TimeFormatException : Exception {
        public TimeFormatException(string message)
            : base(message) { }
    }
}