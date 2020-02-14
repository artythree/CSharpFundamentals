using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_challenges
{
    public class Calculator
    {
        public int Addition(int inputone, int inputtwo)
        {
            int output = inputone + inputtwo;
            return output;
        }
        public double Addition(double inputone, double inputtwo)
        {
            double output = inputone + inputtwo;
            return output;
        }

        public double Addition(double[] array)
        {
            int x = array.Length;
            int y = 0;
            double z = 0d;
            while (x > y)
            {
                z += array[y];
                y += 1;
            }
            return z;
        }
        public int Subtraction(int inputone, int inputtwo)
        {
            int output = inputone - inputtwo;
            return output;
        }
        public int Multiplication (int inputone, int inputtwo)
        {
            int output = inputone * inputtwo;
            return output;
        }
        public int Division(int inputone, int inputtwo)
        {
            int output = inputone + inputtwo;
            return output;
        }
       
        
       


    }
}
