using System;
using System.Collections.Generic;
using System.Text;
using RSPConsole.Enums;

namespace RSPConsole.Interface
{
    public interface IPlayer
    {
        /// <summary>
        /// グーチョキパーのいずれかを出す
        /// </summary>
        RSPType ChoiceRSP();

        /// <summary>
        /// プレイヤー名を得る
        /// </summary>
        /// <returns>プレイヤー名</returns>
        string GetName();
    }
}
