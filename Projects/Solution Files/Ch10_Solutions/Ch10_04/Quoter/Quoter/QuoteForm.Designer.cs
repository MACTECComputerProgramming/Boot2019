namespace Quoter
{
    partial class QuoteForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.colorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cmboQuote = new System.Windows.Forms.ComboBox();
            this.fontDialogOption = new System.Windows.Forms.FontDialog();
            this.colorDialogOption = new System.Windows.Forms.ColorDialog();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.formatToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "&File";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(152, 22);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontMenu,
            this.colorMenu});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "F&ormat";
            // 
            // fontMenu
            // 
            this.fontMenu.Name = "fontMenu";
            this.fontMenu.Size = new System.Drawing.Size(152, 22);
            this.fontMenu.Text = "Font";
            this.fontMenu.Click += new System.EventHandler(this.fontMenu_Click);
            // 
            // colorMenu
            // 
            this.colorMenu.Name = "colorMenu";
            this.colorMenu.Size = new System.Drawing.Size(152, 22);
            this.colorMenu.Text = "Color";
            this.colorMenu.Click += new System.EventHandler(this.colorMenu_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenu});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(152, 22);
            this.aboutMenu.Text = "About";
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // cmboQuote
            // 
            this.cmboQuote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmboQuote.FormattingEnabled = true;
            this.cmboQuote.Items.AddRange(new object[] {
            "Today is the first day of the rest of your life!",
            "Live life to the fullest!",
            "Laugh as much as you breathe!",
            "We all have ability. The difference is how we use it.",
            "Good luck needs no explanation. ",
            "Common sense ain\'t common.",
            "When in doubt, tell the truth!",
            "Do not try to live for ever. You will not succeed. ",
            "He who laughs last didn\'t get it!",
            "The secret of a happy marriage remains a secret.",
            "The best things in life aren\'t things.",
            "You\'re the only one who can make the difference. ",
            "Whatever your dream is, go for it. ",
            "Live Longer, Laugh More, Love Much!"});
            this.cmboQuote.Location = new System.Drawing.Point(16, 96);
            this.cmboQuote.Name = "cmboQuote";
            this.cmboQuote.Size = new System.Drawing.Size(250, 21);
            this.cmboQuote.TabIndex = 1;
            this.cmboQuote.SelectedIndexChanged += new System.EventHandler(this.cmboQuote_SelectedIndexChanged);
            this.cmboQuote.TextUpdate += new System.EventHandler(this.cmboQuote_TextUpdate);
            // 
            // fontDialogOption
            // 
            this.fontDialogOption.Color = System.Drawing.SystemColors.ControlText;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblMessage.Location = new System.Drawing.Point(13, 216);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type your favorite quote or make a selection from the list below";
            // 
            // QuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(633, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.cmboQuote);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuoteForm";
            this.Text = "Favorite Quotes App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontMenu;
        private System.Windows.Forms.ToolStripMenuItem colorMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ComboBox cmboQuote;
        private System.Windows.Forms.FontDialog fontDialogOption;
        private System.Windows.Forms.ColorDialog colorDialogOption;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label1;
    }
}

