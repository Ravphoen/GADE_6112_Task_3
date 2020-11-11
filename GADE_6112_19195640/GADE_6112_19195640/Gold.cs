using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_19195640
{
    [Serializable]
    class Gold : Item
    {
        private Random r = new Random();

        private int goldAmount;
        public int GOLDAMOUNT
        {
            get { return goldAmount; }
            set { goldAmount = value; }
        }

        public Gold(int _posx, int _posy, string _symbol = "$") : base(_posx, _posy, _symbol)
        {
            goldAmount = r.Next(1,6);
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
