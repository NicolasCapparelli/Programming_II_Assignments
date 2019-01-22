using System;
using System.Runtime.CompilerServices;

namespace LabTwoA {
    
    // A person has a name, address, phone number, and email address
    public class Person {
        private string name;
        private string address;
        private string phoneNumber;
        private string email;

        public Person(string name, string address, string phoneNumber, string email) {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        
        public virtual void DisplayData(){
            Console.WriteLine(name + "'s Data:");
            Console.WriteLine("\tAddress: " + address);
            Console.WriteLine("\tPhone Number: " + phoneNumber);
            Console.WriteLine("\tEmail Address: " + email);
        }

    }
}