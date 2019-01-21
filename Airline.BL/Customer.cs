using System;
using System.Collections.Generic;

namespace Airline.BL
{
    public class Customer
    {
        public List<Address> AddressList { get; set; }

        public Customer(int customerFlightId)
        {
            this.CustomerFlightId = customerFlightId;
            AddressList = new List<Address>();
        }

        public int CustomerFlightId { get; set; }
    }
}
