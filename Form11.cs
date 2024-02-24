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
    public partial class Form_student : Form
    {
        public Form_student()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;

        private void show_data()
        {
            {
                con.Open();
                // search the student based on the student name
                SqlCommand cmd = new SqlCommand("SELECT Student.Student_id as ID, Student.Student_FirstName AS First, Student.Student_LastName AS Last FROM Student", con);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView_records.DataSource = dt;
                con.Close();
            }
        }
        private void button_show_Click(object sender, EventArgs e)
        {
            show_data();
        }

        // clear the content in textbox
        private void ClearData()
        {
            textBox_id.Text = "";
            textBox_first.Text = "";
            textBox_last.Text = "";
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "" || textBox_first.Text == "" || textBox_last.Text == "")
            {
                MessageBox.Show("Please Provide Your Information!");
            }
            try
            {
                con.Open();
                // search the student based on the student name
                cmd = new SqlCommand("INSERT INTO Student(Student.Student_id,Student.Student_FirstName,Student.Student_LastName) VALUES (@s_id,@s_first,@s_last)", con);
                cmd.Parameters.AddWithValue("@s_id", textBox_id.Text);
                cmd.Parameters.AddWithValue("@s_first", textBox_first.Text);
                cmd.Parameters.AddWithValue("@s_last", textBox_last.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                // clear the content in textbox
                ClearData();
                // refresh the datagridview
                show_data();
                MessageBox.Show("Insert Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                ClearData();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text != null)
            {
                cmd = new SqlCommand("DELETE FROM Student WHERE Student.Student_id=@s_id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@s_id", textBox_id.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                show_data();
                ClearData();
                MessageBox.Show("Record is Deleted!");
            }
            else
            {
                MessageBox.Show("Please Input the ID to Delete");
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_id.Text))
            {
                cmd = new SqlCommand("UPDATE Student SET Student.Student_FirstName=@s_first, Student.Student_LastName=@s_last WHERE Student.Student_id=@s_id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@s_id", textBox_id.Text);
                cmd.Parameters.AddWithValue("@s_first", textBox_first.Text);
                cmd.Parameters.AddWithValue("@s_last", textBox_last.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                show_data();
                ClearData();
                MessageBox.Show("Record is Updated!");
            }
            else
            {
                MessageBox.Show("Please Input the ID to Update");
            }
        }

        private void button_return_Click(object sender, EventArgs e)
        {
                this.Hide();
                Form_ClassData fl = new Form_ClassData();
                // show login window
                fl.Show();

        }
    }
}
