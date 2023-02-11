namespace MonsterFightSimulator
{
    internal class FightManager
    {
        private static FightManager instance;

        public static FightManager Instance { get { return instance ??= new FightManager(); } }

        public void StartBattle()
        {   
            List<Monster?> monsters = SpawnManager.Instance.Monsters;

            int j = 0;
            Monster attacking = monsters.First();
            Monster defending = monsters.Last();
            while (monsters.Count > 1)
            {
                attacking.Attack(defending);
                j++;
                if (j > 100)
                    break;
                Thread.Sleep(500);
                (attacking, defending) = (defending, attacking);
            }
            Console.WriteLine($"Battle is over! {monsters.First().GetType().Name} won the battle!");
            Console.WriteLine($"The battle took {j} turns.");
        }
    }
}