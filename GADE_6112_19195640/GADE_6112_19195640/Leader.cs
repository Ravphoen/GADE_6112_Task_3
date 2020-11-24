using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_19195640
{
    class Leader : Enemy
    {
        public Leader(int _posx, int _posy, string _symbol = "L", int _damage = 2, int _hp = 20) : base(_posx, _posy, _symbol, _damage, _hp)
        {
            base.posx = _posx;
            base.posy = _posy;
            base.symbol = _symbol;
            base.damage = _damage;
            base.hp = _hp;
            
        }

        private Tile leadertarget;

        public Tile LEADERTARGET
        {
            get { return leadertarget; }
            set { leadertarget = value; }
        }
        
        public override movement ReturnMove(movement move = 0)
        {
            movement movement = ChaseMove(move);
            if (movement == movement.NoMovement)
            {
                RandomMove(move);
            }

            return move;
        }
        //random movement method
        public movement RandomMove(movement move = 0)
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
        //chasing method
        public movement ChaseMove(movement move = 0)
        {
            int xposDifference;
            int yposDifference;
            move = movement.NoMovement;           

            xposDifference = base.posx - leadertarget.POSX;
            yposDifference = base.posy - leadertarget.POSY;

            if (Math.Abs(xposDifference) >= Math.Abs(yposDifference))
            {
                if (xposDifference < 0 && CHARACTERVISION[2] is EmptyTile)
                {
                    move = movement.Right;
                    base.posx++;
                }

                if (xposDifference > 0 && CHARACTERVISION[0] is EmptyTile)
                {
                    move = movement.Left;
                    base.posx--;
                }

            }
            if (Math.Abs(yposDifference) > Math.Abs(xposDifference))
            {
                if (yposDifference < 0 && CHARACTERVISION[1] is EmptyTile)
                {
                    move = movement.Up;
                    base.posy++;
                }
                if (yposDifference > 0 && CHARACTERVISION[3] is EmptyTile)
                {
                    move = movement.Down;
                    base.posy--;
                }
            }
            return move;
        }   
    }
}
