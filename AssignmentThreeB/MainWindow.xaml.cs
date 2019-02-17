using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AssignmentThreeB {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        
        // TODO: Account for if user tries to operate on an answer
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
            FieldPresent.Text = "0";
            
            switch (s) {
                case "C":
                    _calculator.Clear();
                    currentOperand = "";
                    FieldEquation.Text = "";
                    FieldPresent.Text = "0";
                    break;
                
                case "⌫":

                    if (FieldEquation.Text.Contains("=")) {
                        // TODO: Figure out why this still sets FieldPresent.Text to 0

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
                    FieldPresent.Text = _calculator.Calculate().ToString("N");
                    
                    currentOperand = "";
                    _calculator.Clear();
                    break;
            }

        }

    }
}