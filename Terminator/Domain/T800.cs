using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminator.Domain
{
    class T800 : Unit
    {
        public string RegistrationNumber { get; set; }
        private bool IsActive { get;}
        private string Name { get; }


        public T800(string name, string registrationNumber, bool isactive) : base(200, 50)
        {
            Name = name;
            RegistrationNumber = registrationNumber;
            IsActive = isactive;
        }

        public bool GetIsActive()
        {
            return IsActive;
        }

        public string GetName()
        {
            return Name;
        }

        public override void Warscream()
        {
            Console.WriteLine("Fuck You A$$Hole");
        }
        
        public override void PrintStatus()
        {
            if (IsAlive)
            {
                Console.WriteLine("Status Report\nSystem Function Normal");
                Console.WriteLine("Helth: " + GetHelth() + "\nAttack: " + GetUnitAttack());
                Console.WriteLine("Select Action\n1.All Systems Operational\n2.Recall Unit\n3. Self Terminate");
                string choise = Console.ReadLine();
                switch (choise)
                {
                    case "2":
                     Console.WriteLine("Unit returning to base");
                    break;
                    case "3":
                     Console.WriteLine("Initilize Self Terminate Protocol\n");
                    break;
                    case "1":
                    default:
                     Console.WriteLine("Continuing Operations");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Status Update\nWARNING!\nUnit has been Terminated");
            }
        }
    }
}
