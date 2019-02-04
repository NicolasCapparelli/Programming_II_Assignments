using System;

namespace LabTwoA {
    public class Student : Person {
        
        public enum Status {
            Freshman, Sophomore, Junior, Senior
        }

        private Status _classStatus;

        public Student(PersonFactory pFactory) : base(pFactory) {
            _classStatus = pFactory.ClassStatusValue ?? Status.Freshman;
        }

        public override void DisplayData() {
            base.DisplayData();
            Console.WriteLine("\tClass Status: " + _classStatus);
            Console.WriteLine();
        }
    }
}