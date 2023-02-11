namespace MonsterFightSimulator
{
    internal class FightManager
    {
        public static readonly FightManager Instance = new FightManager();

        public void StartBattle()
        {   
            List<Monster?> monsters = SpawnManager.Instance.Monsters;

            int j = 0; //TODO: took this out of the loop
            while (monsters.Count > 1)
            {
                for(int i = 0; i < monsters.Count; i++)
                {
                    monsters[i]?.Attack(i != monsters.Count - 1 ? monsters[i + 1] : monsters[0]);
                }
                j++;
                if (j > 200)
                    break;
            }
            Console.ReadLine();
        }
    }
}