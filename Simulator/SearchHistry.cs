using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simulator
{
    public partial class SearchHistry : Form
    {
        private string filepath = "SearchHistry.csv";
        private Encoding encode = Encoding.GetEncoding("shift_jis");
        private csvReader cr;
        Form1 fm;

        public SearchHistry(Form1 fm)
        {
            InitializeComponent();
            this.fm = fm;
        }

        private void SearchHistry_Load(object sender, EventArgs e)
        {
            cr = new csvReader(@filepath, encode);
            for(int i=0; i<cr.table.GetLength(0); i++){
                dataGridView1.Rows.Add(cr.table[i,0],cr.table[i,1],cr.table[i,2],cr.table[i,3],cr.table[i,4],cr.table[i,5],cr.table[i,6],cr.table[i,7]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fm.setData(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),
                dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(),
                dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
            this.Close();
        }
    }
}
