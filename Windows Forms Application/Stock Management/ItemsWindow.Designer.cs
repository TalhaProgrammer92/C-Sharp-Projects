namespace Stock_Management
{
    partial class ItemsWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsWindow));
            ItemManagerContextMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            SuspendLayout();
            // 
            // ItemManagerContextMenuStrip
            // 
            ItemManagerContextMenuStrip.Name = "ItemManagerContextMenuStrip";
            ItemManagerContextMenuStrip.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            ItemManagerContextMenuStrip.RenderStyle.BorderColor = Color.Gainsboro;
            ItemManagerContextMenuStrip.RenderStyle.ColorTable = null;
            ItemManagerContextMenuStrip.RenderStyle.RoundedEdges = true;
            ItemManagerContextMenuStrip.RenderStyle.SelectionArrowColor = Color.White;
            ItemManagerContextMenuStrip.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            ItemManagerContextMenuStrip.RenderStyle.SelectionForeColor = Color.White;
            ItemManagerContextMenuStrip.RenderStyle.SeparatorColor = Color.Gainsboro;
            ItemManagerContextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            ItemManagerContextMenuStrip.Size = new Size(61, 4);
            // 
            // ItemsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ItemsWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Items Manager";
            Load += this.ItemsWindow_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContextMenuStrip ItemManagerContextMenuStrip;
    }
}
