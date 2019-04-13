using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    class Address
    {
        public string name; //name 
        private string address1; //first address 
        private string address2; //second address if necessary
        private string city; //city
        private string state; //state
        private int zip; //0-99999

        //constructor used for address class
        public Address(string Name, string Address1, string Address2, string City, string State, int Zip)
        {
            name = Name;
            address1 = Address1;
            address2 = Address2;
            city = City;
            state = State;
            zip = Zip;

        }

        //overloaded constructor with address 2 empty

        //get and set operators formed
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        //ToString used to return data

        public override string ToString() =>
            $"{Name}" + $"{Address1}" + $"{Address2}" +
            $"{City} {State} {Zip:D5}";
    }
}
