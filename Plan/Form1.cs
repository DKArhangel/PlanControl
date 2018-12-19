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
        SQLite db = new SQLite();
        List<Tube> tubes = new List<Tube>();

        public Form1()
        {
            InitializeComponent();
        }

        private Icons icons = new Icons();

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            SQLiteDataReader data = this.db.query("select * from planClear");
            
            if (data.HasRows)
            {
                while (data.Read())
                {
                    TubeCoords currentTubeCoords = new TubeCoords {
                        row = data.GetInt32(1),
                        col = data.GetInt32(2) 
                    };
                    int type = data.GetInt32(3);

                    Tube tube = new Tube(currentTubeCoords);
                    tubes.Add(tube);
                    graphics.DrawImage(icons.getIcon(type), tube.getRectangle());
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
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.db.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Tube currentTube = tubes.Find(tube => tube.isClicked(e.Location));

            if (currentTube is Tube)
            {
                TubeCoords coords = currentTube.getCoords();
                tbPX.Text = coords.row.ToString();
                tbPY.Text = coords.col.ToString();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private ToolTip tubeTip = new ToolTip();
        private string toolTipText;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Tube currentTube = tubes.Find(tube => tube.isClicked(e.Location));


            if (currentTube is Tube)
            {
                TubeCoords coords = currentTube.getCoords();
                string toolTipText = "Row: " + coords.row.ToString() + " Col: " + coords.col.ToString();
                if (this.toolTipText != toolTipText)
                {
                    this.tubeTip.Show(toolTipText, this, currentTube.rectanglePosition.x + 10, currentTube.rectanglePosition.y + 10);
                    this.toolTipText = toolTipText;
                }
            }
            else
                this.tubeTip.Hide(this);
        }
    }
}
// 0   1   2   3     4         номер столбца
// id row col type tupes       название столбца
// ai int int int  string      тп данных
//     nn  nn  nn              не пустой
// 1   1   1   1    tube       пример
