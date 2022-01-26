using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {

        }
        public bool HasTrunk { get; set; }
        public bool IsFuelEfficienct { get; set; }

        public int HowManyWheels { get; set; }
        public string Model { get ; set ; }
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