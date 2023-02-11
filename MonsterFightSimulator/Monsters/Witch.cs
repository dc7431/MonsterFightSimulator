using System.Text.RegularExpressions;

namespace MonsterFightSimulator
{
    public class Witch : Monster
    {
        private float extraDamage;
        private float minExtraDamage;
        private float maxExtraDamage;

        public Witch(float minExtraDamage, float maxExtraDamage) : base(10, 180, 1, 70)
        {
            this.minExtraDamage = minExtraDamage;
            this.maxExtraDamage = maxExtraDamage;
        }
        
        public float ReceivesMoreDamage() //TODO: use this in override TakeDamage
        {
            return (float)(this.Health * 0.4);
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