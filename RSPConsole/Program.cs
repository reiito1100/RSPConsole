using System;

namespace RSPConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            { 
                RSPGame();
                Console.WriteLine("\n\n---------------------------------------------\n\n");
            }
        }

        static void RSPGame()
        {
            bool finished = false;
            while (!finished)
            {
                Console.WriteLine("「出す手を選択してください (1 : グー  2 : チョキ  3 : パー)」を表示");

                RSPType player;
                if (!Enum.TryParse(Console.ReadLine(), out player) || !Enum.IsDefined(typeof(RSPType), player))
                {
                    Console.WriteLine("不正です");
                    continue;
                }
                RSPType cpu = (RSPType)new Random().Next(1, 4);

                Console.WriteLine($"じゃんけん結果：\n\tあなた\t: {player}\n\tCPU\t: {cpu}");

                // あいこ
                if (player == cpu)
                {
                    Console.WriteLine("あいこです");
                    continue;
                }
                // プレイヤーの勝ち
                if (IsWinner(player, cpu))
                {
                    Console.WriteLine("あなたの勝ちです");
                    finished = true;
                }
                // プレイヤーの負け
                if (IsWinner(cpu, player))
                {
                    Console.WriteLine("あなたの負けです");
                    finished = true;
                }
            }
        }

        static bool IsWinner(RSPType p, RSPType opponent)
        {
            return (p == RSPType.パー && opponent == RSPType.グー) ||
                (p == RSPType.グー && opponent == RSPType.チョキ) ||
                (p == RSPType.チョキ && opponent == RSPType.パー);
        }
    }
    enum RSPType
    {
        グー = 1,
        チョキ,
        パー,
    }
}
