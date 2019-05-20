namespace InputForm
{
    partial class InputForm
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
            this.inputFormMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxPhone = new System.Windows.Forms.TextBox();
            this.inputFormMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputFormMenu
            // 
            this.inputFormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.inputFormMenu.Location = new System.Drawing.Point(0, 0);
            this.inputFormMenu.Name = "inputFormMenu";
            this.inputFormMenu.Size = new System.Drawing.Size(333, 24);
            this.inputFormMenu.TabIndex = 0;
            this.inputFormMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processMenu,
            this.clearMenu,
            this.exitMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // processMenu
            // 
            this.processMenu.Name = "processMenu";
            this.processMenu.Size = new System.Drawing.Size(152, 22);
            this.processMenu.Text = "Process Input";
            this.processMenu.Click += new System.EventHandler(this.processMenu_Click);
            // 
            // clearMenu
            // 
            this.clearMenu.Name = "clearMenu";
            this.clearMenu.Size = new System.Drawing.Size(152, 22);
            this.clearMenu.Text = "Clear Input";
            this.clearMenu.Click += new System.EventHandler(this.clearMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(152, 22);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutmenu});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "&Help";
            // 
            // aboutmenu
            // 
            this.aboutmenu.Name = "aboutmenu";
            this.aboutmenu.Size = new System.Drawing.Size(107, 22);
            this.aboutmenu.Text = "About";
            this.aboutmenu.Click += new System.EventHandler(this.aboutmenu_Click);
            // 
            // txtBxName
            // 
            this.txtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxName.Location = new System.Drawing.Point(95, 36);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(154, 21);
            this.txtBxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxEmail.Location = new System.Drawing.Point(95, 85);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(154, 21);
            this.txtBxEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone";
            // 
            // txtBxPhone
            // 
            this.txtBxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPhone.Location = new System.Drawing.Point(95, 134);
            this.txtBxPhone.Name = "txtBxPhone";
            this.txtBxPhone.Size = new System.Drawing.Size(154, 21);
            this.txtBxPhone.TabIndex = 5;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(333, 289);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.inputFormMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MainMenuStrip = this.inputFormMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InputForm";
            this.Text = "Input Form";
            this.inputFormMenu.ResumeLayout(false);
            this.inputFormMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip inputFormMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processMenu;
        private System.Windows.Forms.ToolStripMenuItem clearMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutmenu;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxPhone;
    }
}

