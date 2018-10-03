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
            TerminatorSelectionMenu TMenu = new TerminatorSelectionMenu();
            bool end = false;
            while (end == false)
            {
              end =  TMenu.SelectMenu(end);
            }
            end = false;
            while (end == false)
            {
                MainMenu.TerminatorMenu();
            }
        }
    }
}
