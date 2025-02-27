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
    }
}
