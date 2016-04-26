using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG.Game
{
    //If there were a ton of screens, probably would make more of a hieracrhy
    
    //Multiple classes in one file for space reasons.

    public abstract class Screen
    {
        public List<string> Options;

        public Screen()
        {
        }

        public abstract void Draw();

        public abstract void OnUp(object source, EventArgs args);
        public abstract void OnDown(object source, EventArgs args);
        public abstract void OnLeft(object source, EventArgs args);
        public abstract void OnRight(object source, EventArgs args);

        public void AttachInput(Input inputIn)
        {
            inputIn.Up += OnUp;
            inputIn.Down += OnDown;
            inputIn.Left += OnLeft;
            inputIn.Right += OnRight;
        }

        public void DetachInput(Input inputIn)
        {
            inputIn.Up -= OnUp;
            inputIn.Down -= OnDown;
            inputIn.Left -= OnLeft;
            inputIn.Right -= OnRight;
        }
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

        public override void OnUp(object source, EventArgs args)
        {
            throw new NotImplementedException();
        }

        public override void OnDown(object source, EventArgs args)
        {
            throw new NotImplementedException();
        }

        public override void OnLeft(object source, EventArgs args)
        {
            throw new NotImplementedException();
        }

        public override void OnRight(object source, EventArgs args)
        {
            throw new NotImplementedException();
        }
    }

    public class GameScreen : Screen
    {
        public Map Map {get; set;}

        public Player Player { get; set; }

        public GameScreen(Map mapIn, Player playerIn)
            : base()
        {
            Map = mapIn;
            Player = playerIn;
        }

        public override void Draw()
        {
            System.Console.Clear();
            Map.Draw();
        }

        public override void OnUp(object source, EventArgs args)
        {
            Player.MoveUp(Map.MapSize);
        }

        public override void OnDown(object source, EventArgs args)
        {
            Player.MoveDown(15);
        }

        public override void OnLeft(object source, EventArgs args)
        {
            Player.MoveLeft(Map.MapSize);
        }

        public override void OnRight(object source, EventArgs args)
        {
            Player.MoveRight(Map.MapSize);
        }
    }
}
