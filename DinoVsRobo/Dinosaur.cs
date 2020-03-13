using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobo
{
    class Dinosaur
    {
        //variables
        public string type;
        public int health;
        public int energy;
        public int attackPower;

        //constructor
        public Dinosaur(string type, int attackPower)
        {
            this.type = type;
            this.attackPower = attackPower;
            health = 100;
            energy = 100;
        }


        //methods


    }
}
