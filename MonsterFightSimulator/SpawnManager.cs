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
            for (int i = 0; i < 2; i++)
            {
                InternalSpawnMonster(i + 1);
            }
            Console.Clear();
        }

        private void InternalSpawnMonster(int monsterIdx, Monster firstMonster = null)
        {
            Console.Clear();
            Regex monstReg = monsterRegex;
            if (firstMonster != null)
                monstReg = new Regex(monstReg.Replace(firstMonster.GetType().Name.ToLower(), ""));
            Monster m;
            Console.WriteLine($"Select your type of monster for monster {monsterIdx}: witch, goblin, slime, bandit");
            switch (UserInputManager.WaitForInput(Console.ReadLine(), monstReg))
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
        }
    }
}
