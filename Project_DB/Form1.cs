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
using System.Data.SqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Project_DB
{
    public partial class Form1 : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        private DataTable dt;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(Program.AuthConnectionString);
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;

            comboBox.Text = "Select Table";
            comboBox.Items.Add("Cart");
            comboBox.Items.Add("Cart_MenuItem");
            comboBox.Items.Add("Customer");
            comboBox.Items.Add("Employee");
            comboBox.Items.Add("Menu_Item");
            comboBox.Items.Add("Order_MenuItem");
            comboBox.Items.Add("Order");
            comboBox.Items.Add("Restaurant");
            comboBox.Items.Add("Restaurant_Address");
            comboBox.Items.Add("User");
        }

        private List<string> primaryKeys = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox.Visible = false;
            readButton.Visible = false;
            dataGridView.Visible = false;
            checkedListBox.Visible = false;
            ascRadio.Visible = false;
            descRadio.Visible = false;
            insertRadioButton.Visible = false;
            updateRadioButton.Visible = false;
            orderBox.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            deleteButton.Visible = false;
            inputPanel.Visible = false;
            insertButton.Visible = false;
            updateButton.Visible = false;

            viewDataButton.Click += ViewDataButton_Click;
            insertDataButton.Click += InsertDataButton_Click;
            updateDataButton.Click += UpdateDataButton_Click;
            deleteDataButton.Click += DeleteDataButton_Click;
            operationsButton.Click += OperationsButton_Click;
            logOutButton.Click += logOutButton_Click_1;
            ExitButton.Click += button1_Click;

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

            string order = "NO ORDER";
            if (ascRadio.Checked) order = "ASC";
            else if (descRadio.Checked) order = "DESC";

            if (order == "NO ORDER")
            {
                cmd = new SqlCommand("SELECT " + colString + " FROM " + comboBox.SelectedItem.ToString(), con);
            }
            else
            {
                cmd = new SqlCommand("SELECT " + colString + " FROM " + comboBox.SelectedItem.ToString()
                    + " ORDER BY " + orderBox.SelectedItem.ToString() + " " + order, con);
            }

            rdr = cmd.ExecuteReader();

            dt = new DataTable();
            dt.Load(rdr);
            dataGridView.DataSource = dt;

            con.Close();
            rdr.Close();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // prevent read button and order box when no selection
            if (comboBox.SelectedItem != null)
            {
                readButton.Enabled = true;
                orderBox.Enabled = true;
            }
            inputPanel.Controls.Clear();
            string selectedTable = comboBox.SelectedItem.ToString();
            List<string> columns = GetTableColumns(selectedTable);
            inputPanel.Controls.Clear();
            int top = 10;
            foreach (string col in columns)
            {
                if (insertRadioButton.Checked) { 
                if (col.Equals("ID", StringComparison.OrdinalIgnoreCase) &&
                  !(selectedTable.Equals("Cart", StringComparison.OrdinalIgnoreCase) ||
                    selectedTable.Equals("Restaurant_Address", StringComparison.OrdinalIgnoreCase)))
                {
                    continue;
                }
            }

                if (col.Equals("Age", StringComparison.OrdinalIgnoreCase))
                    continue; // Skip derived column

                Label label = new Label() { Text = col, Top = top, Left = 5 };
                System.Windows.Forms.TextBox box = new System.Windows.Forms.TextBox() { Name = "txt" + col, Top = top + 20, Left = 5, Width = 200 };
                inputPanel.Controls.Add(label);
                inputPanel.Controls.Add(box);
                top += 50;
            }





            // con.Open();

            // Get primary key columns for the selected table
            SqlCommand pkCmd = new SqlCommand("EXEC sp_pkeys '" + comboBox.SelectedItem.ToString() + "'", con);
            SqlDataReader pkReader = pkCmd.ExecuteReader();

            primaryKeys = new List<string>();

            while (pkReader.Read())
            {
                primaryKeys.Add(pkReader["COLUMN_NAME"].ToString());
            }
            pkReader.Close();

            cmd = new SqlCommand("SELECT * FROM " + comboBox.SelectedItem.ToString(), con);
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
                if (primaryKeys.Contains(rdr.GetName(i)))
                {
                    checkedListBox.ItemCheck += (sender2, ev) =>
                    {
                        if (primaryKeys.Contains(checkedListBox.Items[ev.Index].ToString()) && ev.NewValue == CheckState.Unchecked)
                        {
                            ev.NewValue = CheckState.Checked;
                        }
                    };
                }
            }

            con.Close();
            rdr.Close();
        }

        // prevent read button when no columns are checked
        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
        }

        private void orderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderBox.SelectedItem != null && (string)orderBox.SelectedItem != "No order")
            {
                ascRadio.Checked = true;

                ascRadio.Enabled = true;
                descRadio.Enabled = true;
            }
            else
            {
                ascRadio.Checked = false;
                descRadio.Checked = false;

                ascRadio.Enabled = false;
                descRadio.Enabled = false;
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0 && !dataGridView.SelectedRows[0].IsNewRow)
            {
                deleteButton.Enabled = true;
            }
            else
            {
                deleteButton.Enabled = false;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();


                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    if (row.IsNewRow) continue;

                    string deleteQuery = "DELETE FROM " + comboBox.SelectedItem.ToString() + " WHERE ";

                    List<string> conditions = new List<string>();

                    foreach (string pk in primaryKeys)
                    {
                        string pkValue = row.Cells[pk].Value.ToString();
                        conditions.Add(pk + " = '" + pkValue + "'");
                    }

                    deleteQuery += string.Join(" AND ", conditions);
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                    deleteCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Record(s) deleted successfully!");

                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM " + comboBox.SelectedItem.ToString(), con);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        // New Insert Button Handler
        private void insertButton_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a table first.");
                return;
            }

            string tableName = comboBox.SelectedItem.ToString();

            List<string> columnNames = new List<string>();
            List<string> columnValues = new List<string>();

            foreach (Control control in inputPanel.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    string columnName = textBox.Name.Replace("txt", ""); // assumes naming like txtName => Name
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
            string insertQuery = $"INSERT INTO {tableName} ({columnsPart}) VALUES ({valuesPart})";

            try
            {
                con.Open();
                SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                insertCmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Record inserted successfully!");

                // Reload data
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM " + tableName, con);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private List<string> GetTableColumns(string tableName)
        {
            List<string> columns = new List<string>();
            using (SqlCommand cmd = new SqlCommand(
                "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @table", con))
            {
                cmd.Parameters.AddWithValue("@table", tableName);
                if (con.State != ConnectionState.Open) con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    columns.Add(reader["COLUMN_NAME"].ToString());
                }
                reader.Close();
            }
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
            List<string> setClauses = new List<string>();
            string whereClause = "";

            foreach (Control control in inputPanel.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    string columnName = textBox.Name.Replace("txt", "");
                    string value = textBox.Text.Trim(); // remove leading/trailing spaces

                    if (primaryKeys.Contains(columnName))
                    {
                        // WHERE clause (primary keys shouldn't be null or empty ideally)
                        if (string.Equals(value, "null", StringComparison.OrdinalIgnoreCase))
                        {
                            whereClause += $"{columnName} IS NULL AND ";
                        }
                        else if (!string.IsNullOrWhiteSpace(value))
                        {
                            whereClause += $"{columnName} = '{value.Replace("'", "''")}' AND ";
                        }
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(value))
                        {
                            // Skip setting this column at all
                            continue;
                        }
                        else if (string.Equals(value, "null", StringComparison.OrdinalIgnoreCase))
                        {
                            setClauses.Add($"{columnName} = NULL");
                        }
                        else
                        {
                            setClauses.Add($"{columnName} = '{value.Replace("'", "''")}'");
                        }
                    }
                }
            }

            if (string.IsNullOrEmpty(whereClause))
            {
                MessageBox.Show("Primary key value is required to update the record.");
                return;
            }

            if (setClauses.Count == 0)
            {
                MessageBox.Show("No fields to update.");
                return;
            }

            // Remove trailing AND from WHERE clause
            whereClause = whereClause.Substring(0, whereClause.Length - 5);

            string updateQuery = $"UPDATE {tableName} SET {string.Join(", ", setClauses)} WHERE {whereClause}";

            try
            {
                con.Open();
                SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                updateCmd.ExecuteNonQuery();
                int rowsAffected = updateCmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Update failed: no matching record found.");
                }
                else
                {
                    MessageBox.Show("Update successful.");
                }

                con.Close();

              

                // Refresh DataGridView
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM " + tableName, con);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
        }










        private string GetValueForColumn(string columnName)
        {
            if (columnName == "Column1")
                return textBox1.Text;
            else if (columnName == "Column2")
                return textBox2.Text;
            else if (columnName == "Column3")
                return textBox3.Text;

            // Add more mappings as needed
            return null;
        }

        private void inputPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //GUI 

        private void ShowViewDataControls()
        {
            
            comboBox.Visible = true;
            readButton.Visible = true;
            dataGridView.Visible = true;
            checkedListBox.Visible = true;
            ascRadio.Visible = true;
            descRadio.Visible = true;
            orderBox.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void ShowInsertControls()
        {
            
            comboBox.Visible = true;
            inputPanel.Visible = true;
            insertButton.Visible = true;
            label2.Visible = true;
        }

        private void ShowUpdateControls()
        {
          
            comboBox.Visible = true;
            inputPanel.Visible = true;
            updateButton.Visible = true;
            label2.Visible = true;
        }

        private void ShowDeleteControls()
        {
            
            comboBox.Visible = true;
            dataGridView.Visible = true;
            deleteButton.Visible = true;
            label2.Visible = true;
        }

        private void ShowUserControl(UserControl control)
        {
            foreach (Control c in mainPanel.Controls)
            {
                c.Visible = false;
            }

            if (!mainPanel.Controls.Contains(control))
            {
                control.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(control);
            }

            control.Visible = true;
            control.BringToFront();
        }


        private void ViewDataButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var readView = new ViewData();
            readView.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(readView); // or add to a central panel
            readView.BringToFront();
         
    
            HighlightActiveButton(viewDataButton);
        }

        private void InsertDataButton_Click(object sender, EventArgs e)
        {

            ShowUserControl(new InsertData());


            HighlightActiveButton(insertDataButton);
        }

        private void UpdateDataButton_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UpdateData());


            HighlightActiveButton(updateDataButton);
        }

        private void DeleteDataButton_Click(object sender, EventArgs e)
        {
            ShowUserControl(new DeleteData());


            HighlightActiveButton(deleteDataButton);
        }

        private void OperationsButton_Click(object sender, EventArgs e)
        {

            ShowUserControl(new CustomerOrders());


            HighlightActiveButton(operationsButton);
        }


        private void HighlightActiveButton(System.Windows.Forms.Button activeButton)
        {
            // Reset all buttons
            viewDataButton.BackColor = Color.SteelBlue;
            insertDataButton.BackColor = Color.SteelBlue;
            updateDataButton.BackColor = Color.SteelBlue;
            deleteDataButton.BackColor = Color.SteelBlue;
            operationsButton.BackColor = Color.SteelBlue;

            // Highlight active button
            activeButton.BackColor = Color.DodgerBlue;
        }

        private void HideAllContentControls()
        {
            // List of all controls that should be hidden when switching views
            var contentControls = new List<Control>
                {
                    comboBox,
                    readButton,
                    dataGridView,
                    checkedListBox,
                    ascRadio,
                    descRadio,
                    insertRadioButton,
                    updateRadioButton,
                    orderBox,
                    label1,
                    label2,
                    deleteButton,
                    inputPanel,
                    insertButton,
                    updateButton
                };

            foreach (var control in contentControls)
            {
                control.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOutButton_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


