namespace MonsterFightSimulator
{
    internal class Monsters
    {
        public float Health {  get; private set; }
        public float AttackDamage { get; protected set; }
        public float HealAmount { get; protected set; }


        protected Monsters(float health, float attackDamage, float regenHealth)
        {
            this.Health = health;
            this.AttackDamage = attackDamage;   
            this.HealAmount = regenHealth;
        }


        public void Attack(Monsters? target)
        {
            if (target != null)
            {
                target.TakeDamage(AttackDamage, HealAmount);
            }
            else
            {
                Console.WriteLine(" Error: Target dose not exist!");
            }
        }


        private void TakeDamage(float damage, float heal)
        {
            TimeSpan ts = new TimeSpan(0, 0, 1);

            Random random = new Random();

            int targetChoice = random.Next(0, 2);

            for(int i = 1; i<=1; i++)
            {
                Thread.Sleep(ts);

                 if (targetChoice == 0)
                 {
                   Health -= damage;
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("\n" + this.GetType().Name + " got attacked with " + damage + " damage and now has " + Health + " HP left.");

                    Thread.Sleep(ts);
                 }
                 else
                 {
                   Health += heal;
                   Console.ForegroundColor = ConsoleColor.Green;
                   Console.WriteLine("\n" + this.GetType().Name + " Heals and gains " + heal + " HP and now has " + Health + " HP left.");

                    Thread.Sleep(ts);
                 }
                 if(Health <= 0)
                 {
                   Console.WriteLine( "\n:( " + this.GetType().Name + "The End");
                   Health = 0;
                   SpawnManager.Monsters.Remove(this);
                 }
            }

            


        }
    }
}
