using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_19195640
{
    class MeleeWeapon : Weapon
    {
        public enum MeleeWeapons
        {
            Dagger, 
            LongSword
        }
       
        //public MeleeWeapons MeleeWeaponType;

        public MeleeWeapon(WeaponType Type , string Symbol = "P", int _posx = 1, int _posy = 1 ) : base(Symbol, _posx, _posy)
        {
            
            if (Type == WeaponType.Dagger)
            {
                base.Damage = 3;
                base.Range = 1;
                base.Durability = 10;
                base.Cost = 3;
                base.typeWeapon = "Dagger";

            }
            if (Type == WeaponType.LongSword)
            {
                base.Damage = 4;
                base.Range = 1;
                base.Durability = 6;
                base.Cost = 5;
                base.typeWeapon = "Longsword";
            }

            weaponType = Type;

        }

        public WeaponType weaponType;

        public override string ToString()
        {
            return "MeleeWeapon at [" + POSX + "," + POSY + "] Deals:(" + DAMAGE + ")";
        }
    }
}
