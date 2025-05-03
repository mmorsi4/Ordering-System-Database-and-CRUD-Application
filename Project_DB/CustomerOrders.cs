
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_DB
{
    public partial class CustomerOrders: UserControl
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;


        public CustomerOrders()
        {
            InitializeComponent();
            con = new SqlConnection(Program.AuthConnectionString); 
            con.Open();
            cmd = new SqlCommand("SELECT Username FROM [Customer]",con);
            cmd.CommandType = CommandType.Text;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string customer = rdr["Username"].ToString();
                comboBox.Items.Add(customer);
            }
            con.Close();

        }

        private void CustomerOrders_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void readButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string selectedCustomer = comboBox.SelectedItem.ToString();
            cmd = new SqlCommand("GetOrdersByCustomer @Customer_Username", con);
            cmd.Parameters.AddWithValue("@Customer_Username", selectedCustomer);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }
    }
}
