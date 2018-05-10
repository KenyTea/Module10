﻿using InterfacesBildingTheHouse.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBildingTheHouse.Classes
{
    class House
    {
        //public List<Basement> Wasements { get; set; }
        //public List<Wall> Walls { get; set; }
        //public List<Door> Doors { get; set; }
        //public List<Roof> Roofs { get; set; }
        //public List<Window> Windows { get; set; }

        public List<IPart> PartsHouse { get; set; }
        public void CreatePlanHouse()
        {
            Random rand = new Random();
            for (int i = 0; i < rand.Next(1, 10); i++)
            {
                IPart w = new Basement();
                w.Name = "Basement";
                PartsHouse.Add(w);
            }

            for (int i = 0; i < rand.Next(1, 10); i++)
            {
                IPart w = new Wall();
                w.Name = "Wall";
                PartsHouse.Add(w);
            }

            for (int i = 0; i < rand.Next(1, 10); i++)
            {
                IPart w = new Door();
                w.Name = "Door";
                PartsHouse.Add(w);
            }

            for (int i = 0; i < rand.Next(1, 10); i++)
            {
                IPart w = new Roof();
                w.Name = "Roof";
                PartsHouse.Add(w);
            }

            for (int i = 0; i < rand.Next(1, 10); i++)
            {
                IPart w = new Window();
                w.Name = "Window";
                PartsHouse.Add(w);
            }
        }
    }
}
