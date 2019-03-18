/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Lab#: 5B
 */
namespace LabFiveB {
    public struct Food {

        public string name { get; }
        public int caloriesPerServing { get; }
        public int numberOfServings { get; }

        public Food(string name, int caloriesPerServing, int numberOfServings) {
            this.name = name;
            this.caloriesPerServing = caloriesPerServing;
            this.numberOfServings = numberOfServings;
        }


    }
}