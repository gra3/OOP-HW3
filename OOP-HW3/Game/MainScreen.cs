using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG.Game
{
    public class MainScreen : Screen
    {
        public MainScreen()
            : base()
        {
            Options = new List<string> {"New Game - Any key",
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
}
