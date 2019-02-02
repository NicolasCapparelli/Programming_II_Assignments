using System;

namespace LabTwoA {
    public class Staff : Employee {

        private string _title;

        public Staff(PersonFactory pFactory) : base(pFactory) {
            _title = pFactory.TitleValue ?? "";
        }
        
        // TODO: RE-RUN AND SUBMIT THIS | NEED NEW RUN PNGs  
        public override void DisplayData() {
            base.DisplayData();
            Console.WriteLine("\tTitle: " + _title);
            Console.WriteLine("\tObject Type: Staff");
            Console.WriteLine();
        }
    }
}