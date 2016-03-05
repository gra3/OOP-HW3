using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrahaG.Game
{
    public class Weapon
    {
        protected int Durability { get;  set; }
        protected int Damage { get; set; }

        protected Weapon(int damage)
        {
            Durability = 100;
            Damage = damage;
        }
    }

    class MainHand : Weapon
    {
        protected bool TwoHanded { get; set; }

        protected MainHand(bool isTwoHanded)
            : base(50)
        {
            if (isTwoHanded)
            {
                TwoHanded = true;
                Damage = 110;
            }
            else TwoHanded = false;
        }
    }

    class OffHand : Weapon
    {
        protected uint ArmorRating { get; set; }

        protected OffHand(uint armorRating)
            : base(50)
        {
            ArmorRating = armorRating;
            if (ArmorRating > 0) Damage = 0;    //If it has armor, its a shield, no damage
        }
    }

    class Zweihander : MainHand
    {
        public Zweihander()
            : base(true)
        {
        }
    }

    class Gladius : MainHand
    {
        public Gladius()
            : base(false)
        {
        }
    }

    class RoundShield : OffHand
    {
        public RoundShield()
            : base(70)
        {
        }
    }

    class TowerShield : OffHand
    {
        public TowerShield()
            : base(120)
        {
        }
    }

    //Offhand example that isn't a shield
    class Focus : OffHand
    {
        public Focus()
            : base(0)
        {
        }
    }



}
