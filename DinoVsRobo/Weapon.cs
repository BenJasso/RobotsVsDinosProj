using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobo
{
    class Weapon
    {
        //member variables
        public string name;
        public int attackPower;
        public int energyCost;


        //constructor
        public Weapon(string name, int attackPower, int energyCost)
        {
            this.attackPower = attackPower;
            this.name = name;
            this.energyCost = energyCost;

        }
    }



        //methods
        
}
