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
        private List<T800> Terminators;
        private int TargetIndex = 0;
        private string CurrentTerminator = "No Terminator Selected";
        Menu MainMenu = new Menu();

        public TerminatorSelectionMenu()
        {
            Terminators = T800Units.GetTerminators(); // Terminator DictionaryList in the Menu
        }
        public void DeleteFromList()
        {
            
        }
        public void SelectMenu()
        {
            // T800Units.ListActiveTerminators();
            // T800Units.ListInactiveTerminators();
            Console.WriteLine("==Skynet T800 Manual Action Overide Protocol 1.0==");
            Console.WriteLine("\n1. Select Terminator\n2. Activate Terminator\n3. Deactivate Terminator" +
                "\n4. Terminate Unit\n5. Exit");
            Console.WriteLine("\nCurrent Terminator: " + CurrentTerminator);
            Console.Write("\nSelect Action:");
            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    T800Units.ListActiveTerminators(); // ListsTerminators
                    TargetIndex = T800Units.SelectTarget(TargetIndex);// lets the user select a Target to make current target
                    
                    if(Terminators[TargetIndex-1].GetIsActive() == true) { // if Terminator IsActive Proced to Terminate
                    CurrentTerminator = Terminators[TargetIndex - 1].GetName();
                    Console.WriteLine("Unit " + CurrentTerminator + " ready to recive instrutions");
                    Console.ReadLine();
                    Console.Clear();
                    MainMenu.TerminatorMenu();
                    }else { // if Terminator isnt active nothing happends
                        Console.WriteLine("Unit is Deactivated");
                        }
                    break;
                case "2": // Show Inactive Terminators
                    T800Units.ListActiveTerminators(); // ListsTerminators
                    Console.WriteLine("Activate Terminator:");
                    TargetIndex = T800Units.SelectTarget(TargetIndex);
                    if(Terminators[TargetIndex - 1].GetIsActive() == false) { 
                    Terminators[TargetIndex - 1].ActivateTerminator();
                        Console.WriteLine(Terminators[TargetIndex -1].GetName() +" has been Activated");
                    }
                    else
                    {
                        Console.WriteLine("Terminator is already Active");
                    }
                    break;
                    case "3":
                    T800Units.ListActiveTerminators(); // ListsTerminators
                    Console.WriteLine("Deactivate Terminator:");
                    TargetIndex = T800Units.SelectTarget(TargetIndex);
                    if (Terminators[TargetIndex - 1].GetIsActive() == true)
                    {
                        Terminators[TargetIndex - 1].DeactivateTerminator();
                        Console.WriteLine(Terminators[TargetIndex - 1].GetName() + " has been Deactivated");
                    }
                    else
                    {
                        Console.WriteLine("Terminator is already Deactivated");
                    }
                    break;
                case "4":
                    T800Units.ListActiveTerminators();
                    Console.WriteLine("Select unit for Termination");
                    TargetIndex = T800Units.SelectTarget(TargetIndex);
                    Terminators[TargetIndex - 1].SelfTerminate(); // And the Target is marked as dead
                    T800Units.RemoveTarget(TargetIndex - 1); // REMOVES DEAD TARGET FROM LIST
                    Console.WriteLine("Unit has been Terminated");
                    break;
                case "5":
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
