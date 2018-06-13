using System;
using System.Collections.Generic;
using System.Text;

namespace Airline
{
    public class Flight
    {
        private string planeType;
        private int seats;
        private string _location;
        private string Location
        {
            get
            {
                return _location;
            }
            set
            {
                if (value != null)
                    _location = value;
            }
        } 
        private bool isReady;



        public string Plane(string PlaneType)
        {
            this.planeType = PlaneType;
            if(PlaneType == "MD-80" || PlaneType == "737")
            {
                return PlaneType;
            }
            else
            {
                return "Please select either 'MD-80 or '737' ";
            }
        }
        //public void seatTaken(Passenger passenger, int seats)
        //{
        //    this.Seats = seats;
        //    return seats--;
        //}
    }
}
