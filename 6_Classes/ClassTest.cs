using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _6_Classes
{
    [TestClass]
    public class ClassTest
    {
        [TestMethod]
        public void VehiclePropertyTests()
        {

            Vehicle airplane = new Vehicle();
            airplane.BodyColor = "Hot Pink";
            airplane.Make = "lockheed-martin";
            airplane.Model = "sr-71 blackbird";
            airplane.Mileage = 6718765798.28379456347;
            airplane.TypeOfVehicle = VehicleType.plane;

            Vehicle car = new Vehicle("toyota", "corolla", 250000, "tan", VehicleType.car);
            Console.WriteLine(car.Make);

            Console.WriteLine(airplane.Make + " " +  airplane.Model);
            Console.WriteLine("{0} {1}", airplane.Model, airplane.Make);
        }

        [TestMethod]
        public void PersonTests()
        {
            Person FPS = new Person();
            FPS.FirstName = "Arty";
            Console.WriteLine(FPS.FirstName);
            FPS.LastName = "Robinson";
            Console.WriteLine(FPS.FullName);
            FPS.DOB = new DateTime(1994, 8, 1);

            Person blankPerson = new Person();
            Console.WriteLine(FPS.Age);
        }
        [TestMethod]
        public void areaandfootage()
        {
            Room bedroom = new Room();
            bedroom.Length = 15;
            bedroom.Width = 20;
            bedroom.Height = 10;
            Console.WriteLine(bedroom.SurfaceArea());
        }


    }
    
}
