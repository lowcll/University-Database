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
    public partial class Form_InsSal : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");

        public Form_InsSal()
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

        private void button_search_Click(object sender, EventArgs e)
        {
            // check if the textbox is empty
            if (textBox_name.Text == "")
            {
                MessageBox.Show("Please provide student name");
                return;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT i.Instructor_ID, i.Instructor_FirstName, i.Instructor_LastName, i.Instructor_Salary, c.Course_ID, d.Dept_Name " +
                                             "FROM Teaches t " +
                                             "INNER JOIN Courses c ON t.Course_ID = c.Course_ID " +
                                             "INNER JOIN Instructors i ON t.Instructor_ID = i.Instructor_ID " +
                                             "INNER JOIN Offers o ON o.Course_ID = c.Course_ID " +
                                             "INNER JOIN Department d ON o.Department_ID = d.Department_ID " +
                                             "WHERE i.Instructor_FirstName LIKE '%' + @firstName + '%' " +
                                             "ORDER BY i.Instructor_LastName, i.Instructor_FirstName", con);
            cmd.Parameters.AddWithValue("@firstName", textBox_name.Text);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView_finances.DataSource = dt;
            con.Close();



        }

        private void button_max_Click(object sender, EventArgs e)
        {
            if (textBox_course_id.Text == "")
            {
                MessageBox.Show("Please provide class name");
                return;
            }

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT i.Instructor_FirstName, i.Instructor_LastName, MAX(i.Instructor_Salary) AS MAX_Salary FROM Teaches t INNER JOIN Instructors i ON t.Instructor_ID = i.Instructor_ID WHERE t.Course_ID = @course_id GROUP BY i.Instructor_FirstName, i.Instructor_LastName", con);
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
            MessageBox.Show("MAX Salary for Course " + textBox_course_id.Text + ": " + dt.Rows[0]["MAX_Salary"].ToString() + " for Instructor " + dt.Rows[0]["Instructor_FirstName"].ToString() + " " + dt.Rows[0]["Instructor_LastName"].ToString());

            con.Close();

        }

        private void button_min_Click(object sender, EventArgs e)
        {
            if (textBox_course_id.Text == "")
            {
                MessageBox.Show("Please provide course ID");
                return;
            }
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT TOP 1 i.Instructor_FirstName, i.Instructor_LastName, i.Instructor_Salary AS MIN_Salary FROM Instructors i INNER JOIN Teaches t ON i.Instructor_ID = t.Instructor_ID WHERE t.Course_ID = @course_id ORDER BY i.Instructor_Salary ASC", con);
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
            MessageBox.Show("MIN Salary for Course " + textBox_course_id.Text + ": " + dt.Rows[0]["MIN_Salary"].ToString() + " for Instructor " + dt.Rows[0]["Instructor_FirstName"].ToString() + " " + dt.Rows[0]["Instructor_LastName"].ToString());
            con.Close();
        }

        private void button_avg_Click(object sender, EventArgs e)
        {
            if (textBox_course_id.Text == "")
            {
                MessageBox.Show("Please provide course ID");
                return;
            }

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT AVG(i.Instructor_Salary) AS AVG_Salary FROM Instructors i INNER JOIN Teaches t ON i.Instructor_ID = t.Instructor_ID WHERE t.Course_ID = @course_id", con);
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
            MessageBox.Show("Average Salary for Course " + textBox_course_id.Text + ": " + dt.Rows[0]["AVG_Salary"].ToString());
            con.Close();

        }

        private void textBox_course_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
