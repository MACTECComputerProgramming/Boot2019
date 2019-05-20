namespace TShirtSalesApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstBxSize = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmboQuantity = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblResult = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size";
            // 
            // lstBxSize
            // 
            this.lstBxSize.FormattingEnabled = true;
            this.lstBxSize.ItemHeight = 20;
            this.lstBxSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "X-Large"});
            this.lstBxSize.Location = new System.Drawing.Point(104, 107);
            this.lstBxSize.Name = "lstBxSize";
            this.lstBxSize.Size = new System.Drawing.Size(133, 84);
            this.lstBxSize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // cmboQuantity
            // 
            this.cmboQuantity.FormattingEnabled = true;
            this.cmboQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmboQuantity.Location = new System.Drawing.Point(295, 107);
            this.cmboQuantity.Name = "cmboQuantity";
            this.cmboQuantity.Size = new System.Drawing.Size(57, 28);
            this.cmboQuantity.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(473, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDisplay,
            this.menuExit});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // menuDisplay
            // 
            this.menuDisplay.Name = "menuDisplay";
            this.menuDisplay.Size = new System.Drawing.Size(145, 22);
            this.menuDisplay.Text = "Display Order";
            this.menuDisplay.Click += new System.EventHandler(this.menuDisplay_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(145, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(174, 249);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(473, 403);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cmboQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstBxSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Computer Club T-Shirt Sales App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBxSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmboQuantity;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDisplay;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Label lblResult;
    }
}

