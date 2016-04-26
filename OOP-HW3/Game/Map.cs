using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AbrahaG.Game
{
    public class Map
    {
        //Contains all the tiles for the Map
        public List<List<Tile>> tileArray;

        public int MapSize { get; set; }

        //Constructor creates a generic map with same "image", entirely passable
        public Map(int mapSize)
        {
            MapSize = mapSize;
            tileArray = new List<List<Tile>> { };

            for (int i = 0; i < MapSize; i++)
            {
                tileArray.Add(new List<Tile> { });
                for (int j = 0; j < MapSize; j++)
                {
                    tileArray[i].Add(new Tile(0, true));
                }
            }
        }

        public void Draw()
        {
            System.Console.Write('_');
            for (int i = 0; i < tileArray.Count; i++) System.Console.Write('_');
            System.Console.Write('_');
            System.Console.WriteLine();

            for (int i = 0; i < tileArray.Count; i++)
            {
                System.Console.Write("|");
                for (int j = 0; j < tileArray.Count; j++)
                {
                    System.Console.Write(tileArray[i][j].Content);
                }
                System.Console.WriteLine("|");
            }

            System.Console.Write('_');
            for (int i = 0; i < tileArray.Count; i++) System.Console.Write('_');
            System.Console.Write('_');
            System.Console.WriteLine();
        }
    }
}