namespace LabTwoA {
    public class Staff : Employee {
        
        public Staff(string name, string address, string phoneNumber, string email, string office, double salary, MyDate dateHired) :
            base(name, address, phoneNumber, email, office, salary, dateHired) {
        }
    }
}