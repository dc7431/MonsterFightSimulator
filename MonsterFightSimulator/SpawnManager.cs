namespace MonsterFightSimulator
{
    internal class SpawnManager

    {
    private static SpawnManager instance;

    public static SpawnManager Instance { get { return instance ??= new SpawnManager(); } }


    public readonly List<Monster?> Monsters = new List<Monster?>();


    public void SpawnMonster(Monster monster) => Monsters.Add(monster);
    public void RemoveMonster(Monster monster) => Monsters.Remove(monster);
    }
}
