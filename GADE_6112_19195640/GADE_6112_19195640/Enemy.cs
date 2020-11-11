using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_19195640
{
    [Serializable]
    abstract class Enemy : Character
    {
        protected Random r = new Random();

        public Enemy(int _posx, int _posy, string _symbol, int _damage, int _hp):base(_posx, _posy, _symbol)
        {
            DAMAGE = _damage;
            HP = _hp;
            MAXHP = _hp; 
        }

        public override string ToString()
        {
            return "at ["+POSX+","+POSY+"] ("+DAMAGE+")";
        }
    }
}
