using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG.Game
{
    public class Game
    {
        public Game()
        {
        }

        public bool IsDone
        {
            get;
            internal set;
        }

        public void Loop()
        {

            for (; ; )
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    Console.Write(key);
                }
            }


        }

    }
}
