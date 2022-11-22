using System;
using System.Threading;

namespace PokeSharp
{
    class Encounter
    {
        private int PlayerPokemonHP { get; set; } 
        private int WildPokemonHP { get; set; }
        private string PlayerPokemon { get; set; }

        public Encounter(string playerPokemon, int playerPokemonHP, int wildPokemonHP)
        {
            this.PlayerPokemon = playerPokemon;
            this.PlayerPokemonHP = playerPokemonHP;
            this.WildPokemonHP = wildPokemonHP;

            Console.Clear();
            Console.WriteLine("\nCaminhando no matinho procurando shiny...\n\n");

            Thread.Sleep(3000);

            Battle(playerPokemon,playerPokemonHP,wildPokemonHP);
        }

        private void Battle(string pPokemon, int playerHP, int enemyHP)
        {
            string wildPokemon;
            bool captured = false, fainted = false;
            
            wildPokemon = randomPokemon();

            Console.Clear();
            Console.WriteLine($"Um {wildPokemon} selvagem apareceu!\n");
            Thread.Sleep(2000);

            Console.Clear();
            Console.WriteLine($"Vai, {pPokemon}!");
            Thread.Sleep(2000);

            while (fainted == false && captured == false)
            {
                string option;
                int dmgPlayer, dmgEnemy;

                Random rand2 = new Random();
                int attackEnemy = rand2.Next(1,5);

                Console.Clear();
                Console.WriteLine($"{pPokemon} Lv.20 HP:{playerHP}/140  |  {wildPokemon} Lv.20 HP:{enemyHP}/140\n");
                Console.WriteLine($"O que {pPokemon} irá fazer?\n");
                Console.WriteLine("| [1] Quick Attack | [2] Headbutt |");
                Console.WriteLine("| [3] Aerical Ace  | [4] Ice Beam |");
                Console.WriteLine("\n| [5] Capturar o Pokémon selvagem\n");
                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Clear();
                    Console.WriteLine($"{pPokemon} usou Quick Attack.\n");
                    Thread.Sleep(1500);

                    Random randP = new Random();
                    dmgPlayer = randP.Next(15,31);
                    enemyHP -= dmgPlayer;

                    Console.Clear();
                    Console.WriteLine($"{dmgPlayer} de dano no {wildPokemon} selvagem.\n");
                    Console.WriteLine($"{wildPokemon} Lv.20 HP:{enemyHP}/140");
                    Thread.Sleep(3000);
                }
                else if (option == "2")
                {
                    Console.Clear();
                    Console.WriteLine($"{pPokemon} usou Headbutt.\n");
                    Thread.Sleep(1500);

                    Random randP = new Random();
                    dmgPlayer = randP.Next(15,31);
                    enemyHP -= dmgPlayer;

                    Console.Clear();
                    Console.WriteLine($"{dmgPlayer} de dano no {wildPokemon} selvagem.\n");
                    Console.WriteLine($"{wildPokemon} Lv.20 HP:{enemyHP}/140");
                    Thread.Sleep(3000);
                }
                else if (option == "3")
                {
                    Console.Clear();
                    Console.WriteLine($"{pPokemon} usou Aerial Ace.\n");
                    Thread.Sleep(1500);

                    Random randP = new Random();
                    dmgPlayer = randP.Next(15,31);
                    enemyHP -= dmgPlayer;

                    Console.Clear();
                    Console.WriteLine($"{dmgPlayer} de dano no {wildPokemon} selvagem.\n");
                    Console.WriteLine($"{wildPokemon} Lv.20 HP:{enemyHP}/140");
                    Thread.Sleep(3000);
                }
                else if (option == "4")
                {
                    Console.Clear();
                    Console.WriteLine($"{pPokemon} usou Ice Beam.\n");
                    Thread.Sleep(1500);

                    Random randP = new Random();
                    dmgPlayer = randP.Next(15,31);
                    enemyHP -= dmgPlayer;

                    Console.Clear();
                    Console.WriteLine($"{dmgPlayer} de dano no {wildPokemon} selvagem.\n");
                    Console.WriteLine($"{wildPokemon} Lv.20 HP:{enemyHP}/140");
                    Thread.Sleep(3000);
                }
                else if (option == "5")
                {
                    Console.Clear();
                    Console.WriteLine("\nPokébola vai!\n");
                    Thread.Sleep(2000);

                    captured = Capture();
                    
                    if (captured == true)
                    {
                        Console.Clear();
                        Console.WriteLine($"O {wildPokemon} selvagem foi capturado. Vitória!\n");
                        Thread.Sleep(3000);
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"O {wildPokemon} selvagem escapou da Pokébola.\n");
                        Thread.Sleep(3000);
                    }
                }

