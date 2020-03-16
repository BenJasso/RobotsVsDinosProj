using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobo
{
    class DinoAttack
    {
        public string attackName;
        public int attackPower;
        public int attackCost;

        //constructor
        public DinoAttack(string attackName, int attackPower, int attackCost)
        {
            this.attackName = attackName;
            this.attackPower = attackPower;
            this.attackCost = attackCost;
        }



    }
}
