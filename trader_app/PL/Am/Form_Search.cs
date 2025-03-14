using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace trader_app.PL.Am
{
    public class Form_Search : Form
    {
        public DataGridView dataGridView1 { get; set; }
        private string sql;
        private string wherestr;
        private Dictionary<int, string> list_C_N;

        public Form_Search(string sql, string wherestr, Dictionary<int, string> list_C_N)
        {
            this.sql = sql;
            this.wherestr = wherestr;
            this.list_C_N = list_C_N;
            dataGridView1 = new DataGridView();
            dataGridView1.Columns.Add("Account_ID", "Account ID");
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = "1"; // Dummy account ID.
            dataGridView1.Rows.Add(row);
        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}