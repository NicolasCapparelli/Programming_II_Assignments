using System;
using System.Collections.Generic;
using System.Linq;
/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Lab#: 5B
 */
namespace LabFiveB {
    public class NC_Stack {
        
        // Prompt asks to limit array to 20
        private ClothingItem[] _rack = new ClothingItem[1];
        private int end;
        private int count;
        private int size;
        

        public NC_Stack() {
            end = 0;
            count = 0;
            size = 20;
            _rack = new ClothingItem[size];
        }
        
        public NC_Stack(int size) {
            end = 0;
            count = 0;
            this.size = size;
            _rack = new ClothingItem[size];
        }
        
        
        public void Push(ClothingItem newItem) {
            _rack[end] = newItem;
            end++;
            count++;
        }
        
        public ClothingItem Pop() {
            var toReturn = _rack[end - 1];
            end--;
            count--;
            return toReturn;
        }
        
        public ClothingItem Peek() {
            return _rack[end-1];
        }
       
        public List<ClothingItem> GetColorClothing(string color) {
            var retArray = new List<ClothingItem>();
            
            for (var i = 0; i < end; i++) {

                if (_rack[i].color.Equals(color)) {
                    retArray.Add(_rack[i]);
                }
            }
            return retArray;
        }
        
        public List<ClothingItem> GetHighTempClothing() {
            var retArray = new List<ClothingItem>();
            
            for (var i = 0; i < end; i++) {

                if (_rack[i].isHighTemperatureResistant) {
                    retArray.Add(_rack[i]);
                }
            }
            return retArray;
        }
        
        public void printData() {

            Console.WriteLine("------------------------");
            Console.WriteLine("STACK");

            for (int i = end - 1; i >= 0; i--) {
                Console.WriteLine(_rack[i].color + " " + _rack[i].name);
            }
            
            Console.WriteLine("Stack Length: " +  count);
            Console.WriteLine("------------------------");
        }
    }
}