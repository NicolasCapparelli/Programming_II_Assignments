namespace LabTwoA {
    public class Staff : Employee {

        private string title { get; set; }

        public Staff(PersonFactory pFactory) : base(pFactory) {
            title = pFactory.TitleValue ?? "";
        }
    }
}