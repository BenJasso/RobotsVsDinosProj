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
        public DinoAttack massiveChomp;
        public DinoAttack massiveStomp;
        public DinoAttack tailSwipe;

        //methods

        public DinoAttacks()
        {
            massiveChomp = new DinoAttack("massive chomp",75, 50);
            massiveStomp = new DinoAttack("massive stomp", 55, 30);
            tailSwipe = new DinoAttack("tail swipe", 30, 15);

        }

    }
}
