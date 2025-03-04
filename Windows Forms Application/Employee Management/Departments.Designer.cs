namespace Employee_Management
{
    partial class Departments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            DeptUpdateButton = new Button();
            DeptInsertButton = new Button();
            label3 = new Label();
            DeptNameEntry = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            LogOutLabel = new Label();
            pictureBox4 = new PictureBox();
            SalaryLabel = new Label();
            pictureBox3 = new PictureBox();
            DeptLabel = new Label();
            pictureBox2 = new PictureBox();
            EmpLabel = new Label();
            DeptDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            DeptRemoveButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeptDataGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 83);
            panel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(509, 34);
            label1.Name = "label1";
            label1.Size = new Size(240, 21);
            label1.TabIndex = 1;
            label1.Text = "Employee Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 614);
            panel2.Name = "panel2";
            panel2.Size = new Size(1264, 67);
            panel2.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(723, 141);
            label2.Name = "label2";
            label2.Size = new Size(167, 21);
            label2.TabIndex = 20;
            label2.Text = "List of Departments";
            // 
            // DeptUpdateButton
            // 
            DeptUpdateButton.BackColor = Color.Teal;
            DeptUpdateButton.FlatStyle = FlatStyle.Flat;
            DeptUpdateButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeptUpdateButton.ForeColor = SystemColors.ButtonFace;
            DeptUpdateButton.Location = new Point(164, 219);
            DeptUpdateButton.Name = "DeptUpdateButton";
            DeptUpdateButton.Size = new Size(99, 45);
            DeptUpdateButton.TabIndex = 31;
            DeptUpdateButton.Text = "UPDATE";
            DeptUpdateButton.UseVisualStyleBackColor = false;
            DeptUpdateButton.Click += DeptUpdateButton_Click_1;
            // 
            // DeptInsertButton
            // 
            DeptInsertButton.BackColor = Color.Teal;
            DeptInsertButton.FlatStyle = FlatStyle.Flat;
            DeptInsertButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeptInsertButton.ForeColor = SystemColors.ButtonFace;
            DeptInsertButton.Location = new Point(29, 219);
            DeptInsertButton.Name = "DeptInsertButton";
            DeptInsertButton.Size = new Size(99, 45);
            DeptInsertButton.TabIndex = 30;
            DeptInsertButton.Text = "INSERT";
            DeptInsertButton.UseVisualStyleBackColor = false;
            DeptInsertButton.Click += DeptInsertButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(12, 154);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 28;
            label3.Text = "Name";
            // 
            // DeptNameEntry
            // 
            DeptNameEntry.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeptNameEntry.Location = new Point(12, 177);
            DeptNameEntry.Name = "DeptNameEntry";
            DeptNameEntry.Size = new Size(257, 26);
            DeptNameEntry.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(116, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(798, 89);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(21, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 42;
            pictureBox5.TabStop = false;
            // 
            // LogOutLabel
            // 
            LogOutLabel.AutoSize = true;
            LogOutLabel.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            LogOutLabel.ForeColor = Color.Teal;
            LogOutLabel.Location = new Point(825, 89);
            LogOutLabel.Name = "LogOutLabel";
            LogOutLabel.Size = new Size(59, 20);
            LogOutLabel.TabIndex = 41;
            LogOutLabel.Text = "Log Out";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(687, 89);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 40;
            pictureBox4.TabStop = false;
            // 
            // SalaryLabel
            // 
            SalaryLabel.AutoSize = true;
            SalaryLabel.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            SalaryLabel.ForeColor = Color.Teal;
            SalaryLabel.Location = new Point(714, 89);
            SalaryLabel.Name = "SalaryLabel";
            SalaryLabel.Size = new Size(59, 20);
            SalaryLabel.TabIndex = 39;
            SalaryLabel.Text = "Salaries";
            SalaryLabel.Click += SalaryLabel_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(549, 89);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 38;
            pictureBox3.TabStop = false;
            // 
            // DeptLabel
            // 
            DeptLabel.AutoSize = true;
            DeptLabel.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            DeptLabel.ForeColor = Color.Teal;
            DeptLabel.Location = new Point(576, 89);
            DeptLabel.Name = "DeptLabel";
            DeptLabel.Size = new Size(87, 20);
            DeptLabel.TabIndex = 37;
            DeptLabel.Text = "Departments";
            DeptLabel.Click += DeptLabel_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(412, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // EmpLabel
            // 
            EmpLabel.AutoSize = true;
            EmpLabel.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            EmpLabel.ForeColor = Color.Teal;
            EmpLabel.Location = new Point(439, 89);
            EmpLabel.Name = "EmpLabel";
            EmpLabel.Size = new Size(78, 20);
            EmpLabel.TabIndex = 35;
            EmpLabel.Text = "Employees";
            EmpLabel.Click += EmpLabel_Click;
            // 
            // DeptDataGrid
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DeptDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DeptDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DeptDataGrid.ColumnHeadersHeight = 25;
            DeptDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DeptDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            DeptDataGrid.GridColor = Color.FromArgb(231, 229, 255);
            DeptDataGrid.Location = new Point(328, 176);
            DeptDataGrid.Name = "DeptDataGrid";
            DeptDataGrid.RowHeadersVisible = false;
            DeptDataGrid.Size = new Size(912, 412);
            DeptDataGrid.TabIndex = 43;
            DeptDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DeptDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            DeptDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DeptDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DeptDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DeptDataGrid.ThemeStyle.BackColor = Color.White;
            DeptDataGrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DeptDataGrid.ThemeStyle.HeaderStyle.BackColor = Color.Teal;
            DeptDataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DeptDataGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeptDataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DeptDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DeptDataGrid.ThemeStyle.HeaderStyle.Height = 25;
            DeptDataGrid.ThemeStyle.ReadOnly = false;
            DeptDataGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            DeptDataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DeptDataGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeptDataGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DeptDataGrid.ThemeStyle.RowsStyle.Height = 25;
            DeptDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DeptDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DeptDataGrid.CellContentClick += DeptDataGrid_CellContentClick;
            // 
            // DeptRemoveButton
            // 
            DeptRemoveButton.BackColor = Color.Teal;
            DeptRemoveButton.FlatStyle = FlatStyle.Flat;
            DeptRemoveButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeptRemoveButton.ForeColor = SystemColors.ButtonFace;
            DeptRemoveButton.Location = new Point(97, 270);
            DeptRemoveButton.Name = "DeptRemoveButton";
            DeptRemoveButton.Size = new Size(99, 45);
            DeptRemoveButton.TabIndex = 44;
            DeptRemoveButton.Text = "REMOVE";
            DeptRemoveButton.UseVisualStyleBackColor = false;
            DeptRemoveButton.Click += DeptRemoveButton_Click;
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(DeptRemoveButton);
            Controls.Add(DeptDataGrid);
            Controls.Add(pictureBox5);
            Controls.Add(LogOutLabel);
            Controls.Add(pictureBox4);
            Controls.Add(SalaryLabel);
            Controls.Add(pictureBox3);
            Controls.Add(DeptLabel);
            Controls.Add(pictureBox2);
            Controls.Add(EmpLabel);
            Controls.Add(pictureBox1);
            Controls.Add(DeptUpdateButton);
            Controls.Add(DeptInsertButton);
            Controls.Add(label3);
            Controls.Add(DeptNameEntry);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Departments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Departments";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeptDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button DeptUpdateButton;
        private Button DeptInsertButton;
        private Label label3;
        private TextBox DeptNameEntry;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private Label LogOutLabel;
        private PictureBox pictureBox4;
        private Label SalaryLabel;
        private PictureBox pictureBox3;
        private Label DeptLabel;
        private PictureBox pictureBox2;
        private Label EmpLabel;
        private Guna.UI2.WinForms.Guna2DataGridView DeptDataGrid;
        private Button DeptRemoveButton;
    }
}