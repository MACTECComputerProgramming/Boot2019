namespace CharacterFrequencyApp
{
    partial class FrmCounter
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
            this.txtBxInput = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.lstBxResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxInput
            // 
            this.txtBxInput.Location = new System.Drawing.Point(40, 13);
            this.txtBxInput.Multiline = true;
            this.txtBxInput.Name = "txtBxInput";
            this.txtBxInput.Size = new System.Drawing.Size(259, 111);
            this.txtBxInput.TabIndex = 0;
            // 
            // btnCount
            // 
            this.btnCount.BackColor = System.Drawing.Color.Gray;
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.Location = new System.Drawing.Point(65, 143);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(93, 33);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = false;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // lstBxResults
            // 
            this.lstBxResults.FormattingEnabled = true;
            this.lstBxResults.Location = new System.Drawing.Point(136, 204);
            this.lstBxResults.Name = "lstBxResults";
            this.lstBxResults.Size = new System.Drawing.Size(81, 95);
            this.lstBxResults.Sorted = true;
            this.lstBxResults.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Character";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Count";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(180, 143);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 33);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(338, 331);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBxResults);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtBxInput);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Name = "FrmCounter";
            this.Text = "Character Frequency App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxInput;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.ListBox lstBxResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
    }
}

