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
        
        public int attackCost;
        

        //constructor
        public Dinosaur(string type, int health)
        {
            this.type = type;

            this.health = health;

            energy = 100;
            
        }


        //methods


    }
}
