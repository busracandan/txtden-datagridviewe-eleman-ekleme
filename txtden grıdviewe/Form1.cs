using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace txtden_grıdviewe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr=new StreamReader("deneme.txt",Encoding.Default);
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                string[] ayır = s.Split(',');
                dataGridView1.Rows.Add(ayır);
            }
            sr.Close();
        }
    }
}
