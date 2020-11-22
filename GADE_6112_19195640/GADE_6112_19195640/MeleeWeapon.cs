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
            //pointless
            //if (Type == WeaponType.Dagger)
            //{
            //    MeleeWeaponType = MeleeWeapons.Dagger;
            //}
            //if (Type == WeaponType.LongSword)
            //{
            //    MeleeWeaponType = MeleeWeapons.LongSword;
            //}

            weaponType = Type;

        }

        public WeaponType weaponType;

        public override string ToString()
        {
            return "MeleeWeapon at [" + POSX + "," + POSY + "] Deals:(" + DAMAGE + ")";
        }
    }
}
