using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG.Game
{
    //If there were a ton of screens, probably would make more of a hieracrhy

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
}
