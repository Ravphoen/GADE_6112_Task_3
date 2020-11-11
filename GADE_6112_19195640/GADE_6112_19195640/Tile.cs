using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_19195640
{
    [Serializable]
   
    abstract class Tile
    {
        protected int posx;
        protected int posy;
        protected string symbol;

        //properties
        public int POSX
        {
            get { return posx; }
            set { posx = value; }
        }
        public int POSY
        {
            get { return posy; }
            set { posy = value; }
        }
        public string SYMBOL
        {
            get { return symbol; }
        }

        //constructor
        public Tile(int _posx, int _posy, string _symbol)
        {
            posx = _posx;
            posy = _posy;
            symbol = _symbol;
        }
    }
}
