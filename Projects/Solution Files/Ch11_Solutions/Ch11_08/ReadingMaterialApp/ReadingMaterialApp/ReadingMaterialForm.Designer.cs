namespace ReadingMaterialApp
{
    partial class ReadingMaterialForm
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
            this.cmboDisplay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmboDisplay
            // 
            this.cmboDisplay.FormattingEnabled = true;
            this.cmboDisplay.Items.AddRange(new object[] {
            "Book",
            "Magazine"});
            this.cmboDisplay.Location = new System.Drawing.Point(123, 83);
            this.cmboDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmboDisplay.Name = "cmboDisplay";
            this.cmboDisplay.Size = new System.Drawing.Size(180, 28);
            this.cmboDisplay.TabIndex = 0;
            this.cmboDisplay.SelectedIndexChanged += new System.EventHandler(this.cmboDisplay_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show Examples  ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblResult.Location = new System.Drawing.Point(96, 192);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Padding = new System.Windows.Forms.Padding(3);
            this.lblResult.Size = new System.Drawing.Size(8, 28);
            this.lblResult.TabIndex = 2;
            this.lblResult.Visible = false;
            // 
            // ReadingMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(426, 403);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReadingMaterialForm";
            this.Text = "Reading Items";
            this.Load += new System.EventHandler(this.ReadingMaterialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
    }
}

