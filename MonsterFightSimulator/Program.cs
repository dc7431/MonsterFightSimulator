using System.Net.Mime;

namespace MonsterFightSimulator
{
    public class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Booting Up...");
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Welcome to HELL!!!");
            Thread.Sleep(2000);
            Console.Clear();
            while (true)
            {
                SpawnManager.Instance.SpawnMonsters();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Beginning battle");
                Thread.Sleep(300);
                Console.Write(".");
                Thread.Sleep(300);
                Console.Write(".");
                Thread.Sleep(300);
                Console.Write(".");
                Thread.Sleep(300);
                Console.Clear();
                FightManager.Instance.StartBattle();

                Console.WriteLine("Press any key to start again or type 'quit' to exit");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;
                else
                {
                    SpawnManager.Instance.ClearMonsters();
                    Console.Clear();
                }
            }
        }
    }
}