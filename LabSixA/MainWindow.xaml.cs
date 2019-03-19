/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Lab#: 5B
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using Microsoft.Win32;

namespace LabSixA {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();
        }
        
        private void OpenFile(object sender, RoutedEventArgs e) {

        }
        
        private void SaveFile(object sender, RoutedEventArgs e) {
            
            var dialog = new SaveFileDialog(); 
            dialog.FileName = "MyFile.txt";
            dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            
            // Show dialog
            if (dialog.ShowDialog() ?? false) {
                
                // Create file
                using (var sw = new StreamWriter(dialog.FileName)) {
                    
                    // Split text into lines
                    var list = new List<string>(TextBox.Text.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
                    
                    // Write each line in file
                    foreach (var line in list) {
                        sw.WriteLine(line);
                    }
                }
            }
        }
    }
}