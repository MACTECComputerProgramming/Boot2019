namespace BagApp
{
    partial class BagForm
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
            this.lstBxSelection = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmboQty = new System.Windows.Forms.ComboBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.rad3Day = new System.Windows.Forms.RadioButton();
            this.radOvernight = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBxSelection
            // 
            this.lstBxSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxSelection.FormattingEnabled = true;
            this.lstBxSelection.ItemHeight = 24;
            this.lstBxSelection.Items.AddRange(new object[] {
            "Beaded - $45",
            "Decorative - $50",
            "Fringed - $25",
            "Leather - $80",
            "Pirate - $40",
            "Plain - $20"});
            this.lstBxSelection.Location = new System.Drawing.Point(64, 40);
            this.lstBxSelection.Margin = new System.Windows.Forms.Padding(4);
            this.lstBxSelection.Name = "lstBxSelection";
            this.lstBxSelection.Size = new System.Drawing.Size(167, 124);
            this.lstBxSelection.Sorted = true;
            this.lstBxSelection.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bag Selection:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quanity Desired";
            // 
            // cmboQty
            // 
            this.cmboQty.FormattingEnabled = true;
            this.cmboQty.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmboQty.Location = new System.Drawing.Point(278, 62);
            this.cmboQty.Name = "cmboQty";
            this.cmboQty.Size = new System.Drawing.Size(39, 26);
            this.cmboQty.TabIndex = 3;
            // 
            // btnProcess
            // 
            this.btnProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProcess.Location = new System.Drawing.Point(235, 288);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(82, 47);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Process Order";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Location = new System.Drawing.Point(332, 288);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 47);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear Selections";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Location = new System.Drawing.Point(91, 185);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 18);
            this.lblErrorMsg.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radStandard);
            this.groupBox1.Controls.Add(this.rad3Day);
            this.groupBox1.Controls.Add(this.radOvernight);
            this.groupBox1.Location = new System.Drawing.Point(20, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 113);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shipping";
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Location = new System.Drawing.Point(12, 82);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(120, 22);
            this.radStandard.TabIndex = 2;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard (5%)";
            this.radStandard.UseVisualStyleBackColor = true;
            // 
            // rad3Day
            // 
            this.rad3Day.AutoSize = true;
            this.rad3Day.Location = new System.Drawing.Point(12, 53);
            this.rad3Day.Name = "rad3Day";
            this.rad3Day.Size = new System.Drawing.Size(100, 22);
            this.rad3Day.TabIndex = 1;
            this.rad3Day.TabStop = true;
            this.rad3Day.Text = "3-Day (7%)";
            this.rad3Day.UseVisualStyleBackColor = true;
            // 
            // radOvernight
            // 
            this.radOvernight.AutoSize = true;
            this.radOvernight.Location = new System.Drawing.Point(12, 24);
            this.radOvernight.Name = "radOvernight";
            this.radOvernight.Size = new System.Drawing.Size(132, 22);
            this.radOvernight.TabIndex = 0;
            this.radOvernight.TabStop = true;
            this.radOvernight.Text = "Overnight (10%)";
            this.radOvernight.UseVisualStyleBackColor = true;
            // 
            // BagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(426, 363);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.cmboQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBxSelection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BagForm";
            this.Text = "Bag Order App";
            this.Load += new System.EventHandler(this.BagForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmboQty;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.RadioButton rad3Day;
        private System.Windows.Forms.RadioButton radOvernight;
    }
}

