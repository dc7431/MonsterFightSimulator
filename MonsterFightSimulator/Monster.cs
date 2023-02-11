using System.Text.RegularExpressions;

namespace MonsterFightSimulator
{
    public abstract class Monster
    {
        protected float health;
        protected float attackDamage;
        protected float healAmount;

        protected float minHealth;
        protected float maxHealth;
        protected float minAttack;
        protected float maxAttack;

        public float Health => health;
        public float AttackDamage => attackDamage;
        public float HealAmount => healAmount;

        public Monster(float minHealth, float maxHealth, float minAttack, float maxAttack)
        {
            this.minHealth = minHealth;
            this.maxHealth = maxHealth;
            this.minAttack = minAttack;
            this.maxAttack = maxAttack;
            
            Console.WriteLine($"Please enter the amount of health for your {this.GetType().Name}. Values allowed between {minHealth} and {maxHealth}.");
            this.health = UserInputManager.CheckValues(minHealth, maxHealth);
            Console.WriteLine($"Please enter the amount of attack for your {this.GetType().Name}. Values allowed between {minAttack} and {maxAttack}.");
            this.attackDamage = UserInputManager.CheckValues(minAttack, maxAttack);
        }
        
        public virtual void Attack(Monster target)
        {
            try
            { 
                target.TakeDamage(AttackDamage);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public virtual void TakeDamage(float damage)
        {
            health -= damage > 0 ? damage : 0;
            Console.WriteLine($"{this.GetType().Name} took {damage} damage. Health: {health}");
            if (health <= 0)
            {
                SpawnManager.Instance.RemoveMonster(this);
            }
        }
    }
}
