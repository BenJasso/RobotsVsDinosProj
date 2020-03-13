using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobo
{
    class Fleet
    {
        public Robot robo1;
        public Robot robo2;
        public Robot robo3;

        public Fleet()
        {
            robo1 = new Robot("R100");
            robo2 = new Robot("R200");
            robo3 = new Robot("R500");
        }


    }
}
