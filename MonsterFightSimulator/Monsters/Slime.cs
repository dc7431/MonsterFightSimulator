namespace MonsterFightSimulator
{
    internal class Slime : Monster
    {
        public Slime() : base(10, 200, 1, 100) { }

        public override void TakeDamage(float damage)
        {
            base.TakeDamage(damage);
        }
    }
}