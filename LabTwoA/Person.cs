using System;
using System.Runtime.CompilerServices;

namespace LabTwoA {
    
    // A person has a name, address, phone number, and email address
    public class Person {
        private string name;
        private string address;
        private string phoneNumber;
        private string email;

        public Person(PersonFactory pFactory) {
            name = pFactory.NameValue ?? "";
            address = pFactory.AddressValue ?? "";
            phoneNumber = pFactory.PhoneNumberValue ?? "";
            email = pFactory.EmailValue ?? "";
        }
        
        public virtual void DisplayData(){
            Console.WriteLine(name + "'s Data:");
            Console.WriteLine("\tAddress: " + address);
            Console.WriteLine("\tPhone Number: " + phoneNumber);
            Console.WriteLine("\tEmail Address: " + email);
            Console.WriteLine("\tObject Type: " + GetType());
        }

    }
}