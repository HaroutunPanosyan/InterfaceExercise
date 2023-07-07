using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        // SUV Specific Items:
        public enum CargoHoldSize { Small, Medium, Large }
        public bool HasFourWheelDrive { get; set; } = true;

        // IVehicle Specific Items:
        public string Brand { get; set; } = "Galpin";
        public string Model { get; set; } = "Jeep";
        public string Make { get; set; } = "Rangler";
        public int Year { get; set; } = 2026;
        public int NumberOfWheels { get; set; } = 6;
        public string LimitedEdition { get; set; } = "is not a limited edition.";
        public virtual void VehiclePitch() 
        {
            Console.WriteLine($"This SUV is made by {Brand} in {Year}. It is a {Model} {Make}.\nIt comes equipped with {NumberOfWheels} wheels and three spares." +
                $" It's got a fairly {CargoHoldSize.Large} cargo bay. \nUnfortunately this {LimitedEdition}. ");
        }

        // ICompany Specific Items:
        public string Name { get; set; }
        public string ElevatorPitch { get; set; }

        public string ImageURL { get; set; }
        public virtual void CompanyPitch() 
        {
            Console.WriteLine($"We are {Name} and remember {ElevatorPitch}.");
        }
    }
}
