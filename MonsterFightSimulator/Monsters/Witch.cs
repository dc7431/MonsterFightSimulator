﻿using System.Text.RegularExpressions;

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
            
            Console.WriteLine($"Please enter the damage that the Witch can receive with a chance of 40%. Values allowed between {minExtraDamage} and {maxExtraDamage}.");
            this.extraDamage = UserInputManager.CheckValues(minExtraDamage, maxExtraDamage, new Regex("^[1-9]{1}.[0-9]+$"));
        }

        public override void TakeDamage(float damage)
        {
            if (random.NextSingle() <= extraDamageChance)
            {
                damage *= extraDamage;
                Console.WriteLine("Witch took a Critical Hit!");
            }
            base.TakeDamage(damage);
        }
    }
}