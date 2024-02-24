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
    public partial class Form_ClassManagement : Form
    {
        public Form_ClassManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_login fr = new Form_login();
            fr.Show();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_logout fl = new Form_logout();
            // show login window
            fl.Show();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_changeadm fl = new Form_changeadm();
            // show login window
            fl.Show();
        }

        private void button_classmanage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ClassData fl = new Form_ClassData();
            // show login window
            fl.Show();
        }
    }
}
