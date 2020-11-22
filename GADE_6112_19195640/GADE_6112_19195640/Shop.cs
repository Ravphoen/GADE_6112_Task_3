using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_19195640
{
    class Shop
    {
        private Weapon[] weapons;
        private Random r;
        private Character buyer;

        public Shop(Character _buyer)
        {
            weapons = new Weapon[3];
            //add random weapons (method)
        }

        public Weapon RandomWeapon()
        {
            int randomValue = r.Next(1, 5);
            Weapon weapon = new MeleeWeapon(WeaponType.randomValue);
            
        }

        public bool CanBuy(int num)
        {

        }

        public void Buy(int num)
        {

        }


    }
}
