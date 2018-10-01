using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminator.Domain
{
    class TargetList
    {
        private List<Target> MostWantedList;

        public TargetList()
        {
            MostWantedList = new List<Target> {
            new Target("Sarah","Conor", true, true),
            new Target("John","Conor",true, true),
            new Target("Kyle","Reese", true, true),
            new Target("T1000"," ", false, false)
            };
        }

        public List<Target> GetTargets()
        {
            return MostWantedList;
        }

        public void RemoveTarget(int target)
        {
            MostWantedList.RemoveAt(target);
        }

        public void ListTargets()
        {
            //List.Where(x => x.Name.ToString().Equals("Apple").ToList()
            //.ForEach(x => { if (x.Name == "") { } });
            int i = 1;
            foreach (var target in MostWantedList)
            {
                Console.WriteLine($"{i} {target.GetFirstName()} {target.GetLastName()}. Human Target: {target.GetIsHuman()}");
                i++;
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
