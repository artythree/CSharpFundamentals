using _07_repositoryPattern_consoleUI.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_repositoryPattern_consoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RealConsole console = new RealConsole();
            programUI ui = new programUI(console);
            ui.Run();
            
        }
    }
}
