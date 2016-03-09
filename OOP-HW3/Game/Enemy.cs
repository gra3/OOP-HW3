using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG.Game
{
    public class Enemy
    {
        public int ArmorRating { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }

        public int XCoord { get; set; }
        public int YCoord { get; set; }

        public Enemy(string name, int mapSize)
        {
            Name = name;
            Health = 100;
            ArmorRating = 20;
            Damage = 50;
            XCoord = mapSize / 2;
            YCoord = mapSize / 2;
        }

        public void MoveUp(int mapSize)
        {
            if (YCoord - 1 >= 0) YCoord--;
            else Console.WriteLine("Enemy Move Invalid!");
        }

        public void MoveDown(int mapSize)
        {
            if (YCoord + 1 <= mapSize) YCoord++;
            else Console.WriteLine("Enemy Move Invalid!");
        }

        public void MoveLeft(int mapSize)
        {
            if (XCoord - 1 >= 0) XCoord--;
            else Console.WriteLine("Enemy Move Invalid!");
        }
        public void MoveRight(int mapSize)
        {
            if (XCoord + 1 <= mapSize) XCoord++;
            else Console.WriteLine("Enemy Move Invalid!");
        }
    }
}
