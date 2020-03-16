using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobo
{
    class AttackPhase
    {

        //member variables
       
        public Dinosaur roundDino;
        public Robot roundRobo;
        public string attacker;
        Battlefield battlefield = new Battlefield();
        WeaponList gameWeaponList = new WeaponList();
        public string attackChoice;
        public string weaponChoice;
      




        //constructor

        public AttackPhase(Robot robo, Dinosaur dino, string attacker)
        {
            roundRobo = robo;
            roundDino = dino;
            this.attacker = attacker;
            
            

        }



        //method

        public void AttackPhaseStarter()
        {

                
                while (roundDino.health > 0 && roundRobo.health > 0)
                {

                if (attacker == roundRobo.name && roundRobo.powerLevel > 0)
                {
                    Console.WriteLine($"{roundRobo.name}: Select the number of the weapon you want to attack with or to restore your energy.\n1) Electric Blaster: PWR 50, ENG COST 25\n2) Zapper: PWR 20, ENG COST 10  \n3) Ray Gun: PWR 35, ENG COST 15\n4) Restore Energy: ENG +100\n");
                    weaponChoice = Console.ReadLine();
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
                    else if (weaponChoice == "4")
                    {
                        roundRobo.powerLevel = 100;
                    }
                    else
                    {
                        roundRobo.weaponName = gameWeaponList.rayGun.name;
                        roundRobo.weaponPower = gameWeaponList.rayGun.attackPower;
                        roundRobo.energyCost = gameWeaponList.rayGun.energyCost;
                    }

                    if (roundRobo.powerLevel >= roundRobo.energyCost)
                    {
                        roundDino.health = roundDino.health - roundRobo.weaponPower;
                        roundRobo.powerLevel = roundRobo.powerLevel - roundRobo.energyCost;
                    }
                    else
                    {
                        Console.WriteLine("Sorry you do not have enough energy. You lose your turn.");
                    }

                    Console.WriteLine($"{roundRobo.name}: HEALTH {roundRobo.health}, ENERGY {roundRobo.powerLevel}\n{roundDino.type}: HEALTH {roundDino.health}, ENERGY {roundDino.energy}\n");

                    attacker = roundDino.type;


                }
                else if (attacker == roundDino.type && roundDino.energy >= 0)
                {
                    Console.WriteLine($"{roundDino.type} attack by selecting an attack!\n1) Massive Chomp: PWR 75, ENG COST 50\n2) Massive Stomp: PWR 55, ENG 30\n3) Tail Swipe: PWR 30, ENG 15\n4) Restore Energy: ENG +100\n");
                    attackChoice = Console.ReadLine();
                    if (attackChoice == "1")
                    {
                        roundDino.attackPower = 75;
                        roundDino.attackCost = 50;
                    }
                    else if (attackChoice == "2")
                    {
                        roundDino.attackPower = 55;
                        roundDino.attackCost = 30;



                    }
                    else if (attackChoice == "3")
                    {
                        roundDino.attackPower = 30;
                        roundDino.attackCost = 15;



                    }
                    else if (attackChoice == "4")
                    {
                        roundDino.energy = 100;
                    }
                    if (roundDino.energy >= roundDino.attackCost)
                    {
                        roundRobo.health -= roundDino.attackPower;
                        roundDino.energy -= roundDino.attackCost;
                    }
                    else
                    {
                        Console.WriteLine("Sorry you do not have enough energy. You lose your turn.");
                    }


                    attacker = roundRobo.name;
                    Console.WriteLine($"{roundRobo.name}: HEALTH {roundRobo.health}, ENERGY {roundRobo.powerLevel}\n{roundDino.type}: HEALTH {roundDino.health}, ENERGY {roundDino.energy}\n");
        }
                    if (roundDino.health <= 0 && roundDino.type == battlefield.herd.raptor.type)
                    {
                        roundDino = battlefield.herd.teradactol;
                        attacker = battlefield.herd.teradactol.type;

                        Console.WriteLine("Raptor Died! Here comes the Teradactol!");
                    }
                    else if(roundRobo.health <= 0 && roundRobo.name == battlefield.fleet.robo1.name)
                    {
                        roundRobo = battlefield.fleet.robo2;

                        attacker = battlefield.fleet.robo2.name;

                        Console.WriteLine("R100 Died! Here comes R200!");
                        Console.ReadLine();
                    
                    }
                    if (roundDino.health <= 0 && roundDino.type == battlefield.herd.teradactol.type)
                    {
                        roundDino = battlefield.herd.trex;
                        attacker = battlefield.herd.trex.type;

                        Console.WriteLine("Teradactol Died! Here comes the Teradactol!");
                    }
                    else if (roundRobo.health <= 0 && roundRobo.name == battlefield.fleet.robo2.name)
                    {
                        roundRobo = battlefield.fleet.robo3;

                        attacker = battlefield.fleet.robo3.name;

                        Console.WriteLine("R200 Died! Here comes R200!");
                        Console.ReadLine();

                    }
                }
        }
            
    }


    
}
