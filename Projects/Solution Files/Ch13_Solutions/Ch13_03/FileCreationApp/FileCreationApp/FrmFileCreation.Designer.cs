namespace FileCreationApp
{
    partial class FrmFileCreation
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
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxAddress = new System.Windows.Forms.TextBox();
            this.txtBxPhone = new System.Windows.Forms.TextBox();
            this.btnStoreData = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number:";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(101, 54);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(290, 24);
            this.txtBxName.TabIndex = 3;
            // 
            // txtBxAddress
            // 
            this.txtBxAddress.Location = new System.Drawing.Point(109, 100);
            this.txtBxAddress.Name = "txtBxAddress";
            this.txtBxAddress.Size = new System.Drawing.Size(282, 24);
            this.txtBxAddress.TabIndex = 4;
            // 
            // txtBxPhone
            // 
            this.txtBxPhone.Location = new System.Drawing.Point(161, 149);
            this.txtBxPhone.Name = "txtBxPhone";
            this.txtBxPhone.Size = new System.Drawing.Size(127, 24);
            this.txtBxPhone.TabIndex = 5;
            // 
            // btnStoreData
            // 
            this.btnStoreData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreData.Location = new System.Drawing.Point(147, 242);
            this.btnStoreData.Name = "btnStoreData";
            this.btnStoreData.Size = new System.Drawing.Size(132, 34);
            this.btnStoreData.TabIndex = 6;
            this.btnStoreData.Text = "Store Data";
            this.btnStoreData.UseVisualStyleBackColor = true;
            this.btnStoreData.Click += new System.EventHandler(this.btnStoreData_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(52, 292);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 18);
            this.lblMessage.TabIndex = 7;
            // 
            // FrmFileCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(426, 363);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnStoreData);
            this.Controls.Add(this.txtBxPhone);
            this.Controls.Add(this.txtBxAddress);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFileCreation";
            this.Text = "File Creation App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFileCreation_FormClosing);
            this.Load += new System.EventHandler(this.FrmFileCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxAddress;
        private System.Windows.Forms.TextBox txtBxPhone;
        private System.Windows.Forms.Button btnStoreData;
        private System.Windows.Forms.Label lblMessage;
    }
}

