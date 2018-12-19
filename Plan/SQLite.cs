using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Plan
{
    class SQLite
    {
        private SQLiteConnection DB = new SQLiteConnection("Data Source = PlanControl.db; version=3");
        private SQLiteCommand CMD;

        public SQLite()
        {
            this.DB.Open();
        }

        public void Close ()
        {
            this.DB.Close();
        }

        public SQLiteDataReader query(string sql)
        {
            this.CMD = DB.CreateCommand();
            this.CMD.CommandText = sql;
            return this.CMD.ExecuteReader();
        }
    }
}
