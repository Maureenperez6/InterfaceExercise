using System;
using System.Collections.Generic;

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

            var vehicles = new List<IVehicle>();

            var sedan1 = new Car() 
            { 
                CorpName = "BrandA",
                Logo = "Best BrandA Ever!",
                Year = 2021, 
                Make = "Honda", 
                Model = "Accord", 
                HowManyWheels = 4, 
                HasTrunk = true, 
                IsFuelEfficienct = true 
            };

            var pickup1 = new Truck()
            {
                CorpName = "Landscaper Inc",
                Logo = "Trees",
                Year = 2021,
                Make = "Honda",
                Model = "Accord",
                HowManyWheels = 4,
                HasBed = true,
                HasTowHook = true
             };

            var suv1 = new SUV()
            {
                CorpName = "Cool Jeeps",
                Logo = "C00l J33P5",
                Year = 2021,
                Make = "Jeep",
                Model = "Wrangler",
                HowManyWheels = 4,
                HasCargo = true,
                HasAlotOfSeats = true
            };

            vehicles.Add(sedan1);
            vehicles.Add(pickup1);
            vehicles.Add(suv1);

            foreach( var car in vehicles)
            {
                Console.WriteLine($"Vehicle{car.Make} it is a {car.Model} the year of the car is {car.Year},it has {car.HowManyWheels}.");
                
            }

            }
        }
    }

