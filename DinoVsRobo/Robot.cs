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
        public string weaponName;
        public int weaponPower;
       
    

        //constructor
        public Robot(string name, int health)
        {
            this.name = name;
            
            this.health = health;
            powerLevel = 100;
        }

        //methods

    }
}
