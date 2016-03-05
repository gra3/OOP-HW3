using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG.Game
{
    class Player
    {
        public Weapon MainHand { get; set; }
        public Weapon OffHand { get; set; }
        public Armor Armor { get; set; }
        public int Health { get; set; }

        Player()
        {
            MainHand = new Gladius();
            OffHand = new RoundShield();
            Armor = new LeatherArmor();
            Health = 100;
        }
    }
}