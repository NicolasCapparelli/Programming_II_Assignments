using System;
using System.ComponentModel;
/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Lab#: 5B
 */
namespace LabFiveB {
    internal class Program {
        static Random _rnd = new Random();
        private static readonly string[] Colors = {"red", "blue", "green", "brown", "gray", "pink"};
        
        public static void Main(string[] args) {
            testQueue();
            // testStack();

        }

        private static void testQueue() {
            var queue = new NC_Queue(5);
            
            queue.enqueue(new Food("Potato", 230, 1));
            queue.enqueue(new Food("Watermelon", 120, 3));
            queue.enqueue(new Food("Big Mac", 580, 1));
            queue.enqueue(new Food("Jumbo Wings", 150, 1));
            queue.enqueue(new Food("Grilled Cheese", 150, 1));
            
            Console.WriteLine("Count Before Dequeue: " + queue.count);
            queue.displayQueue();
            
            queue.dequeue();
            Console.WriteLine("Count After Dequeue: " + queue.count);
            queue.displayQueue();

            Console.WriteLine("_________________________________________");
            Console.WriteLine("Peek = " + queue.peek().name);

            Console.WriteLine("Average Calories Per Serving: " + queue.AverageCaloriesPerServing());
            Console.WriteLine("Highest Total Calorie Item: " + queue.HighestTotalCalorie().name);
        }

        private static void testStack() {
            
            var stack = new NC_Stack();

            // Adding elements to stack
            for (var i = 0; i < 5; i++) {
                stack.Push(new ClothingItem("shirt", Colors[_rnd.Next(6)], true));    
            }

            Console.WriteLine("AFTER PUSHES:");
            
            // Display stack after elements are added
            stack.printData();
            
            
            Console.WriteLine("\nAFTER POPS:");
            // Pop three elements
            stack.Pop();
            stack.Pop();
            stack.Pop();

            // Display stack after elements are popped
            stack.printData();

            // Peek item and display it 
            var item = stack.Peek();
            Console.WriteLine("\nItem Peeked: " + item.name + "| " + item.color + "| " + item.isHighTemperatureResistant );

            var redClothes = stack.GetColorClothing("red");
            var highTempClothes = stack.GetHighTempClothing();

            Console.Write("\nRed Clothes: ");

            if (redClothes.Count == 0) {
                Console.Write("NO RED CLOTHES");
            } else {
                foreach (var x in redClothes) {
                    Console.Write(x.name + " " + x.color + " " + x.isHighTemperatureResistant + " | ");
                }                
            }
            
            Console.Write("\n\nHigh Temp Clothes: ");
            foreach (var x in highTempClothes) {
                Console.Write(x.name + " " + x.color + " " + x.isHighTemperatureResistant + " | ");
            }
        }
    }
}