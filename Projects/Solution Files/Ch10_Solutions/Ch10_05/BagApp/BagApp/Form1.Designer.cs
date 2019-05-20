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
            this.SuspendLayout();
            // 
            // lstBxSelection
            // 
            this.lstBxSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxSelection.FormattingEnabled = true;
            this.lstBxSelection.ItemHeight = 24;
            this.lstBxSelection.Items.AddRange(new object[] {
            "Decorative",
            "Beaded",
            "Fringed",
            "Leather",
            "Pirate",
            "Plain"});
            this.lstBxSelection.Location = new System.Drawing.Point(71, 52);
            this.lstBxSelection.Margin = new System.Windows.Forms.Padding(4);
            this.lstBxSelection.Name = "lstBxSelection";
            this.lstBxSelection.Size = new System.Drawing.Size(130, 124);
            this.lstBxSelection.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bag Selection:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quanity Desired:";
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
            this.cmboQty.Location = new System.Drawing.Point(273, 86);
            this.cmboQty.Name = "cmboQty";
            this.cmboQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmboQty.Size = new System.Drawing.Size(39, 26);
            this.cmboQty.TabIndex = 3;
            // 
            // btnProcess
            // 
            this.btnProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProcess.Location = new System.Drawing.Point(101, 236);
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
            this.btnClear.Location = new System.Drawing.Point(243, 236);
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
            this.lblErrorMsg.Location = new System.Drawing.Point(74, 310);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 18);
            this.lblErrorMsg.TabIndex = 6;
            // 
            // BagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(426, 363);
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
    }
}

