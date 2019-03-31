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
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using Microsoft.Win32;

namespace LabSixA {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        private string lastFileOpened = "";
        
        public MainWindow() {
            InitializeComponent();
        }
        
        private void OpenFile(object sender, RoutedEventArgs e) {
            var dialog = new OpenFileDialog();
            dialog.Title = "Open File";
            dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (dialog.ShowDialog() ?? false) {
                var text = File.ReadAllText(dialog.FileName);
                TextBox.Clear();
                TextBox.Text = text;
                lastFileOpened = dialog.FileName;
            }
        }

        private void SaveFile(object sender, RoutedEventArgs e) {
            if (lastFileOpened != "") {
                // Split text into lines
                var list = new List<string>(TextBox.Text.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
                File.WriteAllLines(lastFileOpened, list);
            } else {
                SaveFileAs(null, null);
            }
        }

        private void SaveFileAs(object sender, RoutedEventArgs e) {
            
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

                    lastFileOpened = dialog.FileName;
                }
            }
        }
    }
}