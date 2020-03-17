using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobo
{
    class Program
    {
        static void Main(string[] args)
        {
            WeaponList gameWeaponList = new WeaponList();
            Battlefield battlefield = new Battlefield();
            string attacker;




            Console.WriteLine("Press enter to enter the battlefield and spawn the herd and fleet");
          
            
            Dinosaur roundDino = battlefield.herd.raptor;
            Robot roundRobo = new Robot("R100", 100);
            
            Console.ReadLine();
            Console.WriteLine($"{roundRobo.name}: HEALTH {roundRobo.health}, ENERGY {roundRobo.powerLevel}\nvs\n{roundDino.type}: HEALTH {roundDino.health}, ENERGY {roundDino.energy}\n");



            attacker = roundRobo.name;
            AttackPhase attackPhaseStarter = new AttackPhase(roundRobo, roundDino, attacker);
            attackPhaseStarter.AttackPhaseStarter();


            Console.ReadLine();

}
            
    }
}
