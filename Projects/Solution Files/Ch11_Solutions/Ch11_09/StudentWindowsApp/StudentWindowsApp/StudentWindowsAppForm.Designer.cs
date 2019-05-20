namespace StudentWindowsApp
{
    partial class StudentWindowsAppForm
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
            this.cmboTypeOfStudents = new System.Windows.Forms.ComboBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lstBxStudents = new System.Windows.Forms.ListBox();
            this.lblResultHeading = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Students";
            // 
            // cmboTypeOfStudents
            // 
            this.cmboTypeOfStudents.FormattingEnabled = true;
            this.cmboTypeOfStudents.Items.AddRange(new object[] {
            "UnderGraduate",
            "Graduate"});
            this.cmboTypeOfStudents.Location = new System.Drawing.Point(159, 85);
            this.cmboTypeOfStudents.Name = "cmboTypeOfStudents";
            this.cmboTypeOfStudents.Size = new System.Drawing.Size(212, 26);
            this.cmboTypeOfStudents.TabIndex = 1;
            this.cmboTypeOfStudents.SelectedIndexChanged += new System.EventHandler(this.cmboTypeOfStudents_SelectedIndexChanged);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(65, 135);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(437, 18);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Make selection from above to see current listing of students by ID";
            // 
            // lstBxStudents
            // 
            this.lstBxStudents.FormattingEnabled = true;
            this.lstBxStudents.ItemHeight = 18;
            this.lstBxStudents.Location = new System.Drawing.Point(175, 172);
            this.lstBxStudents.Name = "lstBxStudents";
            this.lstBxStudents.Size = new System.Drawing.Size(171, 76);
            this.lstBxStudents.Sorted = true;
            this.lstBxStudents.TabIndex = 3;
            this.lstBxStudents.Visible = false;
            this.lstBxStudents.SelectedIndexChanged += new System.EventHandler(this.lstBxStudents_SelectedIndexChanged);
            // 
            // lblResultHeading
            // 
            this.lblResultHeading.AutoSize = true;
            this.lblResultHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultHeading.Location = new System.Drawing.Point(65, 269);
            this.lblResultHeading.Name = "lblResultHeading";
            this.lblResultHeading.Size = new System.Drawing.Size(184, 22);
            this.lblResultHeading.TabIndex = 4;
            this.lblResultHeading.Text = "Student Information";
            this.lblResultHeading.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(65, 301);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 18);
            this.lblResult.TabIndex = 5;
            // 
            // StudentWindowsAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(531, 408);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblResultHeading);
            this.Controls.Add(this.lstBxStudents);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.cmboTypeOfStudents);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentWindowsAppForm";
            this.Text = "Student Listing App";
            this.Load += new System.EventHandler(this.StudentWindowsAppForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboTypeOfStudents;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.ListBox lstBxStudents;
        private System.Windows.Forms.Label lblResultHeading;
        private System.Windows.Forms.Label lblResult;
    }
}

