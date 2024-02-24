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
    public partial class Form_instructor : Form
    {


        public Form_instructor()
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
                SqlCommand cmd = new SqlCommand("SELECT Instructors.Instructor_id as ID, Instructors.Instructor_FirstName AS First, Instructors.Instructor_LastName AS Last, Instructors.Instructor_Salary AS Salary FROM Instructors", con);
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
            textBox_phone.Text = "";
            textBox_first.Text = "";
            textBox_last.Text = "";
            textBox_salary.Text = "";

        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_id.Text) || string.IsNullOrEmpty(textBox_first.Text) || string.IsNullOrEmpty(textBox_last.Text) || string.IsNullOrEmpty(textBox_phone.Text) || string.IsNullOrEmpty(textBox_salary.Text))
            {
                MessageBox.Show("Please provide all the required information!");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Instructors(Instructor_ID, instructor_Phone, Instructor_FirstName, Instructor_Lastname, Instructor_Salary) VALUES (@i_id, @i_phone, @i_first, @i_last, @i_salary)", con);
                    cmd.Parameters.AddWithValue("@i_id", textBox_id.Text);
                    cmd.Parameters.AddWithValue("@i_phone", textBox_phone.Text);
                    cmd.Parameters.AddWithValue("@i_first", textBox_first.Text);
                    cmd.Parameters.AddWithValue("@i_last", textBox_last.Text);
                    cmd.Parameters.AddWithValue("@i_salary", textBox_salary.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Insert Successfully!\n\nID: " + textBox_id.Text + "\nPhone: " + textBox_phone.Text + "\nFirst Name: " + textBox_first.Text + "\nLast Name: " + textBox_last.Text + "\nSalary: " + textBox_salary.Text);

                    ClearData();
                    show_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                    ClearData();
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text != null)
            {
                con.Open();
                // Delete corresponding records from the "Teaches" table first
                SqlCommand cmdDeleteTeaches = new SqlCommand("DELETE FROM Teaches WHERE Instructor_id=@id", con);
                cmdDeleteTeaches.Parameters.AddWithValue("@id", textBox_id.Text);
                cmdDeleteTeaches.ExecuteNonQuery();

                // Delete the record from the "Instructors" table
                SqlCommand cmdDeleteInstructor = new SqlCommand("DELETE FROM Instructors WHERE Instructor_id=@id", con);
                cmdDeleteInstructor.Parameters.AddWithValue("@id", textBox_id.Text);
                cmdDeleteInstructor.ExecuteNonQuery();

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
                cmd = new SqlCommand("UPDATE Instructors SET Instructors.Instructor_FirstName=@i_first, Instructors.Instructor_Lastname=@i_last, Instructors.Instructor_phone=@i_phone, Instructors.Instructor_Salary=@i_salary  WHERE Instructors.Instructor_id=@i_id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@i_id", textBox_id.Text);
                cmd.Parameters.AddWithValue("@i_phone", textBox_phone.Text);
                cmd.Parameters.AddWithValue("@i_first", textBox_first.Text);
                cmd.Parameters.AddWithValue("@i_last", textBox_last.Text);
                cmd.Parameters.AddWithValue("@i_salary", textBox_salary.Text);
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
