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

                
        int row = 0;
        int col = 0;
        

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
                    int tubeCol = SQL.GetInt32(2);
                    int tubeRow = SQL.GetInt32(1);
                    int type = SQL.GetInt32(3);
                    Array coords = GetTubeXY(tubeRow, tubeCol);
                    Bitmap Image = null;

                    switch (type)
                    {
                        case 1:
                            Image = im.tube;
                            break;
                        case 2:
                            Image = im.plg;
                            break;
                        case 3:
                            Image = im.tubeb;
                            break;
                    }
                    
                    g.DrawImage(Image, new Rectangle((int) coords.GetValue(1), (int) coords.GetValue(0), tubeSize, tubeSize));
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
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "select * from planClear";
            SQLiteDataReader SQL = CMD.ExecuteReader();
            if (SQL.HasRows)
            {
                while (SQL.Read())
                {
                    int type = SQL.GetInt32(3);
                    row = SQL.GetInt32(1);
                    col = SQL.GetInt32(2);
                    string res = SQL.GetString(4);
                }
            }

            
            //if ((e.X < row + 7) && (e.X > row))
            //    if ((e.Y < col + 7) && (e.Y > col))
            //    {
            //    tbPX.Clear();
                
            //    tbPX.Text = tp.ToString();
            //    }
           
        }

        private Array GetTubeRowCol(double x, double y)
        {
            int[] coords = new int[] {
                (int) Math.Floor(x / tubeSize), //Колонна
                (int) Math.Floor(y / tubeSize) //Ряд
            };
            //сместили если четный ряд
            if ((int)coords.GetValue(0) % 2 == 0)
                coords.SetValue((int)(x * tubeSize), 0);
            return coords;
        }

        private Array GetTubeXY(int x, int y)
        {
            int[] coords = new int[] {
                (int) x*tubeSize, //Колонна
                (int) (y - 200)*tubeShift //Ряд
            };
            //сместили если четный ряд
            if ((int)coords.GetValue(0) % 2 == 0)
                coords.SetValue((int)(x * tubeSize), 0);
            return coords;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
// 0   1   2   3     4
// id row col type tupes 
// ai int int int  string
//     nn  nn  nn
// 1   1   1   1    tube
