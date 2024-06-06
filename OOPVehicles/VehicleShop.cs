using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVehicles
{
    public class VehicleShop
    {
        public List<Vehicle> VehicleList { get; set; }
       

        public void AddVehicle(Vehicle Vehicle) //Přidá vozidlo do seznamu
        {
        VehicleList.Add(Vehicle);
        }


        public void ShoWVehicleList()  //Vrátí textovou reprezentaci seznamu vozidel. 
        {
            Vehicle vehicle = VehicleList[VehicleList.Count + 1];
        }


        public void SaveToFile(string a) //Uloží seznam vozidel do textového souboru.
        {
            using (StreamWriter slozka = new StreamWriter("@soubor.txt"))
            {
                slozka.WriteLine(a);
            }
        }
        public void ToVehicleString()
        {

        }

    }
}
