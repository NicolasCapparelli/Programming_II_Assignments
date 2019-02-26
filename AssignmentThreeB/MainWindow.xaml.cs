using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Assignment#: 3B
 */

namespace AssignmentThreeB {
    public partial class MainWindow {
        
        private readonly Calculator _calculator = new Calculator();
        private string currentOperand = "";
        
        public MainWindow() {
            InitializeComponent();
        }

        private void KeyPadPress(object sender, RoutedEventArgs e) {

            if (FieldPresent.Text.Equals("0")) {
                FieldPresent.Text = "";
            }
            else if(FieldEquation.Text.Contains("=")) {
                _calculator.Clear();
                currentOperand = "";
                FieldEquation.Text = "";
                FieldPresent.Text = "";
            }

            var s = ((Button) sender).Content.ToString();
            FieldPresent.Text += s;
            currentOperand += s;
        }
        
        private void FunctionPress(object sender, RoutedEventArgs e) {

            var s = ((Button) sender).Content.ToString();
            

            if (FieldEquation.Text.Contains("=")) {
                FieldEquation.Text = "";
                currentOperand = FieldPresent.Text;
                FieldPresent.Text = "";
            }
            else {
                FieldPresent.Text = "0";
            }

            switch (s) {
                case "C":
                    _calculator.Clear();
                    currentOperand = "";
                    FieldEquation.Text = "";
                    FieldPresent.Text = "0";
                    break;
                
                case "⌫":

                    if (FieldEquation.Text.Contains("=")) {

                    } else if (currentOperand.Length > 1) {
                        currentOperand = currentOperand.Remove(currentOperand.Length - 1);
                        FieldPresent.Text = currentOperand;
                    } else {
                        currentOperand = "";
                        FieldPresent.Text = "0";
                    }

                    break;
                
                case "+":
                case "-":
                case "*":
                case "/":    
                    // Load operand and operator
                    _calculator.Load(currentOperand);
                    _calculator.Load(s);
                    
                    // Display the loaded components to user
                    FieldEquation.Text += currentOperand + " " + s + " ";
                    
                    // Clear current operand
                    currentOperand = "";
                    break;
               
                case "=":
                    _calculator.Load(currentOperand);
                    FieldEquation.Text += currentOperand + " =";

                    var answer = _calculator.Calculate();
                    FieldPresent.Text = answer % 1 == 0 ? answer.ToString("N0") : answer.ToString();

                    currentOperand = "";
                    _calculator.Clear();
                    break;
            }

        }

    }
}