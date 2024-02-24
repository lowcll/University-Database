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
    public partial class Form_department : Form
    {
        public Form_department()
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
                SqlCommand cmd = new SqlCommand("SELECT Department.Department_ID as ID, Department.Dept_name AS Name FROM Department", con);
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

        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "" || textBox_name.Text == "")
            {
                MessageBox.Show("Please Provide Your Information!");
            }
            try
            {
                con.Open();
                // search the student based on the student name
                cmd = new SqlCommand("INSERT INTO Department(Department.Department_ID,Department.Dept_name) VALUES (@d_id,@d_name)", con);
                cmd.Parameters.AddWithValue("@d_id", textBox_id.Text);
                cmd.Parameters.AddWithValue("@d_name", textBox_name.Text);
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
                cmd = new SqlCommand("DELETE FROM Department  WHERE Department.Department_ID=@id", con);
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
                cmd = new SqlCommand("UPDATE Department SET Department.Dept_name=@d_name, WHERE Department.Department_ID=@d_id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@d_id", textBox_id.Text);
                cmd.Parameters.AddWithValue("@d_name", textBox_name.Text);
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

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_return_Click_1(object sender, EventArgs e)
        {
                this.Hide();
                Form_ClassData fl = new Form_ClassData();
                // show login window
                fl.Show();
        }

        private void dataGridView_records_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_delete_Click_1(object sender, EventArgs e)
        {
            if (textBox_id.Text != null)
            {
                cmd = new SqlCommand("DELETE FROM Department  WHERE Department.Department_id=@id", con);
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

        private void button_insert_Click_1(object sender, EventArgs e)
        {
            if (textBox_id.Text == "" || textBox_name.Text == "")
            {
                MessageBox.Show("Please Provide Your Information!");
            }
            try
            {
                con.Open();
                // search the student based on the student name
                cmd = new SqlCommand("INSERT INTO Department(Department.Department_ID,Department.Dept_name) VALUES (@d_id,@d_name)", con);
                cmd.Parameters.AddWithValue("@d_id", textBox_id.Text);
                cmd.Parameters.AddWithValue("@d_name", textBox_name.Text);
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

        private void button_update_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_id.Text))
            {
                cmd = new SqlCommand("UPDATE Department SET Department.Dept_name=@d_name WHERE Department.Department_id=@d_id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@d_id", textBox_id.Text);
                cmd.Parameters.AddWithValue("@d_name", textBox_name.Text);
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
