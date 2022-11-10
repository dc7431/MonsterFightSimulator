namespace MonsterFightSimulator
{
    internal class FightManager
    {
        public static readonly FightManager Instance = new FightManager();

        public void StartBattle()
        {
            List<Monsters?> monsters = SpawnManager.Monsters;

            while(monsters.Count > 1)
            {

                int j = 0;
                for(int i = 0; i < monsters.Count; i++)
                {
                    monsters[i]?.Attack(i != monsters.Count - 1 ? monsters[i + 1] : monsters[0]);   //vereinfachen
                }
                j++;
                if (j > 200)
                    break;  //break if no monster dies text
            }
            Console.ReadLine();
        }
    }
}