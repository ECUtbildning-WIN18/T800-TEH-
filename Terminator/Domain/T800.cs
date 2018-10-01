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
        private bool IsActive { get; set; }
        private bool SelfDestruct { get; set; }
        private string Name { get; }
        private int LocationX { get; }
        private int LocationY { get; }
        
        public T800(string name, string registrationNumber, bool isactive, int locationX, int locationY) : base(200, 50)
        {
            Name = name;
            RegistrationNumber = registrationNumber;
            IsActive = isactive;
            LocationX = locationX;
            LocationY = locationY;
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

        public bool ActivateTerminator()
        {
            IsActive = true;
            return IsActive;
        }

        public bool DeactivateTerminator()
        {
            IsActive = false;
            return IsActive;
        }

        public bool SelfTerminate()
        {
            SelfDestruct = true;
            return SelfDestruct;
        }
        
        public override void PrintStatus()
        {
            if (IsAlive)
            {
                Console.WriteLine("Status Report\nSystem Function Normal");
                Console.WriteLine("Helth: " + GetHelth() + "\nAttack: " + GetUnitAttack());
            }
            else
            {
                Console.WriteLine("Status Update\nWARNING!\nUnit has been Terminated");
            }
        }
    }
}
