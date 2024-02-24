using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form_dataview : Form
    {
        public Form_dataview()
        {
            InitializeComponent();
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ClassData fl = new Form_ClassData();
            // show login window
            fl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_FinAid fl = new Form_FinAid();
            // show login window
            fl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_InsSal fl = new Form_InsSal();
            // show login window
            fl.Show();
        }
    }
}
