using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG.Game
{
    public abstract class Input
    {
        public Input()
        {
        }

        public delegate void InputEventHandler(object source, EventArgs args);

        public event InputEventHandler Up;
        public event InputEventHandler Down;
        public event InputEventHandler Left;
        public event InputEventHandler Right;

        protected virtual void OnUp()
        {
            if (Up != null)
                Up(this, EventArgs.Empty);
        }

        protected virtual void OnDown()
        {
            if (Down != null)
                Down(this, EventArgs.Empty);
        }

        protected virtual void OnLeft()
        {
            if (Left != null)
                Left(this, EventArgs.Empty);
        }

        protected virtual void OnRight()
        {
            if (Right != null)
                Right(this, EventArgs.Empty);
        }

        public abstract void getInput();
    }

    public class ConsoleInput : Input
    {
        public override void getInput()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        OnUp();
                        break;
                    case ConsoleKey.DownArrow:
                        OnDown();
                        break;
                    case ConsoleKey.LeftArrow:
                        OnLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        OnRight();
                        break;
                }
            }
        }
    }
}
