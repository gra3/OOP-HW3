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

        public Player()
        {
            MainHand = new Gladius();
            OffHand = new RoundShield();
            Armor = new LeatherArmor();
            Health = 100;
            XCoord = 0;
            YCoord = 0;
        }

        public void MoveUp(int mapSize)
        {
            if (YCoord - 1 >= 0) YCoord--;
            else Console.WriteLine("Move Invalid!");
        }

        public void MoveDown(int mapSize)
        {
            if (YCoord + 1 <= mapSize) YCoord++;
            else Console.WriteLine("Move Invalid!");
        }

        public void MoveLeft(int mapSize)
        {
            if (XCoord - 1 >= 0) XCoord--;
            else Console.WriteLine("Move Invalid!");
        }
        public void MoveRight(int mapSize)
        {
            if(XCoord+1<=mapSize) XCoord++;
            else Console.WriteLine("Move Invalid!");
        }

        public void PrintPos()
        {
            Console.WriteLine("(" + XCoord.ToString() + "," + YCoord.ToString() + ")");
        }
    }
}