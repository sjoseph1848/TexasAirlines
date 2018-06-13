using System;

namespace Airline
{
    class Program
    {
        static void Main()
        {
            var planes = new Flight();

            var airline = planes.Plane("MD80");
            Console.WriteLine(airline);

        }
    }
}
