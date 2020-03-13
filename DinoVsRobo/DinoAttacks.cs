using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobo
{
    class DinoAttacks
    {
        //variables
        string attackName;
        int attackPower;

        //constructor
        public DinoAttacks(string attackName, int attackPower)
        {
            this.attackName = attackName;
            this.attackPower = attackPower;
        }

        //methods

        DinoAttacks massiveChomp = new DinoAttacks("massive chomp", 75);

    }
}
