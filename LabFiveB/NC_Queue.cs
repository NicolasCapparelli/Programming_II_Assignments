using System;
/**
 * Class: CSE 1322L
 * Section: 07
 * Term: Spring
 * Instructor: Kevin Markley
 * Name: Nicolas Capparelli
 * Lab#: 5B
 */
namespace LabFiveB {
    public class NC_Queue {
        
        private readonly Food[] _line;
        private int _start;
        private int _end;
        public int count;
        private readonly int _max;
        

        public NC_Queue(int size) {
            _start = 0;
            _end = 0;
            count = 0;
            _line = new Food[size];
            _max = size + 1;
        }

        public void enqueue(Food food) {
            if ((_end + 1) % _max == _start) {
                Console.WriteLine("Queue Full");
                return;
            }

            _line[_end] = food;
            _end = (_end + 1) % _max;
            count++;
        }

        public Food dequeue() {
            if (count == 0) {
                
            }

            var retValue = _line[_start];
            _start = (_start + 1) % _max;
            count--;
            return retValue;
        }

        public Food peek() {
            return _line[_start];
        }

        public void displayQueue() {
            Console.Write(" F -> | ");
            for (var i = _start; i < _end; i++) {
                Console.Write(_line[i].name + " | ");    
            }
            
            Console.Write("<- B\n");
        }

        public float AverageCaloriesPerServing() {

            var total = 0;
            for (var i = _start; i < _end; i++) {
                total += _line[i].caloriesPerServing;
            }

            return (float)total / count;
        }

        public Food HighestTotalCalorie() {

            var highest = 0;
            var index = 0; 
            
            for (var i = _start; i < _end; i++) {
                if (_line[i].caloriesPerServing * _line[i].numberOfServings <= highest) continue;
                highest = _line[i].caloriesPerServing * _line[i].numberOfServings;
                index = i;
            }

            return _line[index];
        }

        public Exception IndexOutOfRangeException { get; set; }
    }
}