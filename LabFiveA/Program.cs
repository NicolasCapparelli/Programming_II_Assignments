using System;
using System.Collections;
using System.Collections.Generic;

namespace LabFiveA {
    internal class Program {
        
        public static void Main(string[] args) {
            var testArr = new NC_ArrayList();
            testArr.Add(3);
            testArr.Add(4);
            testArr.Add(4);
            testArr.Add(4);
            testArr.Add(4);
            testArr.Add(4);
            testArr.Add(5);

            testArr.Print();
            
        }

    }
}