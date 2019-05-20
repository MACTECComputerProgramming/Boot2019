namespace PasswordApp
{
    partial class PasswordAppForm
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
            this.lblPass1 = new System.Windows.Forms.Label();
            this.txtBxPass1 = new System.Windows.Forms.TextBox();
            this.txtBxPass2 = new System.Windows.Forms.TextBox();
            this.lblPass2 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPass1
            // 
            this.lblPass1.AutoSize = true;
            this.lblPass1.Location = new System.Drawing.Point(51, 83);
            this.lblPass1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass1.Name = "lblPass1";
            this.lblPass1.Size = new System.Drawing.Size(86, 18);
            this.lblPass1.TabIndex = 0;
            this.lblPass1.Text = "Password: ";
            // 
            // txtBxPass1
            // 
            this.txtBxPass1.Location = new System.Drawing.Point(144, 79);
            this.txtBxPass1.Name = "txtBxPass1";
            this.txtBxPass1.PasswordChar = '*';
            this.txtBxPass1.Size = new System.Drawing.Size(130, 26);
            this.txtBxPass1.TabIndex = 1;
            // 
            // txtBxPass2
            // 
            this.txtBxPass2.Location = new System.Drawing.Point(144, 136);
            this.txtBxPass2.Name = "txtBxPass2";
            this.txtBxPass2.PasswordChar = '*';
            this.txtBxPass2.Size = new System.Drawing.Size(130, 26);
            this.txtBxPass2.TabIndex = 2;
            this.txtBxPass2.Visible = false;
            // 
            // lblPass2
            // 
            this.lblPass2.AutoSize = true;
            this.lblPass2.Location = new System.Drawing.Point(51, 140);
            this.lblPass2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass2.Name = "lblPass2";
            this.lblPass2.Size = new System.Drawing.Size(86, 18);
            this.lblPass2.TabIndex = 3;
            this.lblPass2.Text = "Password: ";
            this.lblPass2.Visible = false;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(312, 107);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(135, 197);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check Password";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Visible = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMessage.Location = new System.Drawing.Point(54, 261);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(187, 18);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "Please re-enter password";
            this.lblMessage.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(253, 197);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // PasswordAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(426, 363);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblPass2);
            this.Controls.Add(this.txtBxPass2);
            this.Controls.Add(this.txtBxPass1);
            this.Controls.Add(this.lblPass1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PasswordAppForm";
            this.Text = "Password Checker App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPass1;
        private System.Windows.Forms.TextBox txtBxPass1;
        private System.Windows.Forms.TextBox txtBxPass2;
        private System.Windows.Forms.Label lblPass2;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnReset;
    }
}

