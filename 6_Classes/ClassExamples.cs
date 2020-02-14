using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Classes
{
    public enum VehicleType { plane, car, truck, boat, spaceplane, spaceship, rocketship }

    class Vehicle
    {
        public Vehicle()
        {
        }

        public Vehicle(string make, string model, double mileage, string bodycolor, VehicleType type)
        {//this is a constructor, it is automatically applied if not explicitly typed

            Make = make;
            Model = model;
            Mileage = mileage;
            BodyColor = bodycolor;
            TypeOfVehicle = type;

        }

        public string BodyColor { get; set;/*this is a property*/}

        public string Make { get; set; }

        public string Model { get; set; }

        public double Mileage { get; set; }

        public VehicleType TypeOfVehicle { get; set; }
    }

    public class Person
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }


        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName
        {
            get
            {
                string x = $"{FirstName} {LastName}";


                if (string.IsNullOrWhiteSpace(x))
                {
                    return "unnamed";
                }

                else
                {
                    return x;
                }

            }
            //set
            //{

            //}
        }
        public DateTime DOB { get; set; }

        //DateTime newDate = new DateTime();
        public int Age
        {
            get
            {

                if (DOB == new DateTime())
                {
                    return -1;
                }

                TimeSpan agespan = DateTime.Now - DOB;
                double totalageinyears = agespan.TotalDays / 365.25;
                int years = Convert.ToInt32(Math.Floor(totalageinyears));
                Console.WriteLine(years);
                return years;

            }
            //set
            //{

            //}
        }


    }

    public class Room
    {
        private int _height;

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private int _width;

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        private int _length;

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public object Get { get; private set; }

        public int SquareFootage()
        {
            int squarefootage = Length * Width;
            Console.WriteLine(squarefootage);
            return squarefootage;
        }

        public int SurfaceArea()
        {



            //int horizontal = length * width * 2;
            //int verticalone = width * height * 2;
            //int verticaltwo = length * height * 2;
            //int surfacearea = horizontal + verticalone + verticaltwo;
            //Console.WriteLine(surfacearea);
            //return surfacearea;


            int x = 0;
            int y;
            int[] SA = { Length, Width, Height };
            int w;
            List<int> listed = new List<int>();
            while (x < 2)

            {
                y = x + 1;
                w = SA[x] * SA[y] * 2;
                listed.Add(w);
                x += 1;
                w = 0;

            }
            
            
            y = x - 2;
            w = SA[x] * SA[y] * 2;
            listed.Add(w);
            w = 0;
            while (x >= 0)
            {
                w += listed[x];
                x -= 1;
                Console.WriteLine(w);
            }

                
            
            return w;


        }


    } } 
