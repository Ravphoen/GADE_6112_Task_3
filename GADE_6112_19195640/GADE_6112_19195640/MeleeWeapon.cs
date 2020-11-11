using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_19195640
{
    class MeleeWeapon : Weapon
    {

        public MeleeWeapon(int _posx = 1, int _posy = 1, string Symbol = "P") : base(_posx, _posy, Symbol)
        {

        }

        public override string ToString()
        {
            return "MeleeWeapon at [" + POSX + "," + POSY + "] Deals:(" + DAMAGE + ")";
        }


    }
}
