using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_DB
{
    public partial class InsertData: UserControl
    {
        private SqlConnection con;

        public InsertData()
        {
            InitializeComponent();

            con=new SqlConnection(Program.AuthConnectionString);
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
            string selectedTable = comboBox.SelectedItem.ToString();
            List<string> columns = GetTableColumns(selectedTable);

            int top = 10;
            foreach (string col in columns)
            {
                // Skip auto-increment ID fields in some tables
                if (col.Equals("ID", StringComparison.OrdinalIgnoreCase) &&
                   !(selectedTable.Equals("Cart", StringComparison.OrdinalIgnoreCase) ||
                     selectedTable.Equals("Restaurant_Address", StringComparison.OrdinalIgnoreCase)))
                {
                    continue;
                }

                Label label = new Label() { Text = col, Top = top, Left = 5 };
                System.Windows.Forms.TextBox box = new System.Windows.Forms.TextBox() { Name = "txt" + col, Top = top + 20, Left = 5, Width = 200 };
                inputPanel.Controls.Add(label);
                inputPanel.Controls.Add(box);
                top += 50;
            }
        }

        private List<string> GetTableColumns(string tableName)
        {
            List<string> columns = new List<string>();
            SqlCommand cmd = new SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @table", con);
            cmd.Parameters.AddWithValue("@table", tableName);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read() && reader["COLUMN_NAME"].ToString() != "Age" && (reader["COLUMN_NAME"].ToString() != "Name") || (tableName == "Restaurant"))
            {
                columns.Add(reader["COLUMN_NAME"].ToString());
            }
            reader.Close();
            con.Close();
            return columns;
        }

        private void insertButton_Click(object sender, EventArgs e)
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
            List<string> columnNames = new List<string>();
            List<string> columnValues = new List<string>();

            foreach (Control control in inputPanel.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    string columnName = textBox.Name.Replace("txt", "");
                    columnNames.Add(columnName);

                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        columnValues.Add("NULL");
                    }
                    else
                    {
                        columnValues.Add("'" + textBox.Text.Replace("'", "''") + "'");
                    }
                }
            }

            if (columnNames.Count == 0)
            {
                MessageBox.Show("No input fields found.");
                return;
            }

            string columnsPart = string.Join(", ", columnNames);
            string valuesPart = string.Join(", ", columnValues);
            MessageBox.Show($"INSERT INTO {tableName} ({columnsPart}) VALUES ({valuesPart})");
            string insertQuery = $"INSERT INTO {tableName} ({columnsPart}) VALUES ({valuesPart})";

            try
            {
                con.Open();
                SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                insertCmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message);
                if (con.State == System.Data.ConnectionState.Open) con.Close();
            }
        }

        private void inputPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
