using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVehicles
{
    public class Car : Vehicle
    {
        private int v;

        public Car(string model, int year, string registrationNumber, int v)
        {
            Model = model;
            Year = year;
            RegistrationNumber = registrationNumber;
            this.v = v;
        }

        public int NumberOfDoors { get; set; }

    }
}
