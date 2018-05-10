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
        public bool IsTaem { get; set; } = false;
        

        string IWorker.Name { get; set; }
        

      

        double IWorker.Salery { get; set; }
        

      
    }
}
