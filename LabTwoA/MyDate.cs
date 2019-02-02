namespace LabTwoA {
    
    // contains the fields year, month and day
    public class MyDate {

        private int year;
        private int month;
        private int day;

        public MyDate(int day, int month, int year) {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        
        public string getDate() {
            string dayString;

            if (day > 9) {
                dayString = day.ToString();
            } else { dayString = "0" + day;}

            return dayString + "/" + month + "/" + year;
        }
    }
}