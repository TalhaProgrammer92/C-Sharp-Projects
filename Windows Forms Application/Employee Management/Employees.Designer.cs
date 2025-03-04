namespace Employee_Management
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EmpNameEntry = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            EmpDailySalaryEntry = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            EmpGenderComboBox = new ComboBox();
            EmpDeptComboBox = new ComboBox();
            EmpInsertButton = new Button();
            EmpUpdateButton = new Button();
            EmpLabel = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            DeptLabel = new Label();
            pictureBox4 = new PictureBox();
            SalaryLabel = new Label();
            pictureBox5 = new PictureBox();
            LogOutLabel = new Label();
            EmpDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            EmpDOBPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            EmpDOJPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmpDataGrid).BeginInit();
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
            panel1.TabIndex = 0;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(723, 141);
            label2.Name = "label2";
            label2.Size = new Size(148, 21);
            label2.TabIndex = 2;
            label2.Text = "List of Employees";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(12, 153);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 7;
            label3.Text = "Name";
            // 
            // EmpNameEntry
            // 
            EmpNameEntry.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpNameEntry.Location = new Point(12, 176);
            EmpNameEntry.Name = "EmpNameEntry";
            EmpNameEntry.Size = new Size(257, 26);
            EmpNameEntry.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(12, 217);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 9;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(12, 278);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 11;
            label5.Text = "Department";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(12, 341);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 13;
            label6.Text = "Date of Birth";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(12, 408);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 15;
            label7.Text = "Date of Join";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(12, 479);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 17;
            label8.Text = "Daily Salary";
            // 
            // EmpDailySalaryEntry
            // 
            EmpDailySalaryEntry.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpDailySalaryEntry.Location = new Point(12, 502);
            EmpDailySalaryEntry.Name = "EmpDailySalaryEntry";
            EmpDailySalaryEntry.Size = new Size(257, 26);
            EmpDailySalaryEntry.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 614);
            panel2.Name = "panel2";
            panel2.Size = new Size(1264, 67);
            panel2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // EmpGenderComboBox
            // 
            EmpGenderComboBox.FormattingEnabled = true;
            EmpGenderComboBox.Items.AddRange(new object[] { "Male", "Female" });
            EmpGenderComboBox.Location = new Point(12, 240);
            EmpGenderComboBox.Name = "EmpGenderComboBox";
            EmpGenderComboBox.Size = new Size(257, 29);
            EmpGenderComboBox.TabIndex = 20;
            // 
            // EmpDeptComboBox
            // 
            EmpDeptComboBox.FormattingEnabled = true;
            EmpDeptComboBox.Location = new Point(12, 301);
            EmpDeptComboBox.Name = "EmpDeptComboBox";
            EmpDeptComboBox.Size = new Size(257, 29);
            EmpDeptComboBox.TabIndex = 21;
            // 
            // EmpInsertButton
            // 
            EmpInsertButton.BackColor = Color.Teal;
            EmpInsertButton.FlatStyle = FlatStyle.Flat;
            EmpInsertButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpInsertButton.ForeColor = SystemColors.ButtonFace;
            EmpInsertButton.Location = new Point(21, 543);
            EmpInsertButton.Name = "EmpInsertButton";
            EmpInsertButton.Size = new Size(99, 45);
            EmpInsertButton.TabIndex = 25;
            EmpInsertButton.Text = "INSERT";
            EmpInsertButton.UseVisualStyleBackColor = false;
            // 
            // EmpUpdateButton
            // 
            EmpUpdateButton.BackColor = Color.Teal;
            EmpUpdateButton.FlatStyle = FlatStyle.Flat;
            EmpUpdateButton.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpUpdateButton.ForeColor = SystemColors.ButtonFace;
            EmpUpdateButton.Location = new Point(160, 543);
            EmpUpdateButton.Name = "EmpUpdateButton";
            EmpUpdateButton.Size = new Size(99, 45);
            EmpUpdateButton.TabIndex = 26;
            EmpUpdateButton.Text = "UPDATE";
            EmpUpdateButton.UseVisualStyleBackColor = false;
            // 
            // EmpLabel
            // 
            EmpLabel.AutoSize = true;
            EmpLabel.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            EmpLabel.ForeColor = Color.Teal;
            EmpLabel.Location = new Point(439, 89);
            EmpLabel.Name = "EmpLabel";
            EmpLabel.Size = new Size(78, 20);
            EmpLabel.TabIndex = 27;
            EmpLabel.Text = "Employees";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(412, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(549, 89);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 30;
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
            DeptLabel.TabIndex = 29;
            DeptLabel.Text = "Departments";
            DeptLabel.Click += DeptLabel_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(687, 89);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 32;
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
            SalaryLabel.TabIndex = 31;
            SalaryLabel.Text = "Salaries";
            SalaryLabel.Click += SalaryLabel_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(798, 89);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(21, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 34;
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
            LogOutLabel.TabIndex = 33;
            LogOutLabel.Text = "Log Out";
            LogOutLabel.Click += LogOutLabel_Click;
            // 
            // EmpDataGrid
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            EmpDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            EmpDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            EmpDataGrid.ColumnHeadersHeight = 25;
            EmpDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            EmpDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            EmpDataGrid.GridColor = Color.FromArgb(231, 229, 255);
            EmpDataGrid.Location = new Point(328, 176);
            EmpDataGrid.Name = "EmpDataGrid";
            EmpDataGrid.RowHeadersVisible = false;
            EmpDataGrid.Size = new Size(912, 412);
            EmpDataGrid.TabIndex = 44;
            EmpDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            EmpDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            EmpDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            EmpDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            EmpDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            EmpDataGrid.ThemeStyle.BackColor = Color.White;
            EmpDataGrid.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            EmpDataGrid.ThemeStyle.HeaderStyle.BackColor = Color.Teal;
            EmpDataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            EmpDataGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpDataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            EmpDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            EmpDataGrid.ThemeStyle.HeaderStyle.Height = 25;
            EmpDataGrid.ThemeStyle.ReadOnly = false;
            EmpDataGrid.ThemeStyle.RowsStyle.BackColor = Color.White;
            EmpDataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            EmpDataGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpDataGrid.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            EmpDataGrid.ThemeStyle.RowsStyle.Height = 25;
            EmpDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            EmpDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // EmpDOBPicker
            // 
            EmpDOBPicker.Checked = true;
            EmpDOBPicker.CustomizableEdges = customizableEdges1;
            EmpDOBPicker.FillColor = Color.Teal;
            EmpDOBPicker.Font = new Font("Segoe UI", 9F);
            EmpDOBPicker.Format = DateTimePickerFormat.Long;
            EmpDOBPicker.Location = new Point(12, 364);
            EmpDOBPicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            EmpDOBPicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            EmpDOBPicker.Name = "EmpDOBPicker";
            EmpDOBPicker.ShadowDecoration.CustomizableEdges = customizableEdges2;
            EmpDOBPicker.Size = new Size(257, 36);
            EmpDOBPicker.TabIndex = 45;
            EmpDOBPicker.Value = new DateTime(2025, 3, 2, 11, 28, 39, 325);
            // 
            // EmpDOJPicker
            // 
            EmpDOJPicker.Checked = true;
            EmpDOJPicker.CustomizableEdges = customizableEdges3;
            EmpDOJPicker.FillColor = Color.Teal;
            EmpDOJPicker.Font = new Font("Segoe UI", 9F);
            EmpDOJPicker.Format = DateTimePickerFormat.Long;
            EmpDOJPicker.Location = new Point(12, 431);
            EmpDOJPicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            EmpDOJPicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            EmpDOJPicker.Name = "EmpDOJPicker";
            EmpDOJPicker.ShadowDecoration.CustomizableEdges = customizableEdges4;
            EmpDOJPicker.Size = new Size(257, 36);
            EmpDOJPicker.TabIndex = 46;
            EmpDOJPicker.Value = new DateTime(2025, 3, 2, 11, 28, 39, 325);
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(EmpDOJPicker);
            Controls.Add(EmpDOBPicker);
            Controls.Add(EmpDataGrid);
            Controls.Add(pictureBox5);
            Controls.Add(LogOutLabel);
            Controls.Add(pictureBox4);
            Controls.Add(SalaryLabel);
            Controls.Add(pictureBox3);
            Controls.Add(DeptLabel);
            Controls.Add(pictureBox2);
            Controls.Add(EmpLabel);
            Controls.Add(EmpUpdateButton);
            Controls.Add(EmpInsertButton);
            Controls.Add(EmpDeptComboBox);
            Controls.Add(EmpGenderComboBox);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label8);
            Controls.Add(EmpDailySalaryEntry);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(EmpNameEntry);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Employees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employees";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmpDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox EmpNameEntry;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox EmpDailySalaryEntry;
        private Panel panel2;
        private PictureBox pictureBox1;
        private ComboBox EmpGenderComboBox;
        private ComboBox EmpDeptComboBox;
        private Button EmpInsertButton;
        private Button EmpUpdateButton;
        private Label EmpLabel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label DeptLabel;
        private PictureBox pictureBox4;
        private Label SalaryLabel;
        private PictureBox pictureBox5;
        private Label LogOutLabel;
        private Guna.UI2.WinForms.Guna2DataGridView EmpDataGrid;
        private Guna.UI2.WinForms.Guna2DateTimePicker EmpDOBPicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker EmpDOJPicker;
    }
}