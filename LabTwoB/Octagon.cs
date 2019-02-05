/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Lab#: 2B
 */
using System;

namespace LabTwoB {

    public class Octagon : GeometricObject, IComparable, ICloneable {
        private readonly int sideLength;

        public Octagon(int sl) {
            sideLength = sl;
        }

        public override double computePerimeter() {
            return sideLength * 8;
        }

        public override double computeArea() {
            return (2 + 4 / Math.Sqrt(2)) * sideLength * sideLength;
        }

        public GeometricObject Clone() {
            return new Octagon(sideLength);
        }

        public bool Compare(GeometricObject obj) {
            return computeArea().Equals(obj.computeArea()) && computePerimeter().Equals(obj.computePerimeter());
        }
    }
}