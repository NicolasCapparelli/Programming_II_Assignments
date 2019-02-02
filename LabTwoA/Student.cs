using System;

namespace LabTwoA {
    public class Student : Person {
        
        public enum Status {
            Freshman, Sophomore, Junior, Senior
        }

        public Status classStatus;

        public Student(PersonFactory pFactory) : base(pFactory) {
            classStatus = pFactory.ClassStatusValue ?? Status.Freshman;
        }

        public override void DisplayData() {
            base.DisplayData();
            Console.WriteLine("\tClass Status: " + classStatus);
            Console.WriteLine("\tObject Type: Student");
            Console.WriteLine();
        }
    }
}