
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
      
        public List<Worker> Workers { get; set; } = new List<Worker>();
        private Random rand = new Random();

        public void GenerateWorkwer()
        {
            for (int i = 0; i < rand.Next(1, 10); i++)
            {
                Worker worker = new Worker()
                {
                    Name = i.ToString()
                };
                Workers.Add(worker);
            }
        }
        public void WorkJ (ref List<IPart> parts)
        {
            
            foreach (IPart item in parts.OrderBy(o=>o.Priority))
            {
                int wNum = rand.Next(1, Workers.Count);
                if (!Workers[wNum].IsTaem)
                {
                    if (item.StartWork == null)
                    {
                        item.StartWork = DateTime.Now;
                        item.EndWork = DateTime.Now.AddDays(rand.Next(1, 30));

                        Workers[wNum].jobs.Add(item);
                        break;
                    }
                }
                else
                {
                    Workers[wNum].PrintReport(parts);
                }
            }
        }
    }
}
