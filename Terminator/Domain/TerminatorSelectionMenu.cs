using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminator.Domain
{
    class TerminatorSelectionMenu
    {
        T800List T800Units = new T800List();            // DictionaryList of Terminators
        private Dictionary<string, T800> Terminators;
        private int TargetIndex = 0;
        private string CurrentTerminator = "No Terminator Selected";

        public TerminatorSelectionMenu()
        {
            Terminators = T800Units.GetTerminators(); // Terminator DictionaryList in the Menu
        }

        public void SelectMenu()
        {
            // T800Units.ListActiveTerminators();
            // T800Units.ListInactiveTerminators();
            Console.WriteLine("==Skynet T800 Manual Action Overide Protocol 1.0==");
            Console.WriteLine("\n1. Select Terminator\n2. Activate Terminator\n3.Exit");
            Console.WriteLine("\nCurrent Terminator: " + CurrentTerminator);
            Console.Write("\nSelect Action:");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    T800Units.ListActiveTerminators(); // Lists Active Terminators
                    TargetIndex = T800Units.SelectTarget(TargetIndex);
                   // Set CurrenT Terminator to Chosen Terminator
                   // Launch Menu
                    break;
                case "2": // Show Inactive Terminators
                    T800Units.ListInactiveTerminators();
                    Console.WriteLine("Activate Terminator:");
                    // Run Activate Terminator from T800List or T800
                    break;
                case "3":
                    Environment.Exit(0); // bye!
                    break;
                default:
                    Console.WriteLine("--Unkown Action--"); // Select Better noob! :p
                    break;
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
