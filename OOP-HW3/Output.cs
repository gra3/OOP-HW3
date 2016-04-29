using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG.Game
{
    public abstract class Output
    {
        public Output()
        {
        }

        public abstract void Draw(Map mapIn);
    }
}
