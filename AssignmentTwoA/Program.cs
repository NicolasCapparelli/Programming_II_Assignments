using System;

namespace AssignmentTwoA {
    internal class Program {
        public static void Main(string[] args) {
            
            var toNassau = new AllInclusiveVacation();
            toNassau.budget = 2000;
            toNassau.destination = "Nassau";
            toNassau.Brand = "Hyatt";
            toNassau.Rating = 5;
            toNassau.Price = 1500.0;
            Console.WriteLine("The budget offset for your Nassau trip is: " + toNassau.CalculateBudgetOffset());
            
            var toPuntaCana = new PieceMealVacation();
            toPuntaCana.budget = 5000;
            toPuntaCana.destination = "Nassau";
            toPuntaCana.costMap["hotelCost"] = 4000;
            toPuntaCana.costMap["mealCost"] = 800;
            toPuntaCana.costMap["airfareCost"] = 1200;
            Console.WriteLine("The budget offset for your Punta Cana trip is: " + toPuntaCana.CalculateBudgetOffset());
        }        
    }
}