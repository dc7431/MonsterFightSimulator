namespace MonsterFightSimulator
{
    public class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Booting Up...");
            //Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Welcome to HELL!!!");
            //Thread.Sleep(2000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("Begin");
            Thread.Sleep(5000);
            Console.Clear();

            FightManager.Instance.StartBattle();
        }
    }
}