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
    public partial class Form_location : Form
    {
        public Form_location()
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
                SqlCommand cmd = new SqlCommand("SELECT Locations.address as address, Locations.Capacity AS capacity FROM Locations", con);
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
        private void ClearData()
        {
            textBox_address.Text = "";
            textBox_capacity.Text = "";

        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            if (textBox_address.Text == "" || textBox_address.Text == "")
            {
                MessageBox.Show("Please Provide Your Information!");
            }
            try
            {
                con.Open();
                // search the student based on the student name
                cmd = new SqlCommand("INSERT INTO Locations(Locations.address,Locations.capacity) VALUES (@add,@cap)", con);
                cmd.Parameters.AddWithValue("@add", textBox_address.Text);
                cmd.Parameters.AddWithValue("@cap", textBox_capacity.Text);
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
            if (textBox_address.Text != null)
            {
                cmd = new SqlCommand("DELETE FROM Locations WHERE Locations.address=@add", con);
                con.Open();
                cmd.Parameters.AddWithValue("@add", textBox_address.Text);
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
            if (!string.IsNullOrEmpty(textBox_address.Text))
            {
                try
                {
                    cmd = new SqlCommand("UPDATE Locations SET capacity=@cap WHERE address=@add", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@add", textBox_address.Text);
                    cmd.Parameters.AddWithValue("@cap", textBox_capacity.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    show_data();
                    ClearData();
                    MessageBox.Show("Record is Updated!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                    ClearData();
                }
            }
            else
            {
                MessageBox.Show("Please Input the Address to Update");
            }

        }
        private void button_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ClassManagement fl = new Form_ClassManagement();
            // show login window
            fl.Show();
        }

        private void button_return_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form_ClassData fl = new Form_ClassData();
            // show login window
            fl.Show();
        }
    }
}
