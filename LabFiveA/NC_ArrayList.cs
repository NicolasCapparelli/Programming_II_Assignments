using System;

namespace LabFiveA {
    public class NC_ArrayList {
        
        private int size;
        int[] mainArray = new int[1];

        public NC_ArrayList() {
        }
        
        public NC_ArrayList(int[] declaredArray) {
            mainArray = declaredArray;
        }

        public void Add(int num) {
            if (size == mainArray.Length) {
                var copy = new int[mainArray.Length + 1];
                mainArray.CopyTo(copy,0);
                mainArray = copy;
            }

            mainArray[size++] = num;
        }

        public void Print() {

            foreach (var n in mainArray) {
                Console.WriteLine(n);    
            }
            
        }

    }
}