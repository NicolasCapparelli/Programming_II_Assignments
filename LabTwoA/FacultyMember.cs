using System;

namespace LabTwoA {
    
    public class FacultyMember : Person {

        private string officeHours;
        private string rank;
        
        public FacultyMember(string name, string address, string phoneNumber, string email, string officeHours, string rank) :
            base(name, address, phoneNumber, email) {

            this.officeHours = officeHours;
            this.rank = rank;
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