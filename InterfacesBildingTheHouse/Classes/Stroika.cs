﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBildingTheHouse.Classes
{
    public class Stroika
    {
        public void StartSt()
        {
            House house = new House();
            house.CreatePlanHouse();

            Team team = new Team();
            team.GenerateWorkwer();

            while (house.PartsHouse.Count(c => c.StartWork == null) > 0)
            {
                team.WorkJ(ref house.PartsHouse);
            }
        }
    }
}
