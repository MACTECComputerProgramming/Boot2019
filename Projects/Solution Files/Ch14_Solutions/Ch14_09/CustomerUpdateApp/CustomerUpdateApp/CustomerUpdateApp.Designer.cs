namespace CustomerUpdateApp
{
    partial class CustomerUpdateApp
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
            this.dtaGridCustomers = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaGridCustomers
            // 
            this.dtaGridCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtaGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridCustomers.Location = new System.Drawing.Point(64, 30);
            this.dtaGridCustomers.Name = "dtaGridCustomers";
            this.dtaGridCustomers.Size = new System.Drawing.Size(363, 150);
            this.dtaGridCustomers.TabIndex = 0;
            this.dtaGridCustomers.Visible = false;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(150, 203);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(91, 23);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(249, 203);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Data";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // CustomerUpdateApp
            // 
            this.AcceptButton = this.btnLoadData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(491, 325);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.dtaGridCustomers);
            this.Name = "CustomerUpdateApp";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaGridCustomers;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnUpdate;
    }
}

