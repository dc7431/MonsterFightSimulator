namespace MonsterFightSimulator
{
    internal class SpawnManager
    {

        public static readonly SpawnManager Instance = new SpawnManager();
        public static readonly List<Monsters?> Monsters = new List<Monsters?>();

        

       
        public void SpawnMonsters()
        {
            for (int i = 1; i <= 1; i++)
            {
                bool isSpawning = true;
                while (isSpawning)
                {
                    Thread.Sleep(500);

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\n To Spawn a Monster: Press 1 for Goblin," +
                       " 2 for Witch, 3 for Teachers, 4 for Slime, or F for finishing the spawning ");
                    ConsoleKey key = Console.ReadKey(true).Key;
                    switch (key)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            Goblin goblin = (new Goblin(InputValue(100, 10, "Health"),
                                InputValue(50, 1, "Attack"),
                                InputValue(50, 5, "Heal")));
                            Monsters.Add(goblin);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Summoned a Goblin With " + goblin.Health + " HP, " + goblin.AttackDamage + " ATK & " + goblin.HealAmount +
                            " HA.");

                            Thread.Sleep(500);

                            break;

                          

                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            Witch witch = (new Witch(InputValue(180, 10, "Health"),
                                InputValue(70, 1, "Attack"),
                                InputValue(50, 5, "Heal")));
                            Monsters.Add(witch);
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine(" Spawned a Witch With " + witch.Health + " HP, " + witch.AttackDamage + " ATK & " + witch.HealAmount +
                             " HA.");

                            Thread.Sleep(500);

                            break;


                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                            Teachers teachers = (new Teachers(InputValue(160, 10, "Health"),
                                InputValue(60, 1, "Attack"),
                                InputValue(50, 5, "Heal")));
                            Monsters.Add(teachers);
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Spawned a Teachers With " + teachers.Health + " HP, " + teachers.AttackDamage + " ATK & " + teachers.HealAmount +
                            " HA.");

                            Thread.Sleep(500);

                            break;

                            

                        case ConsoleKey.D4:
                        case ConsoleKey.NumPad4:
                            Slime slime = (new Slime(InputValue(200, 10, "Health"),
                                InputValue(100, 1, "Attack"),
                                InputValue(50, 5, "Heal")));
                            Monsters.Add(slime);
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Spawned a Slime With " + slime.Health + " HP, " + slime.AttackDamage + " ATK & " + slime.HealAmount +
                           " HA.");

                             Thread.Sleep(500);

                            break;

                            

                        case ConsoleKey.F:
                            isSpawning = false;
                            break;




                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(" Just No\nPlease Try Again ");
                            break;
                    }
                }
            }
        }

        private float InputValue(float maxRange, float minRange, string statName)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" Input a value for " + statName + ", Which is between " + minRange + " and " + maxRange);


            while (true)
            {
                if(float.TryParse(Console.ReadLine(), out float value))
                {
                    if(value >= minRange && value <= maxRange)
                        return value;
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Are you stupid? Try again");

            }
        }
    }
}
