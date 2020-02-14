using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_challenges
{
    class Room
    {
        public double Length { get;set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateSquareFootage()
        {
            double squareFootage = Length * Width;
            return squareFootage;

        }
        public double CalculateLateralSurfaceArea()
        {
            //double LW = Length * Width * 2;
            double LH = Length * Height * 2;
            double WH = Width * Height * 2;
            double Total = LH + WH;
            return Total;
        }
    }
}
