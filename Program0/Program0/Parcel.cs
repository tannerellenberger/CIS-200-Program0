using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    public class Parcel 
    {
        private string orginaddress;
        private string destinationaddress;
        private decimal cost;

        public Parcel(string OrginAddress, string DestinationAddress)
        {

            orginaddress = OrginAddress;
            destinationaddress = DestinationAddress;

        }

        public string OrginAddress { get; set; }
        public string DestinationAddress { get; set; }

        public CalcCost(decimal Cost)
        {
            cost = Cost;
        }


        

    }
}
