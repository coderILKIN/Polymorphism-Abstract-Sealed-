using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract__Sealed
{
    abstract class Devices
    {
        public int Cost;
        public string Color;
        public string Dateofproduction;

        public Devices(int cost,string color,string dateofproduction)
        {
            Cost = cost;
            Color = color;
            Dateofproduction = dateofproduction;
        }

        public abstract void Storage();
        



    }
}
