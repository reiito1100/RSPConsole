using RSPConsole.Enums;
using RSPConsole.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RSPConsole
{
    // 勝負は公平に、審判クラス

    /// <summary>
    /// じゃんけんの試合進行と審判を行うクラス
    /// <para></para>
    /// </summary>
    class Referee
    {
        public void Judge(IPlayer player1, IPlayer player2)
        {
            bool finished = false;

            while (!finished) {

                RSPType p1 = player1.ChoiceRSP();
                RSPType p2 = player2.ChoiceRSP();

                Console.WriteLine($"じゃんけん結果：\n\t{player1.GetName()}\t: {p1}\n\t{player2.GetName()}\t: {p2}");

                // あいこ
                if (p1 == p2)
                {
                    Console.WriteLine("あいこです");
                    continue;
                }
                // p1の勝ち
                if (Compare(p1, p2))
                {
                    Console.WriteLine($"あなたの勝ちです");
                    finished = true;
                }
                // p2の勝ち
                if (Compare(p2, p1))
                {
                    Console.WriteLine($"あなたの負けです");
                    finished = true;
                }
            }
        }

        /// <summary>
        /// pから見た、出した手の比較結果を得る
        /// </summary>
        /// <param name="p"></param>
        /// <param name="opponent">相手が出した手</param>
        /// <returns></returns>
        private static bool Compare(RSPType p, RSPType opponent)
        {
            return (p == RSPType.パー && opponent == RSPType.グー) ||
                (p == RSPType.グー && opponent == RSPType.チョキ) ||
                (p == RSPType.チョキ && opponent == RSPType.パー);
        }
    }
}