                if (enemyHP <= 0)
                {
                    Console.Clear();
                    Console.WriteLine($"O {wildPokemon} selvagem desmaiou. Vitória! +30 XP\n");
                    Thread.Sleep(3000);
                    break;
                }

                if (attackEnemy == 1)
                {
                    Console.Clear();
                    Console.WriteLine($"O {wildPokemon} selvagem usou Feint Attack.\n");
                    Thread.Sleep(1500);

                    Random randE = new Random();
                    dmgEnemy = randE.Next(15,31);
                    playerHP -= dmgEnemy;

                    if (playerHP < 0)
                        playerHP = 0;

                    Console.Clear();
                    Console.WriteLine($"{dmgEnemy} de dano no {pPokemon}.\n");
                    Console.WriteLine($"{pPokemon} Lv.20 HP:{playerHP}/140");
                    Thread.Sleep(3000);
                }
                else if (attackEnemy == 2)
                {
                    Console.Clear();
                    Console.WriteLine($"O {wildPokemon} selvagem usou Swift.\n");
                    Thread.Sleep(1500);

                    Random randE = new Random();
                    dmgEnemy = randE.Next(15,31);
                    playerHP -= dmgEnemy;

                    if (playerHP < 0)
                        playerHP = 0;

                    Console.Clear();
                    Console.WriteLine($"{dmgEnemy} de dano no {pPokemon}.\n");
                    Console.WriteLine($"{pPokemon} Lv.20 HP:{playerHP}/140");
                    Thread.Sleep(3000);
                }
                else if (attackEnemy == 3)
                {
                    Console.Clear();
                    Console.WriteLine($"O {wildPokemon} selvagem usou Facade.\n");
                    Thread.Sleep(1500);

                    Random randE = new Random();
                    dmgEnemy = randE.Next(15,31);
                    playerHP -= dmgEnemy;

                    if (playerHP < 0)
                        playerHP = 0;

                    Console.Clear();
                    Console.WriteLine($"{dmgEnemy} de dano no {pPokemon}.\n");
                    Console.WriteLine($"{pPokemon} Lv.20 HP:{playerHP}/140");
                    Thread.Sleep(3000);
                }
                else if (attackEnemy == 4)
                {
                    Console.Clear();
                    Console.WriteLine($"O {wildPokemon} selvagem usou Surf.\n");
                    Thread.Sleep(1500);

                    Random randE = new Random();
                    dmgEnemy = randE.Next(15,31);
                    playerHP -= dmgEnemy;

                    if (playerHP < 0)
                        playerHP = 0;

                    Console.Clear();
                    Console.WriteLine($"{dmgEnemy} de dano no {pPokemon}.\n");
                    Console.WriteLine($"{pPokemon} Lv.20 HP:{playerHP}/140");
                    Thread.Sleep(3000);
                }

                if (playerHP <= 0)
                {
                    Console.Clear();
                    Console.WriteLine($"{pPokemon} desmaiou. Derrota.\n");
                    Thread.Sleep(3000);
                    break;
                }
            }
        }

        private string randomPokemon()
        {
            string rdPoke = "Pokémon";
            int rdNum;
            
            Random rand = new Random();
            rdNum = rand.Next(1,21);

            if (rdNum == 1)
                rdPoke = "Tauros";
            else if (rdNum == 2)
                rdPoke = "Pinsir";
            else if (rdNum == 3)
                rdPoke = "Sandslash";
            else if (rdNum == 4)
                rdPoke = "Pikachu";

            else if (rdNum == 5)
                rdPoke = "Heracross";
            else if (rdNum == 6)
                rdPoke = "Xatu";
            else if (rdNum == 7)
                rdPoke = "Aipom";
            else if (rdNum == 8)
                rdPoke = "Sunflora";

            else if (rdNum == 9)
                rdPoke = "Absol";
            else if (rdNum == 10)
                rdPoke = "Shiftry";
            else if (rdNum == 11)
                rdPoke = "Torkoal";
            else if (rdNum == 12)
                rdPoke = "Kecleon";

            else if (rdNum == 13)
                rdPoke = "Lucario";
            else if (rdNum == 14)
                rdPoke = "Starly";
            else if (rdNum == 15)
                rdPoke = "Spiritomb";
            else if (rdNum == 16)
                rdPoke = "Snover";

            else if (rdNum == 17)
                rdPoke = "Darumaka";
            else if (rdNum == 18)
                rdPoke = "Pansear";
            else if (rdNum == 19)
                rdPoke = "Tranquill";
            else if (rdNum == 20)
                rdPoke = "Sawsbuck";

            return rdPoke;
        }

        private bool Capture()
        {
            int rd;

            Random rand = new Random();
            rd = rand.Next(1,6);

            if (rd == 3)
                return true;
            else
                return false;
        }
    }
}
