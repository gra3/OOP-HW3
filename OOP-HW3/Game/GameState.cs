using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AbrahaG.Game
{
    public class GameState
    {
        public GameState(int mapSize)
        {
            Map = new Map(mapSize);
            Player = new Player(Map);
            Enemy = new Enemy("Boar", mapSize);
            Screen = new MainScreen();
            Input = new ConsoleInput();
        }

        public bool IsDone
        {
            get;
            internal set;
        }

        public Input Input { get; set; }

        public Map Map { get; set; }

        public Player Player { get; set; }

        public Enemy Enemy { get; set; }

        public Screen Screen { get; set; }

        public void Loop()
        {
            Screen.Draw();
            Screen = new GameScreen(Map,Player);
            Screen.AttachInput(Input);
            for (; ; )
            {
                Input.getInput();
                Screen.Draw();
                Thread.Sleep(50); //limit "FPS"
            }


        }

    }
}
