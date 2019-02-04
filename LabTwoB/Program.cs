using System;

namespace LabTwoB {
    internal class Program {
        public static void Main(string[] args) {
            
            var octagon = new Octagon(8);
            Console.WriteLine("Area of Octagon: " + octagon.computeArea().ToString("0.00"));
            Console.WriteLine("Perimeter of Octagon: " + octagon.computePerimeter().ToString("0.00"));

            var newObj = octagon.Clone();
            Console.WriteLine("The objects are equal?: " + octagon.Compare(newObj));
        }
    }
}