﻿using InterfacesBildingTheHouse.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBildingTheHouse.Classes
{
    class Door : IPart
    {
        public string Colour { get; set; }
        public DateTime EndWork { get; set; }
        public string Name { get; set; }
        public DateTime StartWork { get; set; }
    }
}
