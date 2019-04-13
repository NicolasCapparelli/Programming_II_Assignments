using System;
using System.Linq;
using System.Threading;
/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Lab#: 7A
 */

namespace LabSevenA {
    internal class Program {
        public static void Main(string[] args) {
            
            // Initialize
            var random = new Random();
            const int maxThreads = 4;
            var randNums = new int[100000];
            var answers = new int[maxThreads];
            
            // Fill array with random numbers
            for (var i = 0; i < randNums.Length; i++) {
                randNums[i] = random.Next(250);
            }
            
            // Variables needed for the threads 
            var threads = new Thread[maxThreads];
            var startIndex = 0; 
            var delta = randNums.Length / maxThreads; // Amount of numbers that will be delegated to each thread
            
            // Creates and fires threads
            for (var i = 0; i < maxThreads; i++) {
                
                // Local variables needed for thread
                var i1 = i;
                var index = startIndex;
                
                // Create new thread to do addition
                threads[i] = new Thread(() => {
                    var nArray = randNums.Skip(index).Take(delta).ToArray();
                    answers[i1] = nArray.Sum();
                });
                
                // Start thread
                threads[i].Start();
                
                // Increase start index by delta
                startIndex += delta;
                
            }

            foreach (var thread in threads) {
                thread.Join();
            }

            Console.WriteLine("Non-Parallel Total: " + randNums.Sum());
            Console.WriteLine("Parallel Total: " + answers.Sum());
        }
    }
}