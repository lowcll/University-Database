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
    public partial class Form_Courses : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True");
        SqlCommand cmd;

        public Form_Courses()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ClassData fl = new Form_ClassData();
            // show login window
            fl.Show();
        }

        private void show_data()
        {
            {
                con.Open();
                // search the student based on the student name
                SqlCommand cmd = new SqlCommand("SELECT Courses.Course_id as ID, Courses.Course_name AS Name, Courses.Course_Duration AS Time, Courses.Course_CreditHR AS Credits FROM Courses", con);
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
            textBox_name.Text = "";
            textBox_time.Text = "";
            textBox_hr.Text = "";

        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "" || textBox_name.Text == "" || textBox_time.Text == "" || textBox_hr.Text == "")
            {
                MessageBox.Show("Please Provide Your Information!");
            }
            try
            {
                con.Open();
                // search the student based on the student name
                cmd = new SqlCommand("INSERT INTO Courses(Courses.Course_id,Courses.Course_name,Courses.Course_Duration,Courses.Course_CreditHR) VALUES (@c_id,@c_name,@c_time,@c_hr)", con);
                cmd.Parameters.AddWithValue("@c_id", textBox_id.Text);
                cmd.Parameters.AddWithValue("@c_name", textBox_name.Text);
                cmd.Parameters.AddWithValue("@c_time", textBox_time.Text);
                cmd.Parameters.AddWithValue("@c_hr", textBox_hr.Text);
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
                cmd = new SqlCommand("DELETE FROM Courses  WHERE Courses.Course_id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", textBox_id.Text);
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
                cmd = new SqlCommand("UPDATE Courses SET Courses.Course_name=@c_name, Courses.Course_Duration=@c_time, Courses.Course_CreditHR=@c_hr WHERE Courses.Course_id=@c_id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@c_id", textBox_id.Text);
                cmd.Parameters.AddWithValue("@c_name", textBox_name.Text);
                cmd.Parameters.AddWithValue("@c_time", textBox_time.Text);
                cmd.Parameters.AddWithValue("@c_hr", textBox_hr.Text);
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

    }
}
