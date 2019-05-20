namespace NameSeparatorApp
{
    partial class NameSeparatorAppForm
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
            this.txtBxFullname = new System.Windows.Forms.TextBox();
            this.lblFirstLbl = new System.Windows.Forms.Label();
            this.lblMiddleLbl = new System.Windows.Forms.Label();
            this.lblLastLbl = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblMiddle = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            // 
            // txtBxFullname
            // 
            this.txtBxFullname.Location = new System.Drawing.Point(156, 68);
            this.txtBxFullname.Name = "txtBxFullname";
            this.txtBxFullname.Size = new System.Drawing.Size(203, 26);
            this.txtBxFullname.TabIndex = 1;
            // 
            // lblFirstLbl
            // 
            this.lblFirstLbl.AutoSize = true;
            this.lblFirstLbl.Location = new System.Drawing.Point(81, 203);
            this.lblFirstLbl.Name = "lblFirstLbl";
            this.lblFirstLbl.Size = new System.Drawing.Size(90, 20);
            this.lblFirstLbl.TabIndex = 2;
            this.lblFirstLbl.Text = "First Name:";
            this.lblFirstLbl.Visible = false;
            // 
            // lblMiddleLbl
            // 
            this.lblMiddleLbl.AutoSize = true;
            this.lblMiddleLbl.Location = new System.Drawing.Point(81, 226);
            this.lblMiddleLbl.Name = "lblMiddleLbl";
            this.lblMiddleLbl.Size = new System.Drawing.Size(105, 20);
            this.lblMiddleLbl.TabIndex = 3;
            this.lblMiddleLbl.Text = "Middle Name:";
            this.lblMiddleLbl.Visible = false;
            // 
            // lblLastLbl
            // 
            this.lblLastLbl.AutoSize = true;
            this.lblLastLbl.Location = new System.Drawing.Point(81, 248);
            this.lblLastLbl.Name = "lblLastLbl";
            this.lblLastLbl.Size = new System.Drawing.Size(90, 20);
            this.lblLastLbl.TabIndex = 4;
            this.lblLastLbl.Text = "Last Name:";
            this.lblLastLbl.Visible = false;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(194, 203);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(0, 20);
            this.lblFirst.TabIndex = 5;
            this.lblFirst.Visible = false;
            // 
            // lblMiddle
            // 
            this.lblMiddle.AutoSize = true;
            this.lblMiddle.Location = new System.Drawing.Point(194, 226);
            this.lblMiddle.Name = "lblMiddle";
            this.lblMiddle.Size = new System.Drawing.Size(0, 20);
            this.lblMiddle.TabIndex = 6;
            this.lblMiddle.Visible = false;
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(194, 248);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(0, 20);
            this.lblLast.TabIndex = 7;
            this.lblLast.Visible = false;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(144, 129);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(139, 44);
            this.btnRetrieve.TabIndex = 8;
            this.btnRetrieve.Text = "Retrieve Name";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // NameSeparatorAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(426, 403);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblMiddle);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblLastLbl);
            this.Controls.Add(this.lblMiddleLbl);
            this.Controls.Add(this.lblFirstLbl);
            this.Controls.Add(this.txtBxFullname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NameSeparatorAppForm";
            this.Text = "Name Separator App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxFullname;
        private System.Windows.Forms.Label lblFirstLbl;
        private System.Windows.Forms.Label lblMiddleLbl;
        private System.Windows.Forms.Label lblLastLbl;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblMiddle;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Button btnRetrieve;
    }
}

