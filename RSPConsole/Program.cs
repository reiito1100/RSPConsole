using RSPConsole.Enums;
using RSPConsole.Players;
using System;

namespace RSPConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            ConsolePlayer consolePlayer = new ConsolePlayer("あなた");
            CpuPlayer cpuPlayer = new CpuPlayer("CPU");

            Referee referee = new Referee();

            while (true)
            {
                referee.Judge(consolePlayer, cpuPlayer);
                Console.WriteLine("\n\n---------------------------------------------\n\n");
            }
        }
    }

}
