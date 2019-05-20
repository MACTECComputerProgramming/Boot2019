namespace CustomerApp
{
    partial class FrmCustomerApp
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
            this.lstBxNames = new System.Windows.Forms.ListBox();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBxNames
            // 
            this.lstBxNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxNames.FormattingEnabled = true;
            this.lstBxNames.ItemHeight = 20;
            this.lstBxNames.Location = new System.Drawing.Point(140, 44);
            this.lstBxNames.Name = "lstBxNames";
            this.lstBxNames.Size = new System.Drawing.Size(146, 124);
            this.lstBxNames.TabIndex = 0;
            this.lstBxNames.Visible = false;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.Location = new System.Drawing.Point(162, 211);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(103, 65);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // FrmCustomerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(426, 363);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.lstBxNames);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCustomerApp";
            this.Text = "Customers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxNames;
        private System.Windows.Forms.Button btnLoadData;
    }
}

