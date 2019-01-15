using System;
using System.Linq;

namespace LabOneB {
    internal class Program {
        public static void Main(string[] args) {
            
            // Part one
            int[] nums = {1, 4, 13, 43, -25, 17, 22, -37, 29};
            var largestNum = FindLargest(nums);
            Console.WriteLine("Largest value in nums: " + largestNum);
            
            // Part two
            var data = new int[20];
            FillArray(data);
            var largestData = FindLargest(data);
            Console.WriteLine("Largest value in data: " + largestData);
            
            // Part Three
            Console.WriteLine("Sum of largest: " + (largestNum + largestData));
            Console.WriteLine("[{0}]", string.Join(", ", data));
            
            // Part Four
            Console.WriteLine(LongestPositiveStreak(new []{4,5,0,2,-1,88,78,66,-6}));

        }

        private static int FindLargest(int[] searchMe) {
            return searchMe.Max();
        }

        private static int[] FillArray(int[] fillMe) {
            var random = new Random();
            
            for (var i = 0; i < fillMe.Length; i++) {
                fillMe[i] = random.Next(-100, 100);
            }

            return fillMe;
        }

        private static int LongestPositiveStreak(int[] streakArray) {

            var longestStreak = 0;
            var streak = 0;

            foreach (var num in streakArray) {
                if (num > 0) {
                    streak++;
                }
                else {
                    longestStreak = streak;
                    streak = 0;
                }
            }

            return streak > longestStreak ? streak : longestStreak;
        }
    }
}