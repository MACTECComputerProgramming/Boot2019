namespace BankingApp
{
    partial class BankingForm
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
            this.cmboTypeOfAccount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBxChecking = new System.Windows.Forms.ListBox();
            this.lstBxSavings = new System.Windows.Forms.ListBox();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display Account Details";
            // 
            // cmboTypeOfAccount
            // 
            this.cmboTypeOfAccount.FormattingEnabled = true;
            this.cmboTypeOfAccount.Items.AddRange(new object[] {
            "Savings",
            "Checking"});
            this.cmboTypeOfAccount.Location = new System.Drawing.Point(23, 100);
            this.cmboTypeOfAccount.Name = "cmboTypeOfAccount";
            this.cmboTypeOfAccount.Size = new System.Drawing.Size(121, 24);
            this.cmboTypeOfAccount.TabIndex = 1;
            this.cmboTypeOfAccount.SelectedIndexChanged += new System.EventHandler(this.cmboTypeOfAccount_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type of Account:";
            // 
            // lstBxChecking
            // 
            this.lstBxChecking.FormattingEnabled = true;
            this.lstBxChecking.ItemHeight = 16;
            this.lstBxChecking.Location = new System.Drawing.Point(187, 100);
            this.lstBxChecking.Name = "lstBxChecking";
            this.lstBxChecking.Size = new System.Drawing.Size(120, 84);
            this.lstBxChecking.TabIndex = 3;
            this.lstBxChecking.Visible = false;
            this.lstBxChecking.SelectedIndexChanged += new System.EventHandler(this.lstBxChecking_SelectedIndexChanged);
            // 
            // lstBxSavings
            // 
            this.lstBxSavings.FormattingEnabled = true;
            this.lstBxSavings.ItemHeight = 16;
            this.lstBxSavings.Location = new System.Drawing.Point(187, 100);
            this.lstBxSavings.Name = "lstBxSavings";
            this.lstBxSavings.Size = new System.Drawing.Size(120, 84);
            this.lstBxSavings.TabIndex = 4;
            this.lstBxSavings.Visible = false;
            this.lstBxSavings.SelectedIndexChanged += new System.EventHandler(this.lstBxSavings_SelectedIndexChanged);
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(201, 79);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(75, 17);
            this.lblCustomers.TabIndex = 5;
            this.lblCustomers.Text = "Customers";
            this.lblCustomers.Visible = false;
            // 
            // BankingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.lstBxSavings);
            this.Controls.Add(this.lstBxChecking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmboTypeOfAccount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BankingForm";
            this.Text = "C...&...Z Banking";
            this.Load += new System.EventHandler(this.BankingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboTypeOfAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBxChecking;
        private System.Windows.Forms.ListBox lstBxSavings;
        private System.Windows.Forms.Label lblCustomers;
    }
}

