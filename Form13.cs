using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project2
{
    public partial class Form_FinAid : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

        public Form_FinAid()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_dataview fl = new Form_dataview();
            fl.Show();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            // check if the textbox is empty
            if (textBox_name.Text == "")
            {
                MessageBox.Show("Please provide student name");
                return;
            }

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT s.Student_ID, s.Student_FirstName, s.Student_LastName, h.Student_Income, h.Student_FinAid, " +
                                             "c.Course_ID, c.Course_Name, c.Course_Duration, c.Course_CreditHR " +
                                             "FROM Enrolled e " +
                                             "INNER JOIN Student s ON e.Student_ID = s.Student_ID " +
                                             "INNER JOIN Has_Income h ON s.Student_ID = h.Student_ID " +
                                             "INNER JOIN Courses c ON e.Course_ID = c.Course_ID " +
                                             "WHERE s.Student_FirstName LIKE '%' + @firstName + '%' " +
                                             "ORDER BY s.Student_LastName, s.Student_FirstName", con);

            cmd.Parameters.AddWithValue("@firstName", textBox_name.Text);

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            dataGridView_finances.DataSource = dt;

            con.Close();

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_max_Click(object sender, EventArgs e)
        {
            if (textBox_course_id.Text == "")
            {
                MessageBox.Show("Please provide class name");
                return;
            }
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT s.Student_FirstName, s.Student_LastName, MAX(h.Student_Income) AS MAX_Income FROM Student s INNER JOIN Has_Income h ON s.Student_ID = h.Student_ID INNER JOIN Enrolled e ON s.Student_ID = e.Student_ID WHERE e.Course_ID = @course_id GROUP BY s.Student_FirstName, s.Student_LastName", con);
            cmd.Parameters.AddWithValue("@course_id", textBox_course_id.Text);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            // if the course is not exist, show error message
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Please provide Course ID");
                con.Close();
                return;
            }
            // show query result
            MessageBox.Show("MAX Income for Course " + textBox_course_id.Text + ": " + dt.Rows[0]["MAX_Income"].ToString() + " for Student " + dt.Rows[0]["Student_FirstName"].ToString() + " " + dt.Rows[0]["Student_LastName"].ToString());
            con.Close();

        }

        private void button_min_Click(object sender, EventArgs e)
        {
            if (textBox_course_id.Text == "")
            {
                MessageBox.Show("Please provide Course ID");
                return;
            }
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT TOP 1 s.Student_FirstName, s.Student_LastName, h.Student_Income AS MIN_Income FROM Student s INNER JOIN Has_Income h ON s.Student_ID = h.Student_ID INNER JOIN Enrolled e ON s.Student_ID = e.Student_ID WHERE e.Course_ID = @course_id ORDER BY h.Student_Income ASC", con);
            cmd.Parameters.AddWithValue("@course_id", textBox_course_id.Text);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            // if the course is not exist, show error message
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Can not find this course");
                con.Close();
                return;
            }
            // show query result
            MessageBox.Show("MIN Income for Course " + textBox_course_id.Text + ": " + dt.Rows[0]["MIN_Income"].ToString() + " for Student " + dt.Rows[0]["Student_FirstName"].ToString() + " " + dt.Rows[0]["Student_LastName"].ToString());
            con.Close();

        }

        private void button_avg_Click(object sender, EventArgs e)
        {
            if (textBox_course_id.Text == "")
            {
                MessageBox.Show("Please provide Course ID");
                return;
            }
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT AVG(h.Student_Income) AS AVG_Income FROM Student s INNER JOIN Has_Income h ON s.Student_ID = h.Student_ID INNER JOIN Enrolled e ON s.Student_ID = e.Student_ID WHERE e.Course_ID = @course_id", con);
            cmd.Parameters.AddWithValue("@course_id", textBox_course_id.Text);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            // if the course is not exist, show error message
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Can not find this course");
                con.Close();
                return;
            }
            // show query result
            MessageBox.Show("Average Income for Course " + textBox_course_id.Text + ": " + dt.Rows[0]["AVG_Income"].ToString());
            con.Close();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_finances_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
