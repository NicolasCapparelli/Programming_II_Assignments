using System;

namespace LabTwoA {
    public class Faculty : Employee {

        private string officeHours;
        private string rank;

        public Faculty(PersonFactory pFactory) : base(pFactory) {
            officeHours = pFactory.OfficeValue ?? "";
            rank = pFactory.RankValue ?? "";
        }
        
        public override void DisplayData() {
            base.DisplayData();
            Console.WriteLine("\tOffice Hours: " + officeHours);
            Console.WriteLine("\tRank: " + rank);
            Console.WriteLine("\tObject Type: FacultyMember");
            Console.WriteLine();
        }
    }
}