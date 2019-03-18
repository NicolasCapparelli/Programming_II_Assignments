using System;
/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Assignment#: 5B
 */

namespace AssignmentFiveB {

    public class BirdDataNode {
        public string species;
        public int population;
        public BirdDataNode next;

        public BirdDataNode(string species) {
            this.species = species;
            population = 1;
            next = null;
        }

        public void addToEnd(BirdDataNode newNode) {
            if (next == null) {
                next = newNode;
            } else {
                next.addToEnd(newNode);
            } 
        }

        public void PrintData() {
            Console.WriteLine("Species: " + species + " | count: " + population);
        }
    }

    public class BirdSurvey {
        private BirdDataNode head;

        public BirdSurvey() {
            head = null;
        }

        public void add(string bird) {
            var newNode = new BirdDataNode(bird);
            
            if (head == null) {
                head = newNode;
            } else if (getCount(bird) != 0) { // Usage of getCount() here
                find(bird).population++;
            } else {
                head.addToEnd(newNode);    
            } 
        }

        public int getCount(string bird) {
            var temp = head;
            
            do {
                if (temp.species == bird) {
                    break;
                }

                temp = temp.next;
            } while (temp != null);

            return temp?.population ?? 0;
        }

        private BirdDataNode find(string species) {
            var temp = head;

            do {
                if (temp.species == species) {
                    return temp;
                }
                temp = temp.next;
            } while (temp.next != null);

            return new BirdDataNode("");
        }

        public void getReport() {
            var temp = head;
            while (temp != null) {
                temp.PrintData();
                temp = temp.next;
            }
        }
    }
}