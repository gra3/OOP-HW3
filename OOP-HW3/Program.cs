using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            GameState Game = new GameState(30);
            Game.Loop();
        }
    }
}