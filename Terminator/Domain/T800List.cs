using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminator.Domain
{
    class T800List
    {
        private Dictionary<string,T800> T800Units = new Dictionary<string,T800>();

        public T800List() { 
        T800 Arnold = new T800("Arnold","12345", true);
        T800 Dva = new T800("Dva","21345", true);
        T800 RoadHog = new T800("RoadHog","31245", false);
        T800 ReinHardt = new T800("Reinhardt","412235", false);
        T800 Gengu = new T800("Gengu","51234", true);
            T800Units.Add(Arnold.GetName(), Arnold);
            T800Units.Add(Dva.GetName(), Dva);
            T800Units.Add(RoadHog.GetName(), RoadHog);
            T800Units.Add(ReinHardt.GetName(), ReinHardt);
            T800Units.Add(Gengu.GetName(), Gengu);
        }

        public Dictionary<string, T800> GetTerminators()
        {
            return T800Units;
        }

        public void ListInactiveTerminators()
        {
            int i = 1;
            foreach (T800 target in T800Units.Values)
            {
                if (target.GetIsActive() == false) // if terminator isn't active the console adds him to the list 
                {
                    Console.WriteLine(i + ". " + target.GetName());// and writes it to the screen here
                    i++;
                }
            }
        }

        public void ListActiveTerminators()
        {
            int i = 1;
            foreach (T800 target in T800Units.Values)
            {
                if(target.GetIsActive() == true) { // if terminator is active add him to the list
                Console.WriteLine(i +". " +target.GetName());// and write his name to the screen
                    i++;
                }
            }
        }

        public int SelectTarget(int currentTarget)
        {
            Console.WriteLine("Select Target:");
            currentTarget = Convert.ToInt32(Console.ReadLine());
            return currentTarget;
        }

    }
}
