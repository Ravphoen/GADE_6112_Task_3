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

        }

        public override movement ReturnMove(movement move = 0)
        {
            int randomdir = r.Next(0, 4);
            move = movement.NoMovement;

            while (move == movement.NoMovement)
            {
                if (randomdir == 0)
                {
                    if (CHARACTERVISION[0] is EmptyTile)
                    {
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
                    if (CHARACTERVISION[1] is EmptyTile)
                    {
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
                    if (CHARACTERVISION[2] is EmptyTile)
                    {
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
                    if (CHARACTERVISION[3] is EmptyTile)
                    {
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
        public override string ToString()
        {
            return "Goblin at [" + POSX + "," + POSY + "] Deals:(" + DAMAGE + ") HP:" + HP;
        }
    }
}
