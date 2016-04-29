using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG.Game
{
    public class GameScreen : Screen
    {
        public Map Map { get; set; }

        public Player Player { get; set; }

        public Output Output { get; set; }

        public GameScreen(Map mapIn, Player playerIn, Output outputIn)
            : base()
        {
            Map = mapIn;
            Player = playerIn;
            Output = outputIn;
        }

        public override void Draw()
        {
            Output.Draw(Map);
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
