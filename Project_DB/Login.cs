using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            string connStr = $"Server=localhost;Database=Ordering System;User Id={username};Password={password};";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open(); // this authenticates the user
                    conn.Close();

                    // Save connection string or DB name to use in Form1
                    Program.AuthConnectionString = connStr;

                    // Open main form
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
