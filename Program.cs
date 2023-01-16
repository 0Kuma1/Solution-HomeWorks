namespace Solution_HomeWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PPO
            #region PPO
            Console.WriteLine("Write lenght and height:");
            Console.Write("Lenght: ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Height: ");
            int h = int.Parse(Console.ReadLine());
            PPO ppo = new PPO(l, h);
            Console.WriteLine($"Press 1 to start fight");
            if(Console.ReadKey().Key == ConsoleKey.D1)
            {
                ppo.StartFight();
            }
            #endregion
            //ENDPPO
        }
    }
}