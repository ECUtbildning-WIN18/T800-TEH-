using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminator.Domain;

namespace Terminator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu MainMenu = new Menu();
            while (true)
            {
                MainMenu.TerminatorMenu();
            }
        }
    }
}
