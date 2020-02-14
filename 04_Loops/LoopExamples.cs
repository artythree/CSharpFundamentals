using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void Dowhileloops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("hello");
                iterator++;
            }
            while (iterator < 5);

            do
            {
                Console.WriteLine("dowhile condition is false");
            }
            while (false);
        }
        [TestMethod]
        public void forloops()
        {
            int counter = 34;
            for (int i = 0; i<counter; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "nick", "amanda", "craig", "justin", "urmomlol" };
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"all are welcome {students[i]}");
            }

        }
        [TestMethod]
        public void While()
        {
            int x = 1;
            while (x != 10)
            {
                Console.WriteLine(x);
                x++;
            }
            Random rand = new Random();
            int y;
            bool keeploopy = true;
            while (keeploopy)
            {
                y = rand.Next(0, 20);
                if (y == 6 || y == 10 || y==15 )
                {
                    continue;
                }
                Console.WriteLine(y);
                if (y == 19)
                {
                    keeploopy = false;
                }
            }

        }
        [TestMethod]
        public void Foreach()
        {
            string[] students = { "nick", "amanda", "craig", "justin", "urmomlol","tommy boi", "josh" };
            foreach (string student in students)
            {
                Console.WriteLine(student + "is worthless");
            }

            string muhname = "arty the merciless";
            foreach(char letter in muhname)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
        }
        [TestMethod]
        public void challenge()
        {
            var chars = "bcdfghjklmnpqrstvwxyz1234567890";
            int counter = 0;
            int length = chars.Length;
            string password = "";
            Random rand = new Random();
            int countertwo = 0;
            do
            {

                password = "";
                
                while (counter < 10)
                {

                    int randomalpha = rand.Next(1, length);
                    char alphanum = chars[randomalpha];
                    if (counter < 1)
                    {
                        password += alphanum;
                        counter += 1;
                    }
                    else if (alphanum == '3' && password[counter - 1] == '1')
                    {
                        continue;
                    }
                    else
                    {
                        password = password + alphanum;
                        counter += 1;
                    }
                    

                }
                counter = 0;
                countertwo += 1;
                Console.WriteLine(password);

            } while (countertwo < 10);

        }
    }
}