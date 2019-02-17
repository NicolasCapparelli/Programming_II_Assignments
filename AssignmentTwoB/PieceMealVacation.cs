/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Assignment#: 2
 */

using System.Collections.Generic;
namespace AssignmentTwoB {
    public class PieceMealVacation : Vacation {

        public Dictionary<string, int> costMap = new Dictionary<string, int>() {
            {"hotelCost", 0},
            {"mealCost", 0},
            {"airfareCost", 0}
        };

        public PieceMealVacation() {
        
        }

        public override double CalculateBudgetOffset() {

            double total = 0;
            foreach (var price in costMap.Values) {
                total += price;
            }

            return budget - total;            
        }
    }
}