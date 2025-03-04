using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Employee_Management
{
    public partial class Departments : Form
    {
        Functions func;

        public Departments()
        {
            InitializeComponent();

            func = new Functions();

            ListAllDepartments();
        }

        private void ListAllDepartments()
        {
            string query = "SELECT * FROM Departments";
            DeptDataGrid.DataSource = func.GetData(query);
        }

        private void DeptInsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(DeptNameEntry.Text))
                {
                    MessageBox.Show("Enter name of the department!");
                    return;
                }

                // Corrected SQL query with single quotes for string values
                string query = $"INSERT INTO Departments (DeptName) VALUES ('{DeptNameEntry.Text.Replace("'", "''")}')";

                func.SetData(query);
                ListAllDepartments();
                MessageBox.Show("The department has been added successfully!");
                DeptNameEntry.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int deptId = 0;

        private void DeptDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DeptNameEntry.Text = DeptDataGrid.SelectedRows[0].Cells[1].Value.ToString();

            //if (DeptNameEntry.Text == "")
            //{
            //    key = 0;
            //}
            //else
            //{
            //    key = Convert.ToInt32(DeptDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            //}
            //MessageBox.Show($"You selected row {e.RowIndex}");
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                deptId = Convert.ToInt32(DeptDataGrid.Rows[e.RowIndex].Cells[0].Value);
                DeptNameEntry.Text = DeptDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else
                MessageBox.Show("Select a department first!");
        }

        private void DeptUpdateButton_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("You clicked on update button");
            try
            {
                if (string.IsNullOrWhiteSpace(DeptNameEntry.Text))
                {
                    MessageBox.Show("Select department from the list!");
                    return;
                }

                string query = $"UPDATE Departments SET DeptName = '{DeptNameEntry.Text.Replace("'", "''")}' WHERE DeptId = {deptId}";

                func.SetData(query);
                ListAllDepartments();
                MessageBox.Show("The department has been updated successfully!");
                DeptNameEntry.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeptRemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (deptId < 0)
                {
                    MessageBox.Show("Select department from the list!");
                    return;
                }

                string query = $"DELETE FROM Departments WHERE DeptId = {deptId}";

                func.SetData(query);
                ListAllDepartments();
                MessageBox.Show("The department has been removed successfully!");
                DeptNameEntry.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpLabel_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.Show();
            this.Hide();
        }

        private void DeptLabel_Click(object sender, EventArgs e)
        {
            // Do nothing because user is on this form
        }

        private void SalaryLabel_Click(object sender, EventArgs e)
        {
            Salaries obj = new Salaries();
            obj.Show();
            this.Hide();
        }
    }
}
