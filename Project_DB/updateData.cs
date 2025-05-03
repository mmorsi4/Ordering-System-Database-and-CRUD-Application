using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_DB
{
    public partial class UpdateData : UserControl
    {
        private SqlConnection con;
        private List<string> primaryKeys = new List<string>();

        public UpdateData()
        {
            InitializeComponent();

            con = new SqlConnection(Program.AuthConnectionString);
            comboBox.Items.AddRange(new string[]
            {
                "Cart", "Cart_MenuItem", "Customer", "Employee", "Menu_Item",
                "Order_MenuItem", "Order", "Restaurant", "Restaurant_Address", "User"
           });

            comboBox.Text = "Select Table";
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputPanel.Controls.Clear();
            primaryKeys.Clear();

            string selectedTable = comboBox.SelectedItem.ToString();
            List<string> columns = GetTableColumns(selectedTable);

            int top = 10;
            foreach (string col in columns)
            {
                Label label = new Label() { Text = col, Top = top, Left = 5 };
                System.Windows.Forms.TextBox box = new System.Windows.Forms.TextBox() { Name = "txt" + col, Top = top + 20, Left = 5, Width = 200 };
                inputPanel.Controls.Add(label);
                inputPanel.Controls.Add(box);
                top += 50;
            }

            con.Open();
            SqlCommand pkCmd = new SqlCommand("EXEC sp_pkeys '" + selectedTable + "'", con);
            SqlDataReader pkReader = pkCmd.ExecuteReader();
            while (pkReader.Read())
            {
                primaryKeys.Add(pkReader["COLUMN_NAME"].ToString());
            }
            pkReader.Close();
            con.Close();
        }

        private List<string> GetTableColumns(string tableName)
        {
            List<string> columns = new List<string>();
            SqlCommand cmd = new SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @table", con);
            cmd.Parameters.AddWithValue("@table", tableName);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read() && reader["COLUMN_NAME"].ToString() != "Age" && (reader["COLUMN_NAME"].ToString() != "Name")||(tableName=="Restaurant"))
            {
                columns.Add(reader["COLUMN_NAME"].ToString());
            }

            reader.Close();
            con.Close();
            return columns;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a table first.");
                return;
            }

            string tableName = comboBox.SelectedItem.ToString();
            if (comboBox.SelectedItem.ToString() == "User" || comboBox.SelectedItem.ToString() == "Order")
            {
                tableName = $"[{comboBox.SelectedItem.ToString()}]";
            }

            List<string> setClauses = new List<string>();
            string whereClause = "";

            foreach (Control control in inputPanel.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    string col = textBox.Name.Replace("txt", "");
                    string val = textBox.Text.Trim();

                    if (primaryKeys.Contains(col))
                    {
                        if (!string.IsNullOrWhiteSpace(val))
                            whereClause += $"{col} = '{val.Replace("'", "''")}' AND ";
                    }
                    else
                    {
                        if (!string.IsNullOrWhiteSpace(val))
                            setClauses.Add($"{col} = '{val.Replace("'", "''")}'");
                    }
                }
            }

            if (string.IsNullOrEmpty(whereClause))
            {
                MessageBox.Show("Please enter values for all primary key fields.");
                return;
            }

            whereClause = whereClause.Substring(0, whereClause.Length - 5); // remove trailing AND

            if (setClauses.Count == 0)
            {
                MessageBox.Show("No fields to update.");
                return;
            }

            string updateQuery = $"UPDATE {tableName} SET {string.Join(", ", setClauses)} WHERE {whereClause}";

            try
            {
                con.Open();
                SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                int rows = updateCmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(rows > 0 ? "Update successful!" : "No record found to update.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private void inputPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
