using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVehicles
{
    public class Motorcycle : Vehicle
    {
        private double v;

        public Motorcycle(string model, int year, string registrationNumber, double v)
        {
            Model = model;
            Year = year;
            RegistrationNumber = registrationNumber;
            this.v = v;
        }

        public int EngineCapacity { get; set; }

    }
}
