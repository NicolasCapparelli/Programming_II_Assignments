using System;

namespace LabTwoA {
    public class Student : Person {
        public readonly string classStatus;
        
        public Student(string name, string address, string phoneNumber, string email, string status) : 
            base(name, address, phoneNumber, email) {
            classStatus = status;
        }

        public override void DisplayData() {
            base.DisplayData();
            Console.WriteLine("\tClass Status: " + classStatus);
            Console.WriteLine("\tObject Type: Student");
            Console.WriteLine();
        }
    }
}