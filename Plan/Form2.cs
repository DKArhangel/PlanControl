﻿using System;
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
    public partial class Form2 : Form
    {
        private SQLiteConnection DB;
        public Form2()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbRow.Text != "" && tbCol.Text != "" && tbX.Text != "" && tbY.Text != "")
            {
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "insert into PlanClear(row,col,posx,posy,type) values( @row , @col, @posx, @posy, @type )";
                CMD.Parameters.Add("@row", System.Data.DbType.String).Value = tbRow.Text;
                CMD.Parameters.Add("@col", System.Data.DbType.String).Value = tbCol.Text;
                CMD.Parameters.Add("@posx", System.Data.DbType.String).Value = tbX.Text;
                CMD.Parameters.Add("@posy", System.Data.DbType.String).Value = tbY.Text;
                CMD.Parameters.Add("@type", System.Data.DbType.String).Value = "tube";
                CMD.ExecuteNonQuery();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection("Data Source = PlanControl.db; version=3");
            DB.Open();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            DB.Close();
        }
    }
}