namespace CustomerApp
{
    partial class CustomerDisplayApp
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
            this.btnShowRecord = new System.Windows.Forms.Button();
            this.txtBxNumber = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxLocation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaGridCustomers
            // 
            this.dtaGridCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtaGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridCustomers.Location = new System.Drawing.Point(17, 30);
            this.dtaGridCustomers.Name = "dtaGridCustomers";
            this.dtaGridCustomers.Size = new System.Drawing.Size(456, 150);
            this.dtaGridCustomers.TabIndex = 0;
            this.dtaGridCustomers.Visible = false;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(200, 203);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(91, 23);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnShowRecord
            // 
            this.btnShowRecord.Location = new System.Drawing.Point(200, 232);
            this.btnShowRecord.Name = "btnShowRecord";
            this.btnShowRecord.Size = new System.Drawing.Size(91, 23);
            this.btnShowRecord.TabIndex = 2;
            this.btnShowRecord.Text = "Show Record";
            this.btnShowRecord.UseVisualStyleBackColor = true;
            this.btnShowRecord.Visible = false;
            this.btnShowRecord.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // txtBxNumber
            // 
            this.txtBxNumber.Location = new System.Drawing.Point(261, 285);
            this.txtBxNumber.Name = "txtBxNumber";
            this.txtBxNumber.Size = new System.Drawing.Size(110, 20);
            this.txtBxNumber.TabIndex = 4;
            this.txtBxNumber.Visible = false;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(120, 284);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(135, 18);
            this.lblCustomer.TabIndex = 5;
            this.lblCustomer.Text = "Customer Number:";
            this.lblCustomer.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(120, 310);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            this.lblName.Visible = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(120, 336);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(69, 18);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Location:";
            this.lblLocation.Visible = false;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(195, 311);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(176, 20);
            this.txtBxName.TabIndex = 8;
            this.txtBxName.Visible = false;
            // 
            // txtBxLocation
            // 
            this.txtBxLocation.Location = new System.Drawing.Point(195, 337);
            this.txtBxLocation.Name = "txtBxLocation";
            this.txtBxLocation.Size = new System.Drawing.Size(176, 20);
            this.txtBxLocation.TabIndex = 9;
            this.txtBxLocation.Visible = false;
            // 
            // CustomerUpdateApp
            // 
            this.AcceptButton = this.btnLoadData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(491, 379);
            this.Controls.Add(this.txtBxLocation);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.txtBxNumber);
            this.Controls.Add(this.btnShowRecord);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.dtaGridCustomers);
            this.Name = "CustomerUpdateApp";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaGridCustomers;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnShowRecord;
        private System.Windows.Forms.TextBox txtBxNumber;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxLocation;
    }
}

