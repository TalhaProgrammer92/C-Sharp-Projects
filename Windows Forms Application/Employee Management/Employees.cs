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
        public Employees()
        {
            InitializeComponent();

            // Hiding the maximize button of the window
            this.MaximizeBox = false;
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
    }
}
