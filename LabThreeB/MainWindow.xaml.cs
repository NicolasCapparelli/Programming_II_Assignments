using System.Windows;

namespace LabThreeB {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();
        }

        private void CalculateClicked(object sender, RoutedEventArgs e) {
            var answer = (double.Parse(TbLeftOperand.Text) + double.Parse(TbRightOperand.Text));

            if (answer % 1 == 0) {
                LbSum.Content = answer;    
            }
            else {
                LbSum.Content = answer.ToString("N");
            }
        }
        
        private void ClearClicked(object sender, RoutedEventArgs e) {
            TbLeftOperand.Text = "";
            TbRightOperand.Text = "";
            LbSum.Content = "0";
        }
    }
}