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
    public partial class Form_changeadm : Form
    {
        public Form_changeadm()
        {
            InitializeComponent();
        }

        private void Form_changeadm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Admin.mdf;Integrated Security=True";

            string username = Form_login.username;
            //create sql connection called "con", used to connect to Students database
            SqlConnection con = new SqlConnection(connectionString);
            // the sql command you want to execute in DBMS
            SqlCommand cmd = new SqlCommand("SELECT admLog.adm_user, admLog.adm_pass, admLog.adm_id From admLog Where admLog.adm_user = @adm_user", con);
            cmd.Parameters.AddWithValue("@adm_user", username);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Close();
            label_user.Text = dt.Rows[0]["adm_user"].ToString();
            label_pass.Text = dt.Rows[0]["adm_pass"].ToString();
            //textBox_phone.Text = dt.Rows[0]["phone"].ToString();
            //textBox_saddr.Text = dt.Rows[0]["saddr"].ToString();
            //cmd.Parameters.AddWithValue("@password", textBox_password.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ClassManagement fl = new Form_ClassManagement();
            // show login window
            fl.Show();
        }
    }
}
