namespace LabTwoA {
    public class PersonFactory {
        private string _name;
        private string _address;
        private string _phoneNumber;
        private string _email;
        private Student.Status _classStatus;
        private string _office;
        private double _salary;
        private MyDate _dateHired;
        private string _officeHours;
        private string _rank;
        private string _title;

        public PersonFactory() {}

        // Getters
        public string NameValue => _name;
        public string AddressValue => _address;
        public string PhoneNumberValue => _phoneNumber;
        public string EmailValue => _email;
        public Student.Status? ClassStatusValue => _classStatus;
        public string OfficeValue => _office;
        public double? SalaryValue => _salary;
        public MyDate DateHiredValue => _dateHired;
        public string OfficeHoursValue => _officeHours;
        public string RankValue => _rank;
        public string TitleValue => _title;

        // Builder Setters
        public PersonFactory Name(string name) {_name = name; return this;}
        public PersonFactory Address(string address) {_address = address; return this;}
        public PersonFactory PhoneNumber(string phoneNumber) {_phoneNumber = phoneNumber; return this;}
        public PersonFactory Email(string email) {_email = email; return this;}
        public PersonFactory ClassStatus(Student.Status status) {_classStatus = status; return this;}
        public PersonFactory Office(string office) {_office = office; return this;}
        public PersonFactory Salary(int salary) {_salary = salary; return this;}
        public PersonFactory DateHired(MyDate status) {_dateHired = status; return this;}
        public PersonFactory OfficeHours(string hours) {_officeHours = hours; return this;}
        public PersonFactory Rank(string rank) {_rank = rank; return this;}
        public PersonFactory Title(string title) {_title = title; return this;}

        public Person BuildPerson() {
            return new Person(this);
        }

        public Student BuildStudent() {
            return new Student(this);
        }

        public Employee BuildEmployee() {
            return new Employee(this);
        }
        
        public Faculty BuildFaculty() {
            return new Faculty(this);
        }
        
        public Staff BuildStaff() {
            return new Staff(this);
        }

    }
}