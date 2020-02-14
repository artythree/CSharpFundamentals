using System;
using System.Collections.Generic;
using _07_repositoryPattern_consoleUI.UI;
using _07_RepositoryPattern_Tests.ui;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class programuitests
    {
        [TestMethod]
        public void AddToList_ShouldSeeItemInOutput()
        {
            List<string> commandList = new List<string>
            {
                "4",
                "title",
                "description",
                "Genre",
                "27",
                "5",
                "4",
                "language",
                "7"
            };

            MockConsole console = new MockConsole(commandList);
            programUI ui = new programUI(console);

            ui.Run();
            Console.WriteLine(console.Output);
        }
    }
}
