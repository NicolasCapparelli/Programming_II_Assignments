using System;

namespace LabTwoA {
    public class Student : Person {
        
        public enum Status {
            Freshman, Sophomore, Junior, Senior
        }
        
        private readonly Status _classStatus;
        
        public Student(string name, string address, string phoneNumber, string email, Status status) : 
            base(name, address, phoneNumber, email) {
            _classStatus = status;
        }

        public override void DisplayData() {
            base.DisplayData();
            Console.WriteLine("\tClass Status: " + _classStatus);
            Console.WriteLine("\tObject Type: Student");
            Console.WriteLine();
        }
    }
}