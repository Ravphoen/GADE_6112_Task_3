using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_19195640
{
    [Serializable]
    class Goblin : Enemy
    {
        public Goblin(int _posx, int _posy, string _symbol = "G", int _damage = 1, int _hp = 10):base(_posx, _posy, _symbol, _damage, _hp)
        {
            base.weapon = new MeleeWeapon(WeaponType.Dagger, "D");
            base.goldpurse = 1;
        }

        public override movement ReturnMove(movement move = 0)
        {
            int randomdir = r.Next(0, 4);
            move = movement.NoMovement;

            while (move == movement.NoMovement)
            {
                if (randomdir == 0)
                {
                    if (CHARACTERVISION[0] is EmptyTile || CHARACTERVISION[0] is Item)
                    {
                        if (CHARACTERVISION[0] is Item)
                        {
                            PickUp(CHARACTERVISION[0] as Item);
                        }
                        move = movement.Left;
                        POSX--;
                    }
                    else
                    {
                        randomdir = r.Next(0, 4);
                    }
                }
                else if (randomdir == 1)
                {
                    if (CHARACTERVISION[1] is EmptyTile || CHARACTERVISION[1] is Item)
                    {
                        if (CHARACTERVISION[1] is Item)
                        {
                            PickUp(CHARACTERVISION[1] as Item);
                        }
                        move = movement.Up;
                        POSY--;
                    }
                    else
                    {
                        randomdir = r.Next(0, 4);
                    }
                }
                else if (randomdir == 2)
                {
                    if (CHARACTERVISION[2] is EmptyTile || CHARACTERVISION[2] is Item)
                    {
                        if (CHARACTERVISION[2] is Item)
                        {
                            PickUp(CHARACTERVISION[2] as Item);
                        }
                        move = movement.Right;
                        POSX++;
                    }
                    else
                    {
                        randomdir = r.Next(0, 4);
                    }
                }
                else if (randomdir == 3)
                {
                    if (CHARACTERVISION[3] is EmptyTile || CHARACTERVISION[3] is Item)
                    {
                        if (CHARACTERVISION[3] is Item)
                        {
                            PickUp(CHARACTERVISION[3] as Item);
                        }
                        move = movement.Down;
                        POSY++;
                    }
                    else
                    {
                        randomdir = r.Next(0, 4);
                    }
                }
                else
                {
                    move = movement.NoMovement;
                }
            }
            return move;
        }
        //goblin tostring
        public override string ToString()
        {
            string weaponName;
            string output;
            if (weapon == null)
            {
                output = "Bare Handed goblin at [" + POSX + "," + POSY + "] Deals:(" + DAMAGE + ") HP:" + HP + "Has " + GOLDPURSE + "gold";
            }
            else
            {
                output = "Goblin at [" + POSX + "," + POSY + "] Deals:(" + DAMAGE + ") HP:" + HP+ "Equiped with "+weapon.TYPE.ToString() + "Has " + GOLDPURSE + "gold";
            }

            return output;
        }
    }
}
