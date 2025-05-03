using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_DB
{
    public partial class ViewData : UserControl
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        private List<string> primaryKeys = new List<string>();

        public ViewData()
        {
            InitializeComponent();

            con = new SqlConnection(Program.AuthConnectionString);
            comboBox.Items.AddRange(new string[]
            {
                "Cart", "Cart_MenuItem", "Customer", "Employee", "Menu_Item",
                "Order_MenuItem", "Order", "Restaurant", "Restaurant_Address", "User"
            });

            comboBox.Text = "Select Table";
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            readButton.Click += readButton_Click;
            orderBox.SelectedIndexChanged += orderBox_SelectedIndexChanged;
            checkedListBox.ItemCheck += checkedListBox_ItemCheck;

            orderBox.Items.Add("No order");
            orderBox.SelectedItem = "No order";
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem == null) return;

            readButton.Enabled = true;
            orderBox.Enabled = true;

            SqlCommand pkCmd = new SqlCommand("EXEC sp_pkeys '" + comboBox.SelectedItem.ToString() + "'", con);
            con.Open();
            SqlDataReader pkReader = pkCmd.ExecuteReader();

            string tableName = comboBox.SelectedItem.ToString();
            if (comboBox.SelectedItem.ToString() == "User"|| comboBox.SelectedItem.ToString() == "Order")
            {
                tableName = $"[{comboBox.SelectedItem.ToString()}]";
            }
            primaryKeys.Clear();
            while (pkReader.Read())
            {
                primaryKeys.Add(pkReader["COLUMN_NAME"].ToString());
            }
            pkReader.Close();

            cmd = new SqlCommand("SELECT * FROM " + tableName, con);
            rdr = cmd.ExecuteReader();

            checkedListBox.Items.Clear();
            orderBox.Items.Clear();
            orderBox.Items.Add("No order");
            orderBox.SelectedItem = "No order";

            for (int i = 0; i < rdr.FieldCount; i++)
            {
                checkedListBox.Items.Add(rdr.GetName(i));
                checkedListBox.SetItemChecked(i, true);
                orderBox.Items.Add(rdr.GetName(i));
            }

            rdr.Close();
            con.Close();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            con.Open();

            string colString = "";
            for (int i = 0; i < checkedListBox.CheckedItems.Count; i++)
            {
                colString += checkedListBox.CheckedItems[i].ToString();
                if (i != checkedListBox.CheckedItems.Count - 1) colString += ", ";
            }

            string tableName = comboBox.SelectedItem.ToString();
            if (comboBox.SelectedItem.ToString() == "User" || comboBox.SelectedItem.ToString() == "Order")
            {
                tableName = $"[{comboBox.SelectedItem.ToString()}]";
            }

            string order = "NO ORDER";
            if (ascRadio.Checked) order = "ASC";
            else if (descRadio.Checked) order = "DESC";

            if (order == "NO ORDER" || orderBox.SelectedItem.ToString() == "No order")
            {
               
                cmd = new SqlCommand("SELECT " + colString + " FROM " +tableName, con);
            }
            else
            {
                cmd = new SqlCommand("SELECT " + colString + " FROM " + tableName
                    + " ORDER BY " + orderBox.SelectedItem.ToString() + " " + order, con);
            }

            rdr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rdr);
            dataGridView.DataSource = dt;

            rdr.Close();
            con.Close();
        }

        private void orderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderBox.SelectedItem != null && orderBox.SelectedItem.ToString() != "No order")
            {
                ascRadio.Enabled = true;
                descRadio.Enabled = true;
                ascRadio.Checked = true;
            }
            else
            {
                ascRadio.Enabled = false;
                descRadio.Enabled = false;
                ascRadio.Checked = false;
                descRadio.Checked = false;
            }
        }

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Optional: Prevent unchecking primary keys if desired
        }

        private void readButton_Click_1(object sender, EventArgs e)
        {

        }

        private void ascRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void descRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
