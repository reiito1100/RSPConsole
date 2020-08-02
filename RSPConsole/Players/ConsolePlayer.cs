using RSPConsole.Enums;
using RSPConsole.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RSPConsole.Players
{
    /// <summary>
    /// コンソールから操作するプレイヤークラス
    /// </summary>
    class ConsolePlayer : IPlayer
    {
        private string name { get; set; }

        public ConsolePlayer(string playerName)
        {
            name = playerName;
        }

        public RSPType ChoiceRSP()
        {
            Console.WriteLine("「出す手を選択してください (1 : グー  2 : チョキ  3 : パー)」を表示");

            RSPType choice;

            while (true) {
                if (!Enum.TryParse(Console.ReadLine(), out choice) || !Enum.IsDefined(typeof(RSPType), choice))
                {
                    Console.WriteLine("1, 2, 3 のいずれかを入力してください。");
                    continue;
                }
                return choice;
            }
        }

        public string GetName()
        {
            return name;
        }
    }
}
