using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG.Game
{
    public class GameState
    {
        public GameState(int mapSize)
        {
            Map = new Map(mapSize);
            Player = new Player(Map);
            Enemy = new Enemy("Boar", mapSize);

        }

        public bool IsDone
        {
            get;
            internal set;
        }

        public Map Map { get; set; }

        public Player Player { get; set; }

        public Enemy Enemy { get; set; }

        public void Loop()
        {

            for (; ; )
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            Player.MoveUp(Map.MapSize);
                            break;
                        case ConsoleKey.DownArrow:
                            Player.MoveDown(Map.MapSize);
                            break;
                        case ConsoleKey.LeftArrow:
                            Player.MoveLeft(Map.MapSize);
                            break;
                        case ConsoleKey.RightArrow:
                            Player.MoveRight(Map.MapSize);
                            break;
                    }
                    Player.PrintPos();
                    Map.Draw();
                }
            }


        }

    }
}
