using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_challenges
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void CheckSquareFootage()
        {
            Room room = new Room
            {
                Length = 10,
                Width = 10
            };
            double squareFootage = room.CalculateSquareFootage();
            Console.WriteLine(squareFootage);
        }
        [TestMethod]
        public void CheckSquareFootageFraction()
        {
            Room classroom = new Room
            {
                Length = 10,
                Width = 10,
            };
            int denominator = 2;

            double actual = classroom.CalculateSquareFootage();
            Console.WriteLine(actual);
            
        }
    }
}
