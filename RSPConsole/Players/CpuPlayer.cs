using RSPConsole.Enums;
using RSPConsole.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RSPConsole.Players
{
    class CpuPlayer : IPlayer
    {
        private string name { get; set; }

        public CpuPlayer(string cpuNname)
        {
            name = cpuNname;
        }

        public RSPType ChoiceRSP()
        {
            return (RSPType)new Random().Next(1, 4);
        }

        public string GetName()
        {
            return name;
        }
    }
}
