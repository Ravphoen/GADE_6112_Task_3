using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_6112_19195640
{
    public partial class Form1 : Form
    {
        GameEngine ge;
        List<Enemy> enemies = new List<Enemy>();
        public Form1()
        {
            InitializeComponent();
            ge = new GameEngine();
            DisplayMap();
            DisplayPlayerStats();
        }

        public void DisplayMap()
        {
            MAPBOX.Text = ge.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        public void DisplayPlayerStats()
        {
            STATBOX.Text = "";
            STATBOX.Text = ge.M.PLAYER.ToString();
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            ge.MovePlayer(movement.Up);
            GameTick();
        }
        private void btnLEFT_Click(object sender, EventArgs e)
        {
            ge.MovePlayer(movement.Left);
            GameTick();
        }
        private void btnRIGHT_Click(object sender, EventArgs e)
        {
            ge.MovePlayer(movement.Right);
            GameTick();
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            ge.MovePlayer(movement.Down);
            GameTick();
        }
        public void GameTick()
        {
            DisplayPlayerStats();
            enemies = new List<Enemy>();
            CBenemies.Items.Clear();
            CBenemies.Items.Remove(CBenemies.SelectedItem);
            ge.UpdateEnemies();
            MAPBOX.Text = "";
            MAPBOX.Text = ge.ToString();
            
            foreach (Enemy e in ge.M.enemies)
            {
                if (ge.M.PLAYER.CheckRange(e) && e.IsDead() == false)
                {
                    enemies.Add(e);
                    CBenemies.Items.Add(e.ToString());
                }                
            }
        }

        private void AttackButton_Click(object sender, EventArgs e)
        {
            if (CBenemies.SelectedText != " ")
            {
                ge.M.PLAYER.Attack(enemies[CBenemies.SelectedIndex]);
                //if (enemies[CBenemies.SelectedIndex] is Goblin)
                //{
                //    BATTLEBOX.Text = enemies[CBenemies.SelectedIndex].ToString();
                //}
                //else if (enemies[CBenemies.SelectedIndex] is Mage)
                //{
                //    BATTLEBOX.Text = enemies[CBenemies.SelectedIndex].ToString();
                //}
                BATTLEBOX.Text = enemies[CBenemies.SelectedIndex].ToString();
                ge.EnemyAttack();
                DisplayPlayerStats();
                MAPBOX.Text = "";
                MAPBOX.Text = ge.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SAVEbtn_Click(object sender, EventArgs e)
        {
            ge.Save();
        }

        private void LOADbtn_Click(object sender, EventArgs e)
        {
            ge.Load();
            enemies = new List<Enemy>();
            DisplayPlayerStats();
            MAPBOX.Text = "";
            MAPBOX.Text = ge.ToString();

            foreach (Enemy en in ge.M.enemies)
            {
                if (ge.M.PLAYER.CheckRange(en) && en.IsDead() == false)
                {
                    enemies.Add(en);
                    CBenemies.Items.Add(en.ToString());
                }
            }
        }
    }
}
