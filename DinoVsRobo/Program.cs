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




            Console.WriteLine("Round 1: R100 vs Raptor");
            Dinosaur roundDino = battlefield.herd.raptor;
            Robot roundRobo = new Robot("R100", 100);


            Console.ReadLine();
            Console.WriteLine($"{roundRobo}: HEALTH {roundRobo.health}, ENERGY {roundRobo.powerLevel}\n{roundDino.type}: HEALTH {roundDino.health}, ENERGY {roundDino.energy}\n");



            attacker = roundRobo.name;
            AttackPhase attackPhaseStarter = new AttackPhase(roundRobo, roundDino, attacker);
            attackPhaseStarter.AttackPhaseStarter();


            Console.ReadLine();

}
            
    }
}
