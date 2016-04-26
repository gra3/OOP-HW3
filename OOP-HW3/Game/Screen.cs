using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG.Game
{
    public abstract class Screen
    {
        public List<string> Options;

        public Screen()
        {
        }

        public abstract void Draw();
    }

    public class MainScreen : Screen
    {
        public MainScreen()
            : base()
        {
            Options = new List<string> {"New Game - Any key",
                                        "Load Game - N/A",
                                        "Exit - N/A"};
        }

        public override void Draw()
        {
            for (int i = 0; i < Options.Count; i++)
            {
                System.Console.WriteLine(i.ToString() + ". " + Options[i]);
            }
        }
    }

    public class GameScreen : Screen
    {
        public Map Map {get; set;}

        public GameScreen(Map mapIn)
            : base()
        {
            Map = mapIn;
        }

        public override void Draw()
        {
            System.Console.Clear();
            Map.Draw();
        }
    }
}
