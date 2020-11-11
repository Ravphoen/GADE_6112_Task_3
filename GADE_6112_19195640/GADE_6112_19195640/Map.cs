using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_19195640
{
    [Serializable]
    class Map
    {
        private int mapwidth;
        private int mapheight;
        private int enemyamount;

        public int MapWidth
        {
            get { return mapwidth; }
            set { mapwidth = value; }
        }
        public int MapHeight
        {
            get { return mapheight; }
            set { mapheight = value; }
        }
        public int EnemyAmount
        {
            get { return enemyamount; }
            set { enemyamount = value; }
        }
        public Hero PLAYER
        {
            get { return player; }
            set { player = value; }
        }

        private Hero player;
        public Item[] items;
        public Tile[,] map;
        public Enemy[] enemies;
        public Random r = new Random();
        //contructor
        public Map(int minmapwidth,int maxmapwidth,int minmapheight, int maxmapheight, int eenemyamount,  int itemamount)
        {
            this.MapWidth = r.Next(minmapwidth,maxmapwidth);
            this.MapHeight = r.Next(minmapheight, maxmapheight);
            this.EnemyAmount = eenemyamount;

            items = new Item[itemamount];
            map = new Tile[MapWidth, MapHeight];
            enemies = new Enemy[EnemyAmount];

            FillMap();
            InitializeMap();

            Tile tempHero = Create(TileType.Hero);
            map[player.POSX, player.POSY] = tempHero;


            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = (Enemy)Create(TileType.Enemy);
                map[enemies[i].POSX, enemies[i].POSY]= enemies[i];
            }
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = (Item)Create(TileType.Gold);
                map[items[i].POSX, items[i].POSY] = items[i];
            }
            UpdateVision();
        }
        //methods
        private Tile Create(TileType tiletype)
        {
            int randomX = r.Next(0, MapWidth);
            int randomY = r.Next(0, MapHeight);

            while (map[randomX, randomY] is Obstacle || map[randomX, randomY] is Character || map[randomX, randomY] is Item)
            {
                randomX = r.Next(0, MapWidth);
                randomY = r.Next(0, MapHeight);
            }
            if (tiletype == TileType.Hero)
            {
                player = new Hero(randomX, randomY, 100);//player hp assigned here!
                return player;
            }
            else if(tiletype == TileType.Enemy)
            {
                int temp = r.Next(1, 3);
                if (temp == 1)
                {
                    return new Goblin(randomX, randomY);
                }
                else
                {
                    return new Mage(randomX, randomY);
                }
            }
            else //spawning gold
            {
                return new Gold(randomX, randomY);
            }
            
        }        
        public void UpdateVision()
        {
            player.CHARACTERVISION[0] = map[player.POSX - 1, player.POSY];
            player.CHARACTERVISION[1] = map[player.POSX , player.POSY - 1];
            player.CHARACTERVISION[2] = map[player.POSX + 1, player.POSY]; 
            player.CHARACTERVISION[3] = map[player.POSX , player.POSY + 1];

            foreach (Enemy e in enemies)
            {
                e.CHARACTERVISION[0] = map[e.POSX - 1, e.POSY];
                e.CHARACTERVISION[1] = map[e.POSX , e.POSY - 1];
                e.CHARACTERVISION[2] = map[e.POSX + 1, e.POSY];
                e.CHARACTERVISION[3] = map[e.POSX , e.POSY + 1];
            }
        }
        public void InitializeMap()
        {
            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    map[x, y] = new EmptyTile(x,y);
                }
            }
            SpawnObstacles();
        }
        public void UpdateMap()
        {
            InitializeMap();
            map[player.POSX, player.POSY] = player;

            foreach (Enemy e in enemies)
            {
                if (e.IsDead() == false)
                {
                    map[e.POSX, e.POSY] = e;
                }
            }
            foreach (Item gold in items)
            {
                if (gold != null)
                {
                    map[gold.POSX, gold.POSY] = gold;
                }                
            }
        }
        public void SpawnObstacles()
        {
            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    if (x==0 || y ==0 || x== MapWidth - 1|| y == MapHeight - 1)
                    {
                        map[x, y] = new Obstacle(x,y, "X");
                    }
                }
            }
        }
        public void FillMap()
        {
            for (int x = 0; x < MapWidth; x++)
            {
                for (int y = 0; y < MapHeight; y++)
                {
                    map[x, y] = new EmptyTile(x,y);
                }
            }
        }
        public Item GetItemAtPosition(int x, int y)
        {
            Item pickedupitem = null;
            for (int j = 0; j < items.Length; j++)
            {
                if (items[j] != null)
                {
                    if (items[j].POSX == x && items[j].POSY == y)
                    {
                        pickedupitem = items[j];
                        items[j] = null;
                    }
                }
            }
            return pickedupitem;
        }
    }
}
