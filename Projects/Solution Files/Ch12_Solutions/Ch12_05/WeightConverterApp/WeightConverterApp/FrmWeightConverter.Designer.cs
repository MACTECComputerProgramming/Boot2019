namespace WeightConverterApp
{
    partial class FrmWeightConverter
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
            this.txtBxUnits = new System.Windows.Forms.TextBox();
            this.cmboFrom = new System.Windows.Forms.ComboBox();
            this.cmboTo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Units:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Measurement:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Measurement:";
            this.label3.Visible = false;
            // 
            // txtBxUnits
            // 
            this.txtBxUnits.Location = new System.Drawing.Point(56, 91);
            this.txtBxUnits.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxUnits.Name = "txtBxUnits";
            this.txtBxUnits.Size = new System.Drawing.Size(74, 24);
            this.txtBxUnits.TabIndex = 3;
            this.txtBxUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmboFrom
            // 
            this.cmboFrom.FormattingEnabled = true;
            this.cmboFrom.Items.AddRange(new object[] {
            "Ounces",
            "Pounds",
            "Grams",
            "Kilograms"});
            this.cmboFrom.Location = new System.Drawing.Point(177, 91);
            this.cmboFrom.Name = "cmboFrom";
            this.cmboFrom.Size = new System.Drawing.Size(92, 26);
            this.cmboFrom.TabIndex = 5;
            this.cmboFrom.SelectedIndexChanged += new System.EventHandler(this.cmboFrom_SelectedIndexChanged);
            // 
            // cmboTo
            // 
            this.cmboTo.FormattingEnabled = true;
            this.cmboTo.Items.AddRange(new object[] {
            "Ounces",
            "Pounds",
            "Grams",
            "Kilograms"});
            this.cmboTo.Location = new System.Drawing.Point(282, 91);
            this.cmboTo.Name = "cmboTo";
            this.cmboTo.Size = new System.Drawing.Size(92, 26);
            this.cmboTo.TabIndex = 6;
            this.cmboTo.Visible = false;
            this.cmboTo.SelectedIndexChanged += new System.EventHandler(this.cmboTo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(317, 32);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 18);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "To";
            this.lblTo.Visible = false;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(79, 203);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 18);
            this.lblResults.TabIndex = 10;
            // 
            // FrmWeightConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(426, 363);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmboTo);
            this.Controls.Add(this.cmboFrom);
            this.Controls.Add(this.txtBxUnits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmWeightConverter";
            this.Text = "Weight Converter";
            this.Load += new System.EventHandler(this.FrmWeightConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxUnits;
        private System.Windows.Forms.ComboBox cmboFrom;
        private System.Windows.Forms.ComboBox cmboTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblResults;
    }
}

