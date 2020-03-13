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



        //methods
        Weapon electricBlaster = new Weapon("electric blaster", 35, 10);
        Weapon zapper = new Weapon("zapper", 45, 20);
        Weapon rayGun = new Weapon("ray gun", 70, 40);

        public void WeaponAttack(int weaponAttackPower, int opposingHealthLevel, int opposingEnergyLevel, int energyDeduction)
        {
            opposingHealthLevel -= weaponAttackPower;
            opposingEnergyLevel -= energyDeduction;

        }
    }
}
