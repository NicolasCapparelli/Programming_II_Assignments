using System;
using System.Collections;
using System.Linq;

namespace AssignmentOneB {
    
    public class Tests {
        private string firstName;
        private string lastName;
        private double averageTestScore;
        private char grade;
        private double[] testScores;
        
        public Tests(string firstName, string lastName, double[] testScores) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.testScores = testScores;            
            calculateAverageTestScore(true);
        }

        public void calculateGrade() {
            if (averageTestScore >= 90) {
                grade = 'A';
            } else if (averageTestScore >= 80) {
                grade = 'B';
            } else if (averageTestScore >= 70) {
                grade = 'C';
            } else if (averageTestScore >= 60) {
                grade = 'D';
            } else {
                grade = 'F';
            }
        }
        
        public void calculateAverageTestScore(bool calculateGradeAsWell) {
            averageTestScore = testScores.Average();

            if (calculateGradeAsWell) {
                calculateGrade();
            }
        }

        // Getters & Setters
        public char Grade => grade;
        public double AverageTestScore => averageTestScore;
        
        public string FirstName {
            get => firstName;
            set => firstName = value;
        }

        public string LastName {
            get => lastName;
            set => lastName = value;
        }

        public double[] getAllTestScores() {
            return  testScores;
        }
        
        public double getTestScoreAtIndex(int index) {
            return (double) testScores[index];
        }

        public void modifyTestScoreAtIndex(int index, double newGrade) {
            testScores[index] = newGrade;
        }

        public string getAllData() {

            var data = firstName + "\t\t" + lastName + "\t\t";

            data = testScores.Aggregate(data, (current, score) => current + ($"{score:F2}" + "\t"));

            data += averageTestScore + "\t" + grade;

            return data;
        }

    }
}