namespace FloorCoveringApp
{
    partial class FloorCoveringAppForm
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
            this.txtBxWidthFeet = new System.Windows.Forms.TextBox();
            this.txtBxLengthFeet = new System.Windows.Forms.TextBox();
            this.txtBxWidthInches = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBxLengthInches = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCarpet = new System.Windows.Forms.TabPage();
            this.cmboCarpetType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabHardwood = new System.Windows.Forms.TabPage();
            this.cmboHardwoodType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabLaminate = new System.Windows.Forms.TabPage();
            this.cmboLaminateType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCarpet.SuspendLayout();
            this.tabHardwood.SuspendLayout();
            this.tabLaminate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Dimensions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Length:";
            // 
            // txtBxWidthFeet
            // 
            this.txtBxWidthFeet.Location = new System.Drawing.Point(88, 259);
            this.txtBxWidthFeet.Name = "txtBxWidthFeet";
            this.txtBxWidthFeet.Size = new System.Drawing.Size(49, 26);
            this.txtBxWidthFeet.TabIndex = 0;
            this.txtBxWidthFeet.Text = "0";
            this.txtBxWidthFeet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxWidthFeet.MouseEnter += new System.EventHandler(this.txtBxWidthFeet_MouseEnter);
            // 
            // txtBxLengthFeet
            // 
            this.txtBxLengthFeet.Location = new System.Drawing.Point(88, 291);
            this.txtBxLengthFeet.Name = "txtBxLengthFeet";
            this.txtBxLengthFeet.Size = new System.Drawing.Size(49, 26);
            this.txtBxLengthFeet.TabIndex = 2;
            this.txtBxLengthFeet.Text = "0";
            this.txtBxLengthFeet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxLengthFeet.MouseEnter += new System.EventHandler(this.txtBxLengthFeet_MouseEnter);
            // 
            // txtBxWidthInches
            // 
            this.txtBxWidthInches.Location = new System.Drawing.Point(165, 257);
            this.txtBxWidthInches.Name = "txtBxWidthInches";
            this.txtBxWidthInches.Size = new System.Drawing.Size(38, 26);
            this.txtBxWidthInches.TabIndex = 1;
            this.txtBxWidthInches.Text = "0";
            this.txtBxWidthInches.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxWidthInches.MouseEnter += new System.EventHandler(this.txtBxWidthInches_MouseEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "ft.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "ft.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(205, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "inches";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(205, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "inches";
            // 
            // txtBxLengthInches
            // 
            this.txtBxLengthInches.Location = new System.Drawing.Point(165, 291);
            this.txtBxLengthInches.Name = "txtBxLengthInches";
            this.txtBxLengthInches.Size = new System.Drawing.Size(38, 26);
            this.txtBxLengthInches.TabIndex = 3;
            this.txtBxLengthInches.Text = "0";
            this.txtBxLengthInches.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBxLengthInches.MouseEnter += new System.EventHandler(this.txtBxLengthInches_MouseEnter);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabCarpet);
            this.tabControl1.Controls.Add(this.tabHardwood);
            this.tabControl1.Controls.Add(this.tabLaminate);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(472, 206);
            this.tabControl1.TabIndex = 13;
            // 
            // tabCarpet
            // 
            this.tabCarpet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabCarpet.Controls.Add(this.cmboCarpetType);
            this.tabCarpet.Controls.Add(this.label4);
            this.tabCarpet.Location = new System.Drawing.Point(4, 32);
            this.tabCarpet.Name = "tabCarpet";
            this.tabCarpet.Padding = new System.Windows.Forms.Padding(3);
            this.tabCarpet.Size = new System.Drawing.Size(464, 170);
            this.tabCarpet.TabIndex = 0;
            this.tabCarpet.Text = "Carpet";
            // 
            // cmboCarpetType
            // 
            this.cmboCarpetType.FormattingEnabled = true;
            this.cmboCarpetType.Items.AddRange(new object[] {
            "",
            "Berber - $21.95",
            "Cut Pile - $22.95",
            "Frieze - $29.95",
            "Loop Pile - $21.95",
            "Plush/velvet - $34.95",
            "Textured saxony - $35.95"});
            this.cmboCarpetType.Location = new System.Drawing.Point(105, 57);
            this.cmboCarpetType.Name = "cmboCarpetType";
            this.cmboCarpetType.Size = new System.Drawing.Size(254, 28);
            this.cmboCarpetType.Sorted = true;
            this.cmboCarpetType.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type of Carpet";
            // 
            // tabHardwood
            // 
            this.tabHardwood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabHardwood.Controls.Add(this.cmboHardwoodType);
            this.tabHardwood.Controls.Add(this.label11);
            this.tabHardwood.Location = new System.Drawing.Point(4, 32);
            this.tabHardwood.Name = "tabHardwood";
            this.tabHardwood.Padding = new System.Windows.Forms.Padding(3);
            this.tabHardwood.Size = new System.Drawing.Size(464, 170);
            this.tabHardwood.TabIndex = 1;
            this.tabHardwood.Text = "Hardwood";
            // 
            // cmboHardwoodType
            // 
            this.cmboHardwoodType.FormattingEnabled = true;
            this.cmboHardwoodType.Items.AddRange(new object[] {
            "",
            "Cherry - $41.95",
            "Maple - $38.95",
            "Oak - $34.95",
            "Pine - $33.95",
            "Walnut -$30.95"});
            this.cmboHardwoodType.Location = new System.Drawing.Point(105, 57);
            this.cmboHardwoodType.Name = "cmboHardwoodType";
            this.cmboHardwoodType.Size = new System.Drawing.Size(254, 28);
            this.cmboHardwoodType.Sorted = true;
            this.cmboHardwoodType.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(161, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Type of Hardwood";
            // 
            // tabLaminate
            // 
            this.tabLaminate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabLaminate.Controls.Add(this.cmboLaminateType);
            this.tabLaminate.Controls.Add(this.label13);
            this.tabLaminate.Location = new System.Drawing.Point(4, 32);
            this.tabLaminate.Name = "tabLaminate";
            this.tabLaminate.Size = new System.Drawing.Size(464, 170);
            this.tabLaminate.TabIndex = 2;
            this.tabLaminate.Text = "Laminate";
            // 
            // cmboLaminateType
            // 
            this.cmboLaminateType.FormattingEnabled = true;
            this.cmboLaminateType.Items.AddRange(new object[] {
            "",
            "Hardwood look - $19.95",
            "Smooth - $15.95",
            "Textured - $17.95",
            "Tiled look - $21.95"});
            this.cmboLaminateType.Location = new System.Drawing.Point(105, 57);
            this.cmboLaminateType.Name = "cmboLaminateType";
            this.cmboLaminateType.Size = new System.Drawing.Size(254, 28);
            this.cmboLaminateType.Sorted = true;
            this.cmboLaminateType.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(163, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Type of Laminate";
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblErrorMsg.Location = new System.Drawing.Point(8, 345);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 20);
            this.lblErrorMsg.TabIndex = 14;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(291, 245);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(131, 64);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate Cost";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(308, 316);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 49);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset Selections";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FloorCoveringAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(473, 403);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBxLengthInches);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBxWidthInches);
            this.Controls.Add(this.txtBxLengthFeet);
            this.Controls.Add(this.txtBxWidthFeet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FloorCoveringAppForm";
            this.Text = "Floor Covering App";
            this.tabControl1.ResumeLayout(false);
            this.tabCarpet.ResumeLayout(false);
            this.tabCarpet.PerformLayout();
            this.tabHardwood.ResumeLayout(false);
            this.tabHardwood.PerformLayout();
            this.tabLaminate.ResumeLayout(false);
            this.tabLaminate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxWidthFeet;
        private System.Windows.Forms.TextBox txtBxLengthFeet;
        private System.Windows.Forms.TextBox txtBxWidthInches;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBxLengthInches;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCarpet;
        private System.Windows.Forms.ComboBox cmboCarpetType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabHardwood;
        private System.Windows.Forms.TabPage tabLaminate;
        private System.Windows.Forms.ComboBox cmboHardwoodType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmboLaminateType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
    }
}

