namespace BMI_Calculator
{
    partial class FrmBMI
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
            this.txtBxWeight = new System.Windows.Forms.TextBox();
            this.txtBxHeightFt = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxHeightInches = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height:";
            // 
            // txtBxWeight
            // 
            this.txtBxWeight.Location = new System.Drawing.Point(103, 48);
            this.txtBxWeight.Name = "txtBxWeight";
            this.txtBxWeight.Size = new System.Drawing.Size(100, 24);
            this.txtBxWeight.TabIndex = 0;
            // 
            // txtBxHeightFt
            // 
            this.txtBxHeightFt.Location = new System.Drawing.Point(103, 167);
            this.txtBxHeightFt.Name = "txtBxHeightFt";
            this.txtBxHeightFt.Size = new System.Drawing.Size(69, 24);
            this.txtBxHeightFt.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.BlueViolet;
            this.btnCalculate.Location = new System.Drawing.Point(257, 64);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 51);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate BMI";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(161, 239);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 24);
            this.lblResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "ft.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "inches";
            // 
            // txtBxHeightInches
            // 
            this.txtBxHeightInches.Location = new System.Drawing.Point(230, 167);
            this.txtBxHeightInches.Name = "txtBxHeightInches";
            this.txtBxHeightInches.Size = new System.Drawing.Size(69, 24);
            this.txtBxHeightInches.TabIndex = 2;
            // 
            // FrmBMI
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(426, 363);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxHeightInches);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBxHeightFt);
            this.Controls.Add(this.txtBxWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBMI";
            this.Text = "Body Mass Index Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxWeight;
        private System.Windows.Forms.TextBox txtBxHeightFt;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxHeightInches;
    }
}

