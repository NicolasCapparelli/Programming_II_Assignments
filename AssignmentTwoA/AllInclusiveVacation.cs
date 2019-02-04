/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Assignment#: 2
 */

namespace AssignmentTwoA {
    public class AllInclusiveVacation : Vacation {
        public string Brand { get; set; }
        public int Rating { get; set; }
        public double Price { get; set; }

        public AllInclusiveVacation() {
            
        }

        public override double CalculateBudgetOffset() {
            return  budget - Price;
        }
    }
}