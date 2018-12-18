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

        int tubeSize = 8;
        int tubeShift = 4;

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
                    int tubeCol = SQL.GetInt32(2);
                    int tubeRow = SQL.GetInt32(1);

                    Array coords = GetTubeXY(tubeRow, tubeCol);
                    string res = SQL.GetString(6);
                    Bitmap Image = null;
                    switch (type)
                    {
                        case 1:
                            Image = im.tube;
                            break;
                        case 2:
                            Image = im.plg;
                            break;
                    }
                    tp = res;
                    g.DrawImage(Image, new Rectangle((int) coords.GetValue(0), (int) coords.GetValue(1), tubeSize, tubeSize));
                    debug.Text += " row: "+ tubeRow + "col: " + tubeCol + " [" + coords.GetValue(0) + ", " + coords.GetValue(1) + "]\r\n";
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
            Array coords = GetTubeRowCol(e.X, e.Y);

            debug.Text = "[" + coords.GetValue(0) + ", " + coords.GetValue(1) + "]\r\n";

            //return;
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "select * from planClear";
            SQLiteDataReader SQL = CMD.ExecuteReader();
            if (SQL.HasRows)
            {
                debug.Clear();
                while (SQL.Read())
                {
                    int type = SQL.GetInt32(3);
                    posx = SQL.GetInt32(1);
                    posy = SQL.GetInt32(2);
                    string res = SQL.GetString(6);

                    debug.Text += "["+type+", "+posx+", "+posy+", "+ res+"]\r\n";
                }
            }

            
            if ((e.X < posx + 7) && (e.X > posx))
                if ((e.Y < posy + 7) && (e.Y > posy))
                {
                tbPX.Clear();
                mouseclick = true;
                tbPX.Text = tp.ToString();
                }
           
        }

        private Array GetTubeRowCol(double x, double y)
        {

            int[] coords = new int[] {
                (int) Math.Floor(x / tubeSize), //Колонна
                (int) Math.Floor(y / tubeSize) //Ряд
            };
            //сместили если четный ряд
            if ( (int) coords.GetValue(1) % 2 == 0)
                coords.SetValue((int) Math.Floor( (x - tubeShift) / tubeSize), 0);
            return coords;
        }

        private Array GetTubeXY(int x, int y)
        {

            int[] coords = new int[] {
                (int) x * tubeSize, //Колонна
                (int) y * tubeSize //Ряд
            };
            //сместили если четный ряд
            if ((int)coords.GetValue(1) % 2 == 0)
                coords.SetValue( (int) (x * tubeSize + tubeShift), 0);
            return coords;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseclick = false;
        }
    }
}
