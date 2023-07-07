using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            List<IVehicle> vehicles = new List<IVehicle>();
            List<ICompany> companys = new List<ICompany>();

            Car car = new Car();
            Truck truck = new Truck();
            SUV suv = new SUV();

            vehicles.Add(car);
            vehicles.Add(truck);
            vehicles.Add(suv);

            companys.Add(car);
            companys.Add(truck);
            companys.Add(suv);

            foreach (var item in vehicles)
            {
                Console.WriteLine();
                item.VehiclePitch();
                item.CompanyPitch();
            }

        }
    }
}
