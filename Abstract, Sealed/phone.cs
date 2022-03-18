using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract__Sealed
{
    class Phone:Devices
    {
        public string Easyportable;
        


        public Phone(int cost, string color, string dateofproduction,string easyportable):base(cost,color,dateofproduction)
        {

            Easyportable = easyportable;

        }

        public override void Storage()
        {
            Console.WriteLine("256 GB");
        }

    }
}
