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
        public string attackName;

        //constructor
        public Dinosaur(string type, int energy)
        {
            this.type = type;
            this.energy = energy;
            health = 100;
            energy = 100;
            
        }


        //methods


    }
}
