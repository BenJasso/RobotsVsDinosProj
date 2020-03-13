using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobo
{
    class Robot
    {
        //member variables
        public string name;
        public int health;
        public int powerLevel;
    

        //constructor
        public Robot(string name)
        {
            this.name = name;
            
            health = 100;
            powerLevel = 100;
        }

        //methods

    }
}
