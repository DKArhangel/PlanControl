using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Plan
{
    public partial class Form1 : Form
    {
        
        private SQLiteConnection DB;

        int counter = 0;
        bool mouseclick = false;
        int posx = 0;
        int posy = 0;
        string tp = null;

        public Form1()
        {
            InitializeComponent();
        }

        Images im = new Images();

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "select * from planClear";
            SQLiteDataReader SQL = CMD.ExecuteReader();
            if (SQL.HasRows)
            {
                while (SQL.Read())
                {
                    int type = SQL.GetInt32(3);
                    posx = SQL.GetInt32(4);
                    posy = SQL.GetInt32(5);
                    string res = SQL.GetString(6);

                    if (type == 1)
                    {
                        g.DrawImage(im.tube, new Rectangle(posx, posy, 7, 7));
                        tp = res;
                    }
                    else if (type == 2)
                    {
                        g.DrawImage(im.plg, new Rectangle(posx, posy, 7, 7));
                        tp = res;
                    }
                }
            }
        }

        private void btopnfadd_Click(object sender, EventArgs e)
        {
            Form2 fmadd = new Form2();
            fmadd.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection("Data Source = PlanControl.db; version=3");
            DB.Open();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DB.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if((e.X < posx + 7) && (e.X > posx))
                if ((e.Y < posy + 7) && (e.Y > posy))
                {
                tbPX.Clear();
                mouseclick = true;
                tbPX.Text = tp.ToString();
            }
           
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseclick = false;
        }
    }
}
