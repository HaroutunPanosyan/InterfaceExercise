using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    // Create 4 members that Car, Truck, & SUV all have in common.
    public interface IVehicle : ICompany
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public enum Color { }
        public int NumberOfWheels { get; set; }
        public string LimitedEdition { get; set; }
        public virtual void VehiclePitch() { }
    }
}
