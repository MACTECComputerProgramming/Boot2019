namespace CalculatorApp
{
    partial class CalculatorAppForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxValue1 = new System.Windows.Forms.TextBox();
            this.txtBxValue2 = new System.Windows.Forms.TextBox();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Second Value:";
            // 
            // txtBxValue1
            // 
            this.txtBxValue1.Location = new System.Drawing.Point(212, 108);
            this.txtBxValue1.Name = "txtBxValue1";
            this.txtBxValue1.Size = new System.Drawing.Size(100, 26);
            this.txtBxValue1.TabIndex = 3;
            this.txtBxValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBxValue2
            // 
            this.txtBxValue2.Location = new System.Drawing.Point(212, 174);
            this.txtBxValue2.Name = "txtBxValue2";
            this.txtBxValue2.Size = new System.Drawing.Size(100, 26);
            this.txtBxValue2.TabIndex = 4;
            this.txtBxValue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(108, 260);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(80, 36);
            this.btnMultiply.TabIndex = 5;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(238, 259);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 36);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(34, 349);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 24);
            this.lblResult.TabIndex = 7;
            // 
            // CalculatorAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 403);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.txtBxValue2);
            this.Controls.Add(this.txtBxValue1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CalculatorAppForm";
            this.Text = "Calculator App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxValue1;
        private System.Windows.Forms.TextBox txtBxValue2;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblResult;
    }
}

