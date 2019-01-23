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

            Console.Write("[");
            for (var index = 0; index < data.Length; index++)
            {
                var num = data[index];
                Console.Write(num + " ");
            }

            Console.Write("]\n");
            
            // Part Four
            Console.WriteLine("Longest Positive Streak: " + LongestPositiveStreak(data));

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

        private static int LongestPositiveStreak(int[] streakArray)
        {

            var longestStreak = 0;
            var streak = 0;

            for (var index = 0; index < streakArray.Length; index++)
            {
                var num = streakArray[index];
                if (num > 0) {
                    streak++;
                }
                else
                {
                    if (streak > longestStreak)
                    {
                        longestStreak = streak;
                    }
                    
                    streak = 0;
                }
            }

            if (streak > longestStreak)
            {
                longestStreak = streak;
            }

            return longestStreak;
        }
    }
}