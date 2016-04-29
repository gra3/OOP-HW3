using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG.Game
{
    public class ConsoleOutput : Output
    {
        public ConsoleOutput()
            : base()
        {
        }

        public override void Draw(Map mapIn)
        {
            System.Console.Clear();
            System.Console.Write('_');
            for (int i = 0; i < mapIn.tileArray.Count; i++) System.Console.Write('_');
            System.Console.Write('_');
            System.Console.WriteLine();

            for (int i = 0; i < mapIn.tileArray.Count; i++)
            {
                System.Console.Write("|");
                for (int j = 0; j < mapIn.tileArray.Count; j++)
                {
                    System.Console.Write(mapIn.tileArray[i][j].Content);
                }
                System.Console.WriteLine("|");
            }

            System.Console.Write('_');
            for (int i = 0; i < mapIn.tileArray.Count; i++) System.Console.Write('_');
            System.Console.Write('_');
            System.Console.WriteLine();
        }
    }
}
