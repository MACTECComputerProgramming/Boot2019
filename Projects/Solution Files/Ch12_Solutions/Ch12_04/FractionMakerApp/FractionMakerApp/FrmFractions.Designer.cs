namespace FractionMakerApp
{
    partial class FrmFractions
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
            this.btnMakeFraction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxNumerator = new System.Windows.Forms.TextBox();
            this.txtBxDenominator = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMakeFraction
            // 
            this.btnMakeFraction.BackColor = System.Drawing.Color.Green;
            this.btnMakeFraction.Location = new System.Drawing.Point(153, 294);
            this.btnMakeFraction.Name = "btnMakeFraction";
            this.btnMakeFraction.Size = new System.Drawing.Size(120, 47);
            this.btnMakeFraction.TabIndex = 2;
            this.btnMakeFraction.Text = "Make Fraction";
            this.btnMakeFraction.UseVisualStyleBackColor = false;
            this.btnMakeFraction.Click += new System.EventHandler(this.btnMakeFraction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numerator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Denominator";
            // 
            // txtBxNumerator
            // 
            this.txtBxNumerator.Location = new System.Drawing.Point(155, 86);
            this.txtBxNumerator.Name = "txtBxNumerator";
            this.txtBxNumerator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBxNumerator.Size = new System.Drawing.Size(100, 24);
            this.txtBxNumerator.TabIndex = 0;
            // 
            // txtBxDenominator
            // 
            this.txtBxDenominator.Location = new System.Drawing.Point(155, 132);
            this.txtBxDenominator.Name = "txtBxDenominator";
            this.txtBxDenominator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBxDenominator.Size = new System.Drawing.Size(100, 24);
            this.txtBxDenominator.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(66, 178);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 24);
            this.lblResult.TabIndex = 3;
            // 
            // FrmFractions
            // 
            this.AcceptButton = this.btnMakeFraction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(426, 363);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtBxDenominator);
            this.Controls.Add(this.txtBxNumerator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMakeFraction);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFractions";
            this.Text = "Fraction Making App";
            this.Load += new System.EventHandler(this.FrmFractions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeFraction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxNumerator;
        private System.Windows.Forms.TextBox txtBxDenominator;
        private System.Windows.Forms.Label lblResult;
    }
}

