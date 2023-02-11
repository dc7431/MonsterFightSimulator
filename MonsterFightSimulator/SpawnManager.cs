namespace MonsterFightSimulator
{
    internal class SpawnManager
    {
        private static SpawnManager instance;
        public static SpawnManager Instance { get { return instance ??= new SpawnManager(); } }

        public readonly List<Monster?> Monsters = new List<Monster?>();

        
        public void SpawnMonster(Monster monster) => Monsters.Add(monster);
        public void RemoveMonster(Monster monster) => Monsters.Remove(monster);
       
        public void SpawnMonsters()
        {
            
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
