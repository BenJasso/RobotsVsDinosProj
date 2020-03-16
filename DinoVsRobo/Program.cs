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
            DinoAttacks dinoAttacks = new DinoAttacks();
           
           
            
            string weaponChoice;
            string attackChoice;
            string attacker;

           


            Console.WriteLine("Round 1: R100 vs Raptor");
            Dinosaur roundDino = battlefield.herd.raptor;
            Robot roundRobo = new Robot("R100", 100);
            
           
            Console.ReadLine();
            update(roundRobo.name, roundDino.type, roundRobo.health, roundDino.health, roundRobo.powerLevel, roundDino.energy);
            
            Console.WriteLine($"{roundRobo.name}: Select the weapon you want to equip .\n1) Electric Blaster: PWR 50, ENG COST 25\n2) Zapper: PWR 20, ENG COST 10  \n3) Ray Gun: PWR 35, ENG COST 15");
            weaponChoice = Console.ReadLine();
            AssignWeapon();
            attacker = roundRobo.name;
            AttackPhase attackPhaseStarter = new AttackPhase(roundRobo, roundDino, attacker);
            attackPhaseStarter.AttackPhaseStarter();


            Console.ReadLine();





          

           






















            void update(string roundRobo1, string roundDino1, int roboHealth, int dinoHealth, int roboEnergy, int dinoEnergy)
            {

                Console.WriteLine($"{roundRobo1}: HEALTH {roboHealth}, ENERGY {roboEnergy}\n{roundDino1}: HEALTH {dinoHealth}, ENERGY {dinoEnergy}\n");



            }





            //void AssignRoundDino()
            //{
            //    if (dinoChoice == "1")
            //    {
            //        roundDino = battlefield.herd.trex;
            //    }
            //    else if (dinoChoice == "2")
            //    {
            //        roundDino = battlefield.herd.teradactol;
            //    }
            //    else if (dinoChoice == "3")
            //    {
            //       roundDino = battlefield.herd.raptor;
            //    }
            //    else
            //    {
            //        roundDino = battlefield.herd.raptor;
            //    }

            //}

            //void AssignRoundRobo()
            //{
            //    if (roboChoice == "1")
            //    {
            //        roundRobo = battlefield.fleet.robo1;
            //    }
            //    else if (roboChoice == "2")
            //    {
            //        roundRobo = battlefield.fleet.robo2;
            //    }
            //    else if (roboChoice == "3")
            //    {
            //        roundRobo = battlefield.fleet.robo3;
            //    }
            //    else
            //    {
            //        roundRobo = battlefield.fleet.robo3;
            //    }

            //}
            void AssignWeapon()
            {


                if (weaponChoice == "1")
                {
                    roundRobo.weaponName = gameWeaponList.electricBlaster.name;
                    roundRobo.weaponPower = gameWeaponList.electricBlaster.attackPower;
                    roundRobo.energyCost = gameWeaponList.electricBlaster.energyCost;
                }
                else if (weaponChoice == "2")
                {
                    roundRobo.weaponName = gameWeaponList.zapper.name;
                    roundRobo.weaponPower = gameWeaponList.zapper.attackPower;
                    roundRobo.energyCost = gameWeaponList.zapper.energyCost;
                }
                else if (weaponChoice == "3")
                {
                    roundRobo.weaponName = gameWeaponList.rayGun.name;
                    roundRobo.weaponPower = gameWeaponList.rayGun.attackPower;
                    roundRobo.energyCost = gameWeaponList.rayGun.energyCost;
                }
                else
                {
                    roundRobo.weaponName = gameWeaponList.rayGun.name;
                    roundRobo.weaponPower = gameWeaponList.rayGun.attackPower;
                    roundRobo.energyCost = gameWeaponList.rayGun.energyCost;
                }

                //}
                //void AssignAttack()
                //{


                //    if (weaponChoice == "1")
                //    {
                //        roundDino.attackName = dinoAttacks.massiveChomp.attackName;
                //        roundDino.attackPower = dinoAttacks.massiveChomp.attackPower;
                //    }
                //    else if (weaponChoice == "2")
                //    {
                //        roundDino.attackName = dinoAttacks.massiveStomp.attackName;
                //        roundDino.attackPower = dinoAttacks.massiveStomp.attackPower;
                //    }
                //    else if (weaponChoice == "3")
                //    {
                //        roundDino.attackName = dinoAttacks.tailSwipe.attackName;
                //        roundDino.attackPower = dinoAttacks.tailSwipe.attackPower;
                //    }
                //    else
                //    {
                //        roundDino.attackName = dinoAttacks.tailSwipe.attackName;
                //        roundDino.attackPower = dinoAttacks.tailSwipe.attackPower;
                //    }
                //}


                //Console.WriteLine(battlefield.herd.trex.type);
                //Console.ReadLine();






            }
            }
    }
}
