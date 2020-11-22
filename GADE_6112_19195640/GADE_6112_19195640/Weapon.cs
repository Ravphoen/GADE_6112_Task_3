using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_19195640
{
    abstract class Weapon : Item
    {
        //variables
        protected int Damage;
        protected int Range;       
        protected int Durability;
        protected int Cost;
        protected WeaponType Type;
        protected string Symbol;
        protected string typeWeapon;
        
        //properties (accessors)
        public int DAMAGE
        {
            get { return Damage; }
            set { Damage = value; }
        }
        public int RANGE
        {
            get { return Range; }
            set { Range = value; }
        }
        public int DURABILITY
        {
            get { return Durability; }
            set { Durability = value; }
        }
        public int COST
        {
            get { return Cost; }
            set { Cost = value; }
        }
        public WeaponType TYPE
        {
            get { return Type; }
            set { Type = value; }
        }
        public string SSYMBOL
        {
            get { return Symbol; }
            set { Symbol = value; }
        }

        public Weapon(string Symbol, int _posx = 1, int _posy =  1) : base(_posx, _posy, Symbol)
        {
            
        }
    }
}
