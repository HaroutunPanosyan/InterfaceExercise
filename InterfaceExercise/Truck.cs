using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {        
        // Vehicle Interace Items:
        public string Brand { get; set; } = "Galpin";
        public string Model { get; set; } = "F-150";
        public string Make { get; set; } = "Ford";
        public int Year { get; set; } = 2022;
        public int NumberOfWheels { get; set; } = 4;
        public int BedSize { get; set; } = 4;
        public string LimitedEdition { get; set; } = "not a limited edition";

        public virtual void VehiclePitch()
        {
            Console.WriteLine($"This truck is currently sold by {Brand}. \nIt is a {Year} {Make} {Model} {CabStyle.Lariat}. " +
                $"\nIt comes equipped with {NumberOfWheels} wheels and a spare, and sports a wonderful {DriveTrain.FourWheelDrive}." +
                $"\nUnfortunately this {LimitedEdition}. ");
        }

        // Company Interface Items:
        public string Name { get; set; } = "the Wiley Coyote Company";
        public string ElevatorPitch { get; set; } = "our trucks are so durable, they almost feel like tanks.";

        public virtual void CompanyPitch()
        {
            Console.WriteLine($"We are {Name} and remember {ElevatorPitch}.");
        }


        public string ImageURL { get; } = "";

        public enum CabStyle { Crew, Extended, XL, Lariat, XLT }
        public enum DriveTrain { FourByTwo, FourWheelDrive }
    }
}
