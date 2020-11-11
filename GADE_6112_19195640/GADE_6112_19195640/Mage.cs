using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_19195640
{
    [Serializable]
    class Mage : Enemy
    {
        public Mage(int _posx, int _posy, string _symbol = "M", int _damage=5, int _hp=5) : base(_posx, _posy, _symbol, _damage, _hp)
        {
            DAMAGE = _damage;
            HP = _hp;
            MAXHP = _hp;
        }

        public override movement ReturnMove(movement move = 0)
        {
            return movement.NoMovement;
        }

        public override bool CheckRange(Character target)
        {
            if (DistanceTo(target) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Mage at [" + POSX + "," + POSY + "] Deals:(" + DAMAGE + ") HP:" + HP;
        }
    }
}
