﻿using InterfacesBildingTheHouse.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBildingTheHouse.Classes
{
    class Window : IPart
    {
        public string Colour { get; set; }
        public string Material { get; set; }
        public string Manufacter { get; set; }
        public DateTime EndWork
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime StartWork
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}