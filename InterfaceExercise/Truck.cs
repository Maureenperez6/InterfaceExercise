using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {

        }

        public bool HasBed { get; set; }
        public bool HasTowHook { get; set; }

        public int HowManyWheels { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }


        public string CorpName { get; set; }
        public string Logo { get; set; }

        
        
    }
}
/*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */