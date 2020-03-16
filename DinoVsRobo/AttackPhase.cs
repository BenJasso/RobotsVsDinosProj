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

            do
                while (roundDino.health > 0 && roundRobo.health > 0)
                {

                    if (attacker == roundRobo.name && roundRobo.powerLevel > 0)
                    {
                        Console.WriteLine($"{roundRobo.name} press enter to attack!");
                        roundDino.health = roundDino.health - roundRobo.weaponPower;
                        roundRobo.powerLevel = roundRobo.powerLevel - roundRobo.energyCost;

                        Console.ReadLine();
                        Console.WriteLine($"{roundRobo.name}: HEALTH {roundRobo.health}, ENERGY {roundRobo.powerLevel}\n{roundDino.type}: HEALTH {roundDino.health}, ENERGY {roundDino.energy}\n");

                        attacker = roundDino.type;


                    }
                    else if (attacker == roundDino.type && roundDino.energy > 0)
                    {
                        Console.WriteLine($"{roundDino.type} attack by selecting an attack!\n1) Massive Chomp: PWR 75, ENG COST 50\n2) Massive Stomp: PWR 55, ENG 30\n3) Tail Swipe: PWR 30, ENG 15");
                        if (Console.ReadLine() == "1")
                        {
                            roundDino.attackPower = 75;
                            roundDino.attackCost = 50;


                            roundRobo.health -= roundDino.attackPower;
                            roundDino.energy -= roundDino.attackCost;

                        }
                        else if (Console.ReadLine() == "2")
                        {
                            roundDino.attackPower = 55;
                            roundDino.attackCost = 30;


                            roundRobo.health -= roundDino.attackPower;
                            roundDino.energy -= roundDino.attackCost;
                        }
                        else if (Console.ReadLine() == "3")
                        {
                            roundDino.attackPower = 30;
                            roundDino.attackCost = 15;


                            roundRobo.health -= roundDino.attackPower;
                            roundDino.energy -= roundDino.attackCost;
                        }


                        attacker = roundRobo.name;
                        Console.WriteLine($"{roundRobo.name}: HEALTH {roundRobo.health}, ENERGY {roundRobo.powerLevel}\n{roundDino.type}: HEALTH {roundDino.health}, ENERGY {roundDino.energy}\n");
                    }
                    if (roundDino.health <= 0 && roundDino.type == battlefield.herd.raptor.type)
                    {
                        roundDino = battlefield.herd.teradactol;

                        Console.WriteLine("Raptor Died! Here comes the Teradactol!");
                    }
                    else if (roundRobo.health <= 0 && roundRobo.name == battlefield.fleet.robo2.name)
                    {
                        roundRobo = battlefield.fleet.robo2;

                        Console.WriteLine("R100 Died! Here comes R200!");
                    }
                }
            while (roundDino.health > 0 && roundRobo.health > 0);


        }


    }
}
