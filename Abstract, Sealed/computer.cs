using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract__Sealed
{
    class Computer:Devices
    {
        public bool Programming;
        public string Keyboarding;

        public Computer(int cost, string color, string dateofproduction,string keyboarding, bool programing):base(cost,color,dateofproduction)
        {
            Programming = programing;
            Keyboarding = keyboarding;

        }

        public override void Storage()
        {
            Console.WriteLine("1TB");
        }

        
    }
}
