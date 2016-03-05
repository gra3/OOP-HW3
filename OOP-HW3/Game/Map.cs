using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG.Game
{
    class Map
    {
        //Contains all the tiles for the Map
        public List<List<Tile>> tileArray;

        //Constructor creates a generic map with same "image", entirely passable
        public Map(int mapSize)
        {
            tileArray = new List<List<Tile>> { };

            for (int i = 0; i < mapSize; i++)
            {
                tileArray.Add(new List<Tile> { });
                for (int j = 0; j < mapSize; j++)
                {
                    tileArray[i].Add(new Tile(0, true));
                }
            }
        }
    }
}
