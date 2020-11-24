using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_19195640
{
    class RangedWeapon : Weapon
    {
        public enum RangedWeapons // I wanted to use a bow and a staff ! Rifles suck !
        {
            Bow,
            Staff
        }

        //public MeleeWeapons MeleeWeaponType;

        public RangedWeapon(WeaponType Type, string Symbol = "P", int _posx = 1, int _posy = 1) : base(Symbol, _posx, _posy)
        {

            if (Type == WeaponType.Bow)
            {
                base.Damage = 4;
                base.Range = 2;
                base.Durability = 4;
                base.Cost = 6;
                base.typeWeapon = "Bow";
                base.Type = WeaponType.Bow;

            }
            if (Type == WeaponType.Staff)
            {
                base.Damage = 5;
                base.Range = 3;
                base.Durability = 3;
                base.Cost = 7;
                base.typeWeapon = "Staff";
                base.Type = WeaponType.Staff;
            }

            weaponType = Type;

        }

        public WeaponType weaponType;

        public override string ToString()
        {
            return "Ranged Weapon at [" + POSX + "," + POSY + "] Deals:(" + DAMAGE + ")";
        }
    }
}
