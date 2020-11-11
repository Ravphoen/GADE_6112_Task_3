using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_19195640
{
    [Serializable]
    abstract class Item : Tile
    {
        public Item(int _posx, int _posy, string _symbol) : base(_posx, _posy, _symbol)
        {

        }

        public abstract string ToString();

    }
}
