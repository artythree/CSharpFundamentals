using _07_repositoryPattern_consoleUI.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Tests.ui
{
    class MockConsole : IConsole
    {
        private Queue<string> _userinput;

        public MockConsole (IEnumerable<string> input)
        {
            _userinput = new Queue<string>(input);
        }
        public string Output { get; set; } = "";

        public void Clear()
        {
            Output += "called clear method\n";
        }

        public ConsoleKeyInfo ReadKey()
        {
            return new ConsoleKeyInfo();
        }

        public string ReadLine()
        {
            string nextinput = _userinput.Dequeue();
            return nextinput;
        }

        public void Write(string str)
        {
            Output += str;
        }

        public void WriteLine(string output)
        {
            Output += output + "\n";
        }

        public void WriteLine(object obj)
        {
            Output += obj + "\n";
        }
    }
}
