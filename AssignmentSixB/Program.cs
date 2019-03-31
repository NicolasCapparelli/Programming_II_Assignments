using System;
using System.Collections.Generic;
using System.IO;

namespace AssignmentSixB {
    internal class Program {
        
        
        public static void Main(string[] args) {
            var CWD = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();   
            bool fileExists;
            string originalFile;
            string copyToFile;
            
            do {
                Console.WriteLine("Please enter the name of the original file:");
                originalFile = CWD + "\\" + Console.ReadLine();
                fileExists = File.Exists(originalFile);
                
                if (!fileExists) {
                    Console.WriteLine("WARNING: This file does not exist. Please enter a different file name or abort the program by pressing CTRL+C");    
                }

            } while (!fileExists);

            do {
                
                Console.WriteLine("Please enter the name of the file you'd like to copy to: ");
                copyToFile = CWD + "\\" + Console.ReadLine();
                fileExists = File.Exists(copyToFile);
                
                if (fileExists) {
                    Console.WriteLine("WARNING: The filename already exists. Would you like to overwrite the existing file? y/n");
                    if (Console.ReadKey().Key == ConsoleKey.Y) {
                        Console.WriteLine();
                        break;
                    }
                }
                
            } while (fileExists);
            
            
            // Read original file
            var text = File.ReadAllText(originalFile);

            Console.WriteLine(copyToFile);
            // Create cloned file
            using (var sw = new StreamWriter(copyToFile)) {
                    
                // Split text into lines
                var list = new List<string>(text.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
                    
                // Write each line in file
                foreach (var line in list) {
                    sw.WriteLine(line);
                }
            }
        }
    }
}