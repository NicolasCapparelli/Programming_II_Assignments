/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Lab#: 5B
 */
namespace LabFiveB {
    public struct ClothingItem {

        public string name { get; }
        public string color { get; }
        public bool isHighTemperatureResistant { get;}

        public ClothingItem(string name, string color, bool isHighTemperatureResistant) {
            this.name = name;
            this.color = color;
            this.isHighTemperatureResistant = isHighTemperatureResistant;
        }
    }
}