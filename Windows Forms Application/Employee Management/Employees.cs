using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management
{
    public partial class Employees : Form
    {
        Functions func;

        public Employees()
        {
            InitializeComponent();

            func = new Functions();

            ListAllEmployees();
        }

        private void ListAllEmployees()
        {
            string query = "SELECT * FROM Employees";
            EmpDataGrid.DataSource = func.GetData(query);
        }

        //private void label2_Click(object sender, EventArgs e)
        //{

        //}

        //private void label9_Click(object sender, EventArgs e)
        //{

        //}

        private void DeptLabel_Click(object sender, EventArgs e)
        {
            Departments obj = new Departments();
            obj.Show();
            this.Hide();
        }

        private void SalaryLabel_Click(object sender, EventArgs e)
        {
            Salaries obj = new Salaries();
            obj.Show();
            this.Hide();
        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void GetDeparmentsForComboBox()
        {
            string query = "SELECT * FROM Departments";
            EmpDeptComboBox.DisplayMember = func.GetData(query).Columns["DeptName"].ToString();
            EmpDeptComboBox.ValueMember = func.GetData(query).Columns["DeptId"].ToString();
        }

        private void EmpInsertButton_Click(object sender, EventArgs e)
        {

        }
    }
}
