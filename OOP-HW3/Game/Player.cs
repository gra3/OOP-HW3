using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG.Game
{
    public class Player
    {
        public Weapon MainHand { get; set; }
        public Weapon OffHand { get; set; }
        public Armor Armor { get; set; }
        public int Health { get; set; }
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public Map Map { get; set; }

        public Player(Map mapIn)
        {
            MainHand = new Gladius();
            OffHand = new RoundShield();
            Armor = new LeatherArmor();
            Health = 100;
            XCoord = 0;
            YCoord = 0;
            Map = mapIn;
            Map.tileArray[XCoord][YCoord].Content = 'P';
        }

        public void MoveUp(int mapSize)
        {
            if (YCoord - 1 >= 0)
            {
                Map.tileArray[YCoord][XCoord].Content = ' ';
                YCoord--;
                Map.tileArray[YCoord][XCoord].Content = 'P';
            }

            else Console.WriteLine("Move Invalid!");
        }

        public void MoveDown(int mapSize)
        {
            if (YCoord + 1 <= mapSize-1)
            {
                Map.tileArray[YCoord][XCoord].Content = ' ';
                YCoord++;
                Map.tileArray[YCoord][XCoord].Content = 'P';
            }
            else Console.WriteLine("Move Invalid!");
        }

        public void MoveLeft(int mapSize)
        {
            if (XCoord - 1 >= 0)
            {
                Map.tileArray[YCoord][XCoord].Content = ' ';
                XCoord--;
                Map.tileArray[YCoord][XCoord].Content = 'P';
            }
            else Console.WriteLine("Move Invalid!");
        }
        public void MoveRight(int mapSize)
        {
            if (XCoord + 1 <= mapSize-1)
            {
                Map.tileArray[YCoord][XCoord].Content = ' ';
                XCoord++;
                Map.tileArray[YCoord][XCoord].Content = 'P';
            }
            else Console.WriteLine("Move Invalid!");
        }

        public void PrintPos()
        {
            Console.WriteLine("(" + XCoord.ToString() + "," + YCoord.ToString() + ")");
        }
    }
}