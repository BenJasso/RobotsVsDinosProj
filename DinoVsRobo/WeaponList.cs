using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobo
{
    class WeaponList
    {

        public Weapon electricBlaster;
        public Weapon zapper;
        public Weapon rayGun;


        public WeaponList()
        {
        electricBlaster = new Weapon("electric blaster", 50, 25);
        zapper = new Weapon("zapper", 20, 10);
        rayGun = new Weapon("ray gun", 35, 15);
        }



    }
}
