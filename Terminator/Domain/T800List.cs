using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminator.Domain
{
    class T800List
    {
        private List<T800> T800Units = new List <T800>();

        public T800List() {
            T800Units = new List<T800> {
            new T800("Arnold","12345", false,1,2),
            new T800("DvaBot", "21345", false, 2, 3),
            new T800("RoadHog", "31245", false, 3, 4),
            new T800("Reinhardt", "412235", false, 4, 4),
            new T800("Gengu", "51234", true, 15, 20),
        };
        }

        public List<T800> GetTerminators()
        {
            return T800Units;
        }
        
        public void ListActiveTerminators()
        {
            int i = 1;
            foreach (T800 target in T800Units)
            {
                Console.WriteLine(i +". " +target.GetName() + "\t Active:" + target.GetIsActive());// and write his name to the screen
                    i++;
                
            }
        }

        public void RemoveTarget(int target)
        {
            T800Units.RemoveAt(target);
        }
        
                 
        public int SelectTarget(int currentTarget)
        {
            Console.WriteLine("Select Target:");
            currentTarget = Convert.ToInt32(Console.ReadLine());
            return currentTarget;
        }
        
    }
}
