using System;

namespace LabTwoA {
    public class Faculty : Employee {

        private string _officeHours;
        private string _rank;

        public Faculty(PersonFactory pFactory) : base(pFactory) {
            _officeHours = pFactory.OfficeValue ?? "";
            _rank = pFactory.RankValue ?? "";
        }
        
        public override void DisplayData() {
            base.DisplayData();
            Console.WriteLine("\tOffice Hours: " + _officeHours);
            Console.WriteLine("\tRank: " + _rank);
            Console.WriteLine("\tObject Type: Faculty");
            Console.WriteLine();
        }
    }
}