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
    public partial class Form_ClassData : Form
    {
        public Form_ClassData()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ClassManagement fl = new Form_ClassManagement();
            // show login window
            fl.Show();
        }

        private void button_courses_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Courses fl = new Form_Courses();
            // show login window
            fl.Show();
        }

        private void button_departments_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_department fl = new Form_department();
            // show login window
            fl.Show();
        }

        private void button_instructors_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_instructor fl = new Form_instructor();
            // show login window
            fl.Show();
        }

        private void button_locations_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_location fl = new Form_location();
            // show login window
            fl.Show();
        }

        private void button_students_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_student fl = new Form_student();
            // show login window
            fl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_dataview fl = new Form_dataview();
            // show login window
            fl.Show();
        }
    }
}
