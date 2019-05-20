namespace SkiSignUpApp
{
    partial class SkiSignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkiSignUpForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ckBxGloves = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckBxSkis = new System.Windows.Forms.CheckBox();
            this.ckBxGoggles = new System.Windows.Forms.CheckBox();
            this.ckBxEarmuffs = new System.Windows.Forms.CheckBox();
            this.ckBxBoots = new System.Windows.Forms.CheckBox();
            this.ckBxBindings = new System.Windows.Forms.CheckBox();
            this.ckBxPoles = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDisplay,
            this.menuClear,
            this.menuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // menuDisplay
            // 
            this.menuDisplay.Name = "menuDisplay";
            this.menuDisplay.Size = new System.Drawing.Size(168, 22);
            this.menuDisplay.Text = "Display Selections";
            this.menuDisplay.Click += new System.EventHandler(this.menuDisplay_Click);
            // 
            // menuClear
            // 
            this.menuClear.Name = "menuClear";
            this.menuClear.Size = new System.Drawing.Size(168, 22);
            this.menuClear.Text = "Clear Selections";
            this.menuClear.Click += new System.EventHandler(this.menuClear_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(168, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // ckBxGloves
            // 
            this.ckBxGloves.AutoSize = true;
            this.ckBxGloves.Location = new System.Drawing.Point(51, 285);
            this.ckBxGloves.Name = "ckBxGloves";
            this.ckBxGloves.Size = new System.Drawing.Size(140, 28);
            this.ckBxGloves.TabIndex = 1;
            this.ckBxGloves.Text = "Snow Gloves";
            this.ckBxGloves.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Which equipment do you need?";
            // 
            // ckBxSkis
            // 
            this.ckBxSkis.AutoSize = true;
            this.ckBxSkis.Location = new System.Drawing.Point(51, 217);
            this.ckBxSkis.Name = "ckBxSkis";
            this.ckBxSkis.Size = new System.Drawing.Size(63, 28);
            this.ckBxSkis.TabIndex = 3;
            this.ckBxSkis.Text = "Skis";
            this.ckBxSkis.UseVisualStyleBackColor = true;
            // 
            // ckBxGoggles
            // 
            this.ckBxGoggles.AutoSize = true;
            this.ckBxGoggles.Location = new System.Drawing.Point(51, 115);
            this.ckBxGoggles.Name = "ckBxGoggles";
            this.ckBxGoggles.Size = new System.Drawing.Size(100, 28);
            this.ckBxGoggles.TabIndex = 4;
            this.ckBxGoggles.Text = "Goggles";
            this.ckBxGoggles.UseVisualStyleBackColor = true;
            // 
            // ckBxEarmuffs
            // 
            this.ckBxEarmuffs.AutoSize = true;
            this.ckBxEarmuffs.Location = new System.Drawing.Point(51, 81);
            this.ckBxEarmuffs.Name = "ckBxEarmuffs";
            this.ckBxEarmuffs.Size = new System.Drawing.Size(102, 28);
            this.ckBxEarmuffs.TabIndex = 5;
            this.ckBxEarmuffs.Text = "Earmuffs";
            this.ckBxEarmuffs.UseVisualStyleBackColor = true;
            // 
            // ckBxBoots
            // 
            this.ckBxBoots.AutoSize = true;
            this.ckBxBoots.Location = new System.Drawing.Point(51, 183);
            this.ckBxBoots.Name = "ckBxBoots";
            this.ckBxBoots.Size = new System.Drawing.Size(106, 28);
            this.ckBxBoots.TabIndex = 6;
            this.ckBxBoots.Text = "Ski Boots";
            this.ckBxBoots.UseVisualStyleBackColor = true;
            // 
            // ckBxBindings
            // 
            this.ckBxBindings.AutoSize = true;
            this.ckBxBindings.Location = new System.Drawing.Point(51, 149);
            this.ckBxBindings.Name = "ckBxBindings";
            this.ckBxBindings.Size = new System.Drawing.Size(132, 28);
            this.ckBxBindings.TabIndex = 7;
            this.ckBxBindings.Text = "Ski Bindings";
            this.ckBxBindings.UseVisualStyleBackColor = true;
            // 
            // ckBxPoles
            // 
            this.ckBxPoles.AutoSize = true;
            this.ckBxPoles.Location = new System.Drawing.Point(51, 251);
            this.ckBxPoles.Name = "ckBxPoles";
            this.ckBxPoles.Size = new System.Drawing.Size(106, 28);
            this.ckBxPoles.TabIndex = 8;
            this.ckBxPoles.Text = "Ski Poles";
            this.ckBxPoles.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(236, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 142);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // SkiSignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(521, 484);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ckBxPoles);
            this.Controls.Add(this.ckBxBindings);
            this.Controls.Add(this.ckBxBoots);
            this.Controls.Add(this.ckBxEarmuffs);
            this.Controls.Add(this.ckBxGoggles);
            this.Controls.Add(this.ckBxSkis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckBxGloves);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SkiSignUpForm";
            this.Text = "Flyer Sports Club";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDisplay;
        private System.Windows.Forms.ToolStripMenuItem menuClear;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.CheckBox ckBxGloves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckBxSkis;
        private System.Windows.Forms.CheckBox ckBxGoggles;
        private System.Windows.Forms.CheckBox ckBxEarmuffs;
        private System.Windows.Forms.CheckBox ckBxBoots;
        private System.Windows.Forms.CheckBox ckBxBindings;
        private System.Windows.Forms.CheckBox ckBxPoles;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

