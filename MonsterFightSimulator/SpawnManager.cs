using System.Text.RegularExpressions;

namespace MonsterFightSimulator
{
    internal class SpawnManager

    {
        private static SpawnManager instance;

        public static SpawnManager Instance { get { return instance ??= new SpawnManager(); } }
        private Regex monsterRegex = new Regex("^slime|witch|bandit|goblin$");


        public readonly List<Monster?> Monsters = new List<Monster?>();


        public void SpawnMonster(Monster monster) => Monsters.Add(monster);
        public void RemoveMonster(Monster monster) => Monsters.Remove(monster);

        public void SpawnMonsters()
        {
            List<Monster> monsters = new List<Monster>();
            for (int i = 0; i < 2; i++)
            {
                if (i > 0)
                    monsters.Add(InternalSpawnMonster(i + 1, monsters.First()));
                else
                    monsters.Add(InternalSpawnMonster(i + 1));
            }
            Console.Clear();
        }
        
        public void ClearMonsters() => Monsters.Clear();

        private Monster InternalSpawnMonster(int monsterIdx, Monster firstMonster = null)
        {
            Console.Clear();
            Regex monstReg = monsterRegex;
            if (firstMonster != null)
                monstReg = new Regex(monstReg.Replace(firstMonster.GetType().Name.ToLower(), ""));
            Monster m;
            Console.WriteLine($"Enter the name of your {monsterIdx}. monster: witch, goblin, slime, bandit");
            string input = UserInputManager.WaitForInput(Console.ReadLine(), monstReg).ToLower();
            if (firstMonster != null)
            {
                while (input == firstMonster.GetType().Name.ToLower())
                {
                    Console.WriteLine($"You can't choose the same monster as your first monster. Please choose another monster.");
                    input = UserInputManager.WaitForInput(Console.ReadLine(), monstReg).ToLower();
                }
            }
            switch (input)
            {
                case "witch":
                    m = new Witch(1.1f, 3);
                    break;
                case "goblin":
                    m = new Goblin();
                    break;
                case "slime":
                    m = new Slime();
                    break;
                case "bandit":
                    m = new Bandit();
                    break;
                default:
                    m = default;
                    break;
            }
            SpawnManager.instance.SpawnMonster(m);
            return m;
        }
    }
}
