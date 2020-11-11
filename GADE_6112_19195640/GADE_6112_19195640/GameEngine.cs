using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
using System.Windows.Forms;

namespace GADE_6112_19195640
{
    public enum movement
    {
        NoMovement,
        Up,
        Down,
        Left,
        Right
    }
    public enum TileType
    {
        Hero,
        Enemy,
        Gold,
        Weapon
    }

    public enum WeaponType
    {
        Dagger,
        LongSword
    }

    class GameEngine
    {
        private Map m = new Map(10, 20, 10, 20, 5, 3 );

        public Map M
        {
            get { return m; }
            set { m = value; }
        }
        public bool MovePlayer(movement direction)
        {
            if (m.PLAYER.ReturnMove(direction) == movement.NoMovement)
            {
                return false;
            }
            else
            {
                Item P_item = m.GetItemAtPosition(m.PLAYER.POSX, m.PLAYER.POSY);
                if (P_item != null)
                {
                    m.PLAYER.PickUp(P_item);
                }
                return true;
            }
        }
        public override string ToString()
        {
            string map = "";
            for (int i = 0; i < m.MapWidth; i++)
            {
                for (int j = 0; j < m.MapHeight; j++)
                {
                    map += m.map[i, j].SYMBOL + " ";
                }
                map += "\n";
            }
            //map += m.map[0, 0].SYMBOL;
            return map;
        }
        public void UpdateEnemies()
        {
            movement movetemp;
            m.UpdateVision();
            foreach (Enemy e in m.enemies)
            {
                m.UpdateVision();
                movetemp = e.ReturnMove();
                if (e is Goblin)
                {
                    if (e.CheckRange(m.PLAYER))
                    {
                        e.Attack(m.PLAYER);
                    }
                }
                else if (e is Mage)
                {
                    if (e.CheckRange(m.PLAYER))
                    {
                        e.Attack(m.PLAYER);
                    }
                    for (int i = 0; i < m.enemies.Length; i++)
                    {
                        if (m.enemies[i].POSX != e.POSX && m.enemies[i].POSY != e.POSY)
                        {
                            if (e.CheckRange(m.enemies[i]))
                            {
                                e.Attack(m.enemies[i]);
                            }
                        }
                    }
                }
                m.UpdateMap();
            }
            
        }       
        public void EnemyAttack()
        {
            m.UpdateMap();
            foreach (Enemy e in m.enemies)
            {
                if (e is Goblin)
                {
                    if (e.CheckRange(m.PLAYER))
                    {
                        e.Attack(m.PLAYER);
                    }
                }
                else if (e is Mage)
                {
                    if (e.CheckRange(m.PLAYER))
                    {
                        e.Attack(m.PLAYER);
                    }
                    for (int i = 0; i < m.enemies.Length; i++)
                    {
                        if (m.enemies[i].POSX != e.POSX && m.enemies[i].POSY != e.POSY)
                        {
                            if (e.CheckRange(m.enemies[i]))
                            {
                                e.Attack(m.enemies[i]);
                            }
                        }
                    }
                }
            }
            
        }
        public void Save()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("Save.dat", FileMode.Create,FileAccess.Write,FileShare.None);

            try
            {
                using (fs)
                {
                    bf.Serialize(fs,m);
                }
                MessageBox.Show("Save successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Load()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("Save.dat", FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                using (fs)
                {
                    Map mp = (Map)bf.Deserialize(fs);
                    m = mp;
                }
                m.UpdateMap();
                MessageBox.Show("Load Successful");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
