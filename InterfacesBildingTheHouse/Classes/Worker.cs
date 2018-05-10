using InterfacesBildingTheHouse.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBildingTheHouse.Classes
{
    class Worker : IWorker
    {
        public string Name { get; set; }
        public bool IsTaem { get; set; } = false;

        string IWorker.Name { get; set; }

        double IWorker.Salery { get; set; }

        public List<IPart> jobs { get; set; } = new List<IPart>();

        public void PrintReport(List<IPart> parts)
        {
            foreach (IPart item in parts.OrderBy(o=>o.Priority))
            {
                Console.WriteLine("Start works - " + item.StartWork);
                Console.WriteLine("End works - " + item.EndWork);
                Console.WriteLine("----------------------------------");
            }
        }
    }
}
