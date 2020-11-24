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
            weapons[0] = RandomWeapon();
            weapons[1] = RandomWeapon();
            weapons[2] = RandomWeapon();
            weapons[3] = RandomWeapon();
        }

        public Weapon RandomWeapon()
        {
            int randomValue = r.Next(1, 5);
            Weapon weapon;
            switch (randomValue)
            {
                case 1:
                    weapon = new MeleeWeapon(WeaponType.Dagger, "D");
                    break;
                case 2:
                    weapon = new MeleeWeapon(WeaponType.LongSword, "7");
                    break;
                case 3:
                    weapon = new RangedWeapon(WeaponType.Bow, "B");
                    break;
                case 4:
                    weapon = new RangedWeapon(WeaponType.Staff, "S");
                    break;
                default:
                    weapon = new MeleeWeapon(WeaponType.Dagger, "D");
                    break;
            }
            return weapon;

        }
        //can buy check
        public bool CanBuy(int num)
        {
            if (buyer.GOLDPURSE >= num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //buy method
        public void Buy(int num)
        {
            buyer.GOLDPURSE -= weapons[num].COST;
            buyer.PickUp(weapons[num]);
            weapons[num] = RandomWeapon();
        }

        public string DisplayWeapon(int num)
        {
            string output = $"Buy {weapons[num].TYPE.ToString()}, {weapons[num].COST} gold";
            return output;
        }
    }
}
