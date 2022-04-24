//---------------------------------------------------------------//
// Made by OlsonBolson                                           //
// → GitHub: [OlsonBolson](https://github.com/OlsonBolson-C)     //
// → Discord: OlsonBolson#7879                                   //
//---------------------------------------------------------------//

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Fighter_Simulation
    {
        class Program
        {
            static void Main(string[] args)
            {


                Console.WriteLine();
                Console.WriteLine("   Type 1, to choose Elf, and 2, to choose Goblin.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                             Statats                ");
                Console.WriteLine("                   Elf                      Goblin  ");
                Console.WriteLine("       Health:     100                       100    ");
                Console.WriteLine("       Strength:    2                         3     ");
                Console.WriteLine("       Defense:     3                         9     ");
                Console.WriteLine("       Attack:      X                         X     ");
                Console.WriteLine();
                Console.WriteLine("   Attack points are random - from 5 to 10.         ");
                Console.WriteLine("   Given damage points are attack*strength-defence  ");
                Console.WriteLine();
                Console.WriteLine();

                //HEALTH
                int healthPoints1 = 100;
                int healthPoints2 = 100;

                // CHARACTERS
                int character = Convert.ToInt32(Console.ReadLine());
                switch (character)
                {
                    //          ELF
                    case 1:
                        Console.WriteLine("   Chosen chatacter: Elf");
                        Console.WriteLine();
                        Console.WriteLine("   Click ENTER to continue.");
                        Console.WriteLine();
                        Console.ReadKey();

                        Console.WriteLine();
                        Console.WriteLine("   Click ENTER, to attack opponent.");
                        Console.ReadKey();
                        Console.WriteLine();


                        // ATTACK
                        while (healthPoints1 > 0 && healthPoints2 > 0)
                        {
                            int defencePoints1 = 3;
                            int strenghtPoints1 = 2;
                            Random attackPoints1 = new Random();
                            int rndAttackPoints1 = attackPoints1.Next(5, 10);

                            int defencePoints2 = 9;
                            int strenghtPoints2 = 3;
                            Random attackPoints2 = new Random();
                            int rndAttackPoints2 = attackPoints2.Next(5, 10);


                            int damagePoints1 = (rndAttackPoints1 * strenghtPoints1) - defencePoints1;
                            healthPoints2 -= damagePoints1;
                            int damagePoints2 = (rndAttackPoints2 * strenghtPoints2) - defencePoints2;
                            healthPoints1 -= damagePoints2;
                            Console.WriteLine();
                            Console.WriteLine("--------------------------------------------------------------------------");
                            Console.WriteLine($"   You attacked the opponent {damagePoints1}.");
                            Console.WriteLine($"   The opponent has {healthPoints2 } health points.");
                            Console.WriteLine();
                            Console.WriteLine($"   The opponent attacked you with { damagePoints2 } damage points.");
                            Console.WriteLine($"   You have { healthPoints1 } health points.");
                            Console.WriteLine("--------------------------------------------------------------------------");
                            Console.WriteLine();

                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        if (healthPoints1 <= 0 && healthPoints2 <= 0)
                        {
                            Console.WriteLine("DRAW!");
                        }
                        else if (healthPoints1 > 0)
                        {
                            Console.WriteLine("VICTORY!");
                        }
                        else
                        {
                            Console.WriteLine("DEFEAT!");
                        }
                        Console.ReadKey();
                        break;

                    //    GOBLIN
                    case 2:
                        Console.WriteLine("   Chosen chatacter: Goblin");
                        Console.WriteLine();
                        Console.WriteLine("   Click ENTER to continue.");
                        Console.WriteLine();
                        Console.ReadKey();

                        Console.WriteLine();
                        Console.WriteLine("   Click ENTER, to attack opponent.");
                        Console.ReadKey();
                        Console.WriteLine();


                    // ATTACK
                    while (healthPoints1 > 0 && healthPoints2 > 0)
                    {
                        int defencePoints1 = 3;
                        int strenghtPoints1 = 2;
                        Random attackPoints1 = new Random();
                        int rndAttackPoints1 = attackPoints1.Next(5, 10);

                        int defencePoints2 = 9;
                        int strenghtPoints2 = 3;
                        Random attackPoints2 = new Random();
                        int rndAttackPoints2 = attackPoints2.Next(5, 10);


                        int damagePoints1 = (rndAttackPoints1 * strenghtPoints1) - defencePoints1;
                        healthPoints2 -= damagePoints1;
                        int damagePoints2 = (rndAttackPoints2 * strenghtPoints2) - defencePoints2;
                        healthPoints1 -= damagePoints2;
                        Console.WriteLine();
                            Console.WriteLine("--------------------------------------------------------------------------");
                            Console.WriteLine($"   You attacked the opponent {damagePoints1}.");
                            Console.WriteLine($"   The opponent has {healthPoints2 } health points.");
                            Console.WriteLine();
                            Console.WriteLine($"   The opponent attacked you with { damagePoints2 } damage points.");
                            Console.WriteLine($"   You have { healthPoints1 } health points.");
                            Console.WriteLine("--------------------------------------------------------------------------");
                            Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    if (healthPoints1 <= 0 && healthPoints2 <= 0)
                        {
                            Console.WriteLine("DRAW!");
                        }
                        else if (healthPoints1 > 0)
                        {
                            Console.WriteLine("VICTORY!");
                        }
                        else
                        {
                            Console.WriteLine("DEFEAT!");
                        }
                        Console.ReadKey();
                        break;
            }
        }
    }
}

//---------------------------------------------------------------//
// Made by OlsonBolson                                           //
// → GitHub: [OlsonBolson](https://github.com/OlsonBolson-C)     //
// → Discord: OlsonBolson#7879                                   //
//---------------------------------------------------------------//
