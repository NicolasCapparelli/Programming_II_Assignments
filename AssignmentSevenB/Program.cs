using System;
using System.Linq;
using System.Threading;
/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Assignment#: 7B
 */

namespace AssignmentSevenB {
    internal class Program {
        public static void Main(string[] args) {

            // Vars
            var random = new Random();
            var mainArray = new int[10000];
            
            // Initializing mainArray with random values
            for (var i = 0; i < mainArray.Length; i++) {
                mainArray[i] = random.Next(250);
            }
            
            // Sequential
            var watch = System.Diagnostics.Stopwatch.StartNew();
            SortSequential(mainArray);
            Console.WriteLine("Sequential time: " + watch.ElapsedMilliseconds + " milliseconds");
            
            // Parallel
            watch = System.Diagnostics.Stopwatch.StartNew();
            SortParallel(mainArray);
            Console.WriteLine("Parallel time: " + watch.ElapsedMilliseconds + " milliseconds");
            
        }

        // Sorts array sequentially using BUBBLE SORT
        private static int[] SortSequential(int[] arr) {            
            // Copying array
            var sortMe = new int[arr.Length];

            // Bubble sort
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (var p = 0; p <= sortMe.Length - 2; p++) {
                for (var i = 0; i <= sortMe.Length - 2; i++) {
                    if (sortMe[i] > sortMe[i + 1]) {
                        var temp = sortMe[i + 1];
                        sortMe[i + 1] = sortMe[i];
                        sortMe[i] = temp;
                    }
                }
            }
            
            return sortMe;
        }

        // Sorts area in parallel by using multiple threads running BUBBLE SORT
        private static int[] SortParallel(int[] arr) {
            const int maxThreads = 4;

            // Holds threads
            var threads = new Thread[maxThreads];
            var sorted = new int[maxThreads][];
            
            // Copy array
            var sortMe = new int[arr.Length];
            Array.Copy(arr, sortMe, arr.Length);

            // Fires threads
            var startIndex = 0; 
            var delta = sortMe.Length / maxThreads; // Amount of numbers that will be delegated to each thread
            for (var i = 0; i < maxThreads; i++) {
                
                var i1 = i;
                
                // Creating new thread
                var index = startIndex;
                threads[i] = new Thread(() => {
                    var nArray = sortMe.Skip(index).Take(delta).ToArray();
                    sorted[i1] = SortSequential(nArray);
                });
                
                // Fire thread
                threads[i].Start();
                
                // Increase start index by delta
                startIndex += delta;
            }
            
            foreach (var thread in threads) {
                thread.Join();
            }
            

            var result = sorted[0];
            for (var i = 1; i < sorted.Length; i++) {
                result = result.Concat(sorted[i]).ToArray();
            }

            return result;
        }
        
    }
}