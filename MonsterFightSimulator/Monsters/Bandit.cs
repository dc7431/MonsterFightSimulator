namespace MonsterFightSimulator
{
    internal class Bandit : Monster
    {
        private Random random = new Random();
        private float evadeChance = 0.2f;

        public Bandit() : base(10, 160, 1, 60) { }
        
        public override void TakeDamage(float damage)
        {
            if (random.NextSingle() <= evadeChance)
            {
                Console.WriteLine("Bandit evaded the attack!");
                return;
            }
            base.TakeDamage(damage);
        }
    }
}