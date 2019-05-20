namespace ColorChangeApp
{
    partial class ColorChangeAppForm
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
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGreen
            // 
            this.btnGreen.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreen.Location = new System.Drawing.Point(23, 116);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(95, 45);
            this.btnGreen.TabIndex = 0;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnGray
            // 
            this.btnGray.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGray.Location = new System.Drawing.Point(167, 116);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(95, 45);
            this.btnGray.TabIndex = 1;
            this.btnGray.Text = "Gray";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(104, 227);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ColorChangeAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnGreen);
            this.Name = "ColorChangeAppForm";
            this.Text = "Color Change App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnReset;
    }
}

