using System.Text.RegularExpressions;

namespace MonsterFightSimulator
{
    public class Witch : Monster
    {
        private float extraDamage;
        private float minExtraDamage;
        private float maxExtraDamage;
        private float extraDamageChance = 0.4f;
        private Random random = new Random();

        public Witch(float minExtraDamage, float maxExtraDamage) : base(10, 180, 1, 70)
        {
            this.minExtraDamage = minExtraDamage;
            this.maxExtraDamage = maxExtraDamage;
        }

        public override void TakeDamage(float damage)
        {
            if (random.NextSingle() <= extraDamageChance)
            {
                damage *= extraDamage;
                Console.WriteLine("Critical Hit");
            }
            base.TakeDamage(damage);
        }

        protected override void Spawn()
        {
            Console.WriteLine($"Please enter the extradamage for your Witch. Values allowed between {minExtraDamage} and {maxExtraDamage}.");
            int minInt = (int)minExtraDamage;
            int maxInt = (int)maxExtraDamage;
            float minFloat = (float)(minExtraDamage - Math.Truncate(minExtraDamage));
            float maxFloat = (float)(maxExtraDamage - Math.Truncate(maxExtraDamage));
            Regex regex = new Regex("^["+minInt+"-"+maxInt+"]{1}.["+minFloat+"-"+maxFloat+"]{3}");
            this.extraDamage = float.Parse(UserInputManager.WaitForInput(Console.ReadLine(), regex));
            base.Spawn();
        }
    }
}