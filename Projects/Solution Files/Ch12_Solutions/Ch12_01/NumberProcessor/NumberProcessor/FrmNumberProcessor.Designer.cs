namespace NumberProcessor
{
    partial class FrmNumberProcessor
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxValue1 = new System.Windows.Forms.TextBox();
            this.txtBxValue2 = new System.Windows.Forms.TextBox();
            this.lstBxValue1 = new System.Windows.Forms.ListBox();
            this.lstBxValue2 = new System.Windows.Forms.ListBox();
            this.lstBxResult = new System.Windows.Forms.ListBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value2";
            // 
            // txtBxValue1
            // 
            this.txtBxValue1.Location = new System.Drawing.Point(55, 86);
            this.txtBxValue1.Name = "txtBxValue1";
            this.txtBxValue1.Size = new System.Drawing.Size(43, 24);
            this.txtBxValue1.TabIndex = 0;
            this.txtBxValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBxValue2
            // 
            this.txtBxValue2.Location = new System.Drawing.Point(144, 86);
            this.txtBxValue2.Name = "txtBxValue2";
            this.txtBxValue2.Size = new System.Drawing.Size(43, 24);
            this.txtBxValue2.TabIndex = 1;
            this.txtBxValue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lstBxValue1
            // 
            this.lstBxValue1.FormattingEnabled = true;
            this.lstBxValue1.ItemHeight = 18;
            this.lstBxValue1.Location = new System.Drawing.Point(55, 139);
            this.lstBxValue1.Name = "lstBxValue1";
            this.lstBxValue1.Size = new System.Drawing.Size(49, 94);
            this.lstBxValue1.TabIndex = 4;
            // 
            // lstBxValue2
            // 
            this.lstBxValue2.FormattingEnabled = true;
            this.lstBxValue2.ItemHeight = 18;
            this.lstBxValue2.Location = new System.Drawing.Point(144, 139);
            this.lstBxValue2.Name = "lstBxValue2";
            this.lstBxValue2.Size = new System.Drawing.Size(49, 94);
            this.lstBxValue2.TabIndex = 5;
            // 
            // lstBxResult
            // 
            this.lstBxResult.FormattingEnabled = true;
            this.lstBxResult.ItemHeight = 18;
            this.lstBxResult.Location = new System.Drawing.Point(238, 139);
            this.lstBxResult.Name = "lstBxResult";
            this.lstBxResult.Size = new System.Drawing.Size(49, 94);
            this.lstBxResult.TabIndex = 6;
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.Green;
            this.btnProcess.Location = new System.Drawing.Point(125, 252);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(87, 60);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Process Values";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product";
            // 
            // FrmNumberProcessor
            // 
            this.AcceptButton = this.btnProcess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(426, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lstBxResult);
            this.Controls.Add(this.lstBxValue2);
            this.Controls.Add(this.lstBxValue1);
            this.Controls.Add(this.txtBxValue2);
            this.Controls.Add(this.txtBxValue1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNumberProcessor";
            this.Text = "Number Processor";
            this.Load += new System.EventHandler(this.FrmNumberProcessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxValue1;
        private System.Windows.Forms.TextBox txtBxValue2;
        private System.Windows.Forms.ListBox lstBxValue1;
        private System.Windows.Forms.ListBox lstBxValue2;
        private System.Windows.Forms.ListBox lstBxResult;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label3;
    }
}

