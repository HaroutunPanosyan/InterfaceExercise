using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        // IVehicle Interface Items:
        public string Brand { get; set; } = "Porsche Panamera";
        public string Model { get; set; } = "4 Sport Turismo";
        public string Make { get; set; } = "Wagons";
        public int Year { get; set; } = 2010;
        public int NumberOfWheels { get; set; } = 4;
        public string LimitedEdition { get; set; } = "is a limited edition";

        public virtual void VehiclePitch()
        {
            Console.WriteLine($"This car is made by {Brand} in {Year}.\n " +
                $"It is a {Model} {Make}.\n" +
                $"It comes equipped with {NumberOfWheels} wheels and a spare." +
                $"This Porsche {LimitedEdition}. ");
        }

        // ICompany Interface Items:
        public string Name { get; set; } = "Porche";
        public string ElevatorPitch { get; set; } = "luxury at it's finest";

        public string ImageURL { get; set; }

        public virtual void CompanyPitch()
        {
            Console.WriteLine($"We are {Name} and remember, this is {ElevatorPitch}.");
        }

        // Items specific to Cars:
        public bool HasSpoiler { get; set; } = false;
        public bool IsMini { get; set; } = false;
        
    }
}
