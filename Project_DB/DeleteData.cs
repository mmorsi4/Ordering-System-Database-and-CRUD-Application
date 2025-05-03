using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_DB
{
    public partial class DeleteData : UserControl
    {
        private SqlConnection con;
        private List<string> primaryKeys = new List<string>();

        public DeleteData()
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
            if (comboBox.SelectedItem == null) return;

            string selectedTable = comboBox.SelectedItem.ToString();

            // Get primary keys
            SqlCommand pkCmd = new SqlCommand("EXEC sp_pkeys '" + selectedTable + "'", con);
            con.Open();
            SqlDataReader pkReader = pkCmd.ExecuteReader();
            primaryKeys.Clear();
            while (pkReader.Read())
            {
                primaryKeys.Add(pkReader["COLUMN_NAME"].ToString());
            }
            pkReader.Close();

            // Load data
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + selectedTable, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem == null || dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a table and at least one row.");
                return;
            }

            string tableName = comboBox.SelectedItem.ToString();
            if (comboBox.SelectedItem.ToString() == "User" || comboBox.SelectedItem.ToString() == "Order")
            {
                tableName = $"[{comboBox.SelectedItem.ToString()}]";
            }
            try
            {
                con.Open();

                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    if (row.IsNewRow) continue;

                    List<string> conditions = new List<string>();

                    foreach (string pk in primaryKeys)
                    {
                        string pkValue = row.Cells[pk].Value?.ToString();
                        if (pkValue == null)
                        {
                            MessageBox.Show($"Primary key value missing: {pk}");
                            return;
                        }

                        conditions.Add($"{pk} = '{pkValue.Replace("'", "''")}'");
                    }

                    string deleteQuery = $"DELETE FROM {tableName} WHERE {string.Join(" AND ", conditions)}";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                    deleteCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Selected record(s) deleted.");

                // Reload data
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + tableName, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting records: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
