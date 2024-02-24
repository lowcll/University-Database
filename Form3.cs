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
    public partial class Form_register : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Admin.mdf;Integrated Security=True");
        SqlCommand cmd;

        public Form_register()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            if (textBox_aid.Text == "" || textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Please Provide Your Information!");
            }
            try
            {
                con.Open();
                // search the student based on the student name
                cmd = new SqlCommand("INSERT INTO admLog(admLog.adm_user,admLog.adm_pass,admLog.adm_id) VALUES (@adm_user,@adm_pass,@adm_id)", con);
                cmd.Parameters.AddWithValue("@adm_user", textBox_username.Text);
                cmd.Parameters.AddWithValue("@adm_pass", textBox_password.Text);
                cmd.Parameters.AddWithValue("@adm_id", textBox_aid.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                // clear the content in textbox
                //ClearData();
                // refresh the datagridview
               // show_data();
                MessageBox.Show("Insert Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            } 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_login fr = new Form_login();
            fr.Show();
        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
