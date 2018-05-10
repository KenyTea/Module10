
using InterfacesBildingTheHouse.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBildingTheHouse.Classes
{
    class Team
    {

        public List<Worker> Workers { get; set; }
        private Random rand = new Random();
        public void WorkJ (ref List<IPart> parts)
        {
            foreach (IPart item in parts)
            {
                if(item.StartWork == null)
                {
                    item.StartWork = DateTime.Now;
                    item.EndWork = DateTime.Now.AddDays(rand.Next(1, 30));
                    Workers[rand.Next(1, Workers.Count)].jobs.Add(item);
                }
            }
        }
    }
}
