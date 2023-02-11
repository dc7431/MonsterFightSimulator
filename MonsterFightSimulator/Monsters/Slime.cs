namespace MonsterFightSimulator
{
    internal class Slime : Monster
    {
        private float critChance = 0.1f;
        private float critMultiplier = 66.6f;
        private Random random = new Random();
        public Slime() : base(10, 200, 1, 100) { }
        public override void Attack(Monster target)
        {
            float damage = attackDamage;
            if (target is Goblin || target is Bandit)
            {
                if (random.NextSingle() <= critChance)
                {
                    damage *= critMultiplier;
                    Console.WriteLine("Slime dealt an extremely amount of damage!");
                }
            }
            target.TakeDamage(damage);
        }
    }
}