using System;
using System.Windows;

namespace LabThreeA {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        
        
        public MainWindow() {
            InitializeComponent();
        }

        private void B1_Click(object sender, RoutedEventArgs e) {
            ContentLabel.Content = "Button 1 Clicked";
        }
        
        private void B2_Click(object sender, RoutedEventArgs e) {
            ContentLabel.Content = "Button 2 Clicked";
        }
        
        private void B3_Click(object sender, RoutedEventArgs e) {
            ContentLabel.Content = "Button 3 Clicked";
        }
        
        private void B4_Click(object sender, RoutedEventArgs e) {
            ContentLabel.Content = "Button 4 Clicked";
        }
        
        private void B5_Click(object sender, RoutedEventArgs e) {
            ContentLabel.Content = "Button 5 Clicked";
        }

        private void B6_Click(object sender, RoutedEventArgs e) {
            ContentLabel.Content = "Button 6 Clicked";
        }
    }
}