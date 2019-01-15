using System;

namespace LabOneA {
    internal class Program {
        public static void Main(string[] args) {

            int duration;
            int frequency;

            do {
                
                Console.WriteLine("Enter Frequency (37 to 32767):");
                frequency = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Enter Duration:");
                duration = Convert.ToInt32(Console.ReadLine());
                
            } while (frequency < 38 || frequency > 32767);           
            Console.Beep(frequency, duration);
        }
    }
}