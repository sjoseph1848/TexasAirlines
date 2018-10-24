using System;
using System.Collections.Generic;
using System.Text;

namespace Airline
{
    public class Plane
    {
        private string _supplier;
        private string _model;
        private string _year;
        private double _currentValue;
        private double _purchaseValue;

        public Plane(string supplier, string model, string year, double currentValue, double purchaseValue)
        {
            _supplier = supplier;
            _model = model;
            _year = year;
            _currentValue = currentValue;
            _purchaseValue = purchaseValue;
        }

        public Plane(string model, double currentValue, double purchaseValue)
        {
            _model = model;
            _currentValue = currentValue;
            _purchaseValue = purchaseValue;
        }

        public double GetSalvageValue()
        {
            Console.WriteLine("You initially paid ${0}",_purchaseValue);
            return _currentValue;
        }

        

        public override string ToString()
        {
            return String.Format("Airplane Supplier: {0}\n" +
                                 "Airplane Model: {1}\n" +
                                 "Airplane Year Delivered: {2}\n" +
                                 "Airplane Current Value: {3}\n", _supplier,_model,_year,_currentValue); 
        }
    }
}
