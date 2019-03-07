using System;
using System.Collections;
using System.Collections.Generic;

namespace LabFiveA {
    internal class Program {
        private const int TotalNums = 3;
        
        public static void Main(string[] args) {
            Console.WriteLine("Enter Values For ArrayList Addition");
            Console.WriteLine("Total ArrayList: " + SumArrayList());
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Enter Values For LinkedList Addition");
            Console.WriteLine("Total LinkedList: " + SumLinkedList());
        }

        private static int SumArrayList() {

            var total = 0;
            var operands = new ArrayList();
            
            // Could totally just get the sum within this while loop, but not sure if I would get points taken off for that
            while (total < TotalNums) {

                Console.Write("Value to be added: ");
                operands.Add(int.Parse(Console.ReadLine()));
                total++;
            }

            total = 0;
            foreach (int num in operands) {
                total += num;
            }

            return total;
        }

        private static int SumLinkedList() {
            
            var total = 0;
            var operands = new LinkedList<int>();
            
            while (total < TotalNums) {
                
                Console.Write("Value to be added: ");
                LinkedListNode<int> node = new LinkedListNode<int>(int.Parse(Console.ReadLine()));
                operands.AddLast(node);
                total++;
            }

            total = 0;
            foreach (int num in operands) {
                total += num;
            }
         
            return total;
        }
        
        private static int SumNCLinked() {
            
            var total = 0;
            var operands = new NcLinkedList();
            
            while (total < TotalNums) {
                
                Console.Write("Value to be added: ");
                Node node = new Node(int.Parse(Console.ReadLine()));
                operands.addToEnd(node);
                total++;
            }

            total = 0;
            foreach (int num in operands) {
                total += num;
            }
         
            return total;
        }
    }
}