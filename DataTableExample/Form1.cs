using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataTableExample
{
    public partial class Form1 : Form
    {
        DataTable dataTable = null;
       

        public Form1()
        {
            InitializeComponent();
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("NO", typeof(int));
            dataTable.Columns.Add("이름", typeof(string));
            dataTable.Columns.Add("입사 날짜", typeof(DateTime));
            dataTable.Columns.Add("월급", typeof(int));

            dataTable.Rows.Add(100, "김철수", "2003-06-17", 24000);
            dataTable.Rows.Add(101, "김나나", "2005-09-21", 17000);

            dataGridView1.DataSource = dataTable;

        }
      


    

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow row = dataTable.NewRow();

            row["NO"] = 104;
            row["이름"] = "홍길동";
            row["입사 날짜"] = "2007-05-21";
            row["월급"] = 6000;

            dataTable.Rows.InsertAt(row, 0);

            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataTable.Rows[0].Delete();
            }
            catch
            {
            }
        }
    }
}
