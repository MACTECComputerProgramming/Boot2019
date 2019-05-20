namespace SportsSignUpApp
{
    partial class SportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SportsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radInvisible = new System.Windows.Forms.RadioButton();
            this.radSoccer = new System.Windows.Forms.RadioButton();
            this.radTennis = new System.Windows.Forms.RadioButton();
            this.radSwim = new System.Windows.Forms.RadioButton();
            this.radBasketball = new System.Windows.Forms.RadioButton();
            this.radBaseball = new System.Windows.Forms.RadioButton();
            this.picBaseBall = new System.Windows.Forms.PictureBox();
            this.picBasketball = new System.Windows.Forms.PictureBox();
            this.picSoccer = new System.Windows.Forms.PictureBox();
            this.picSwim = new System.Windows.Forms.PictureBox();
            this.picTennis = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBaseBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSoccer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTennis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radInvisible);
            this.groupBox1.Controls.Add(this.radSoccer);
            this.groupBox1.Controls.Add(this.radTennis);
            this.groupBox1.Controls.Add(this.radSwim);
            this.groupBox1.Controls.Add(this.radBasketball);
            this.groupBox1.Controls.Add(this.radBaseball);
            this.groupBox1.Location = new System.Drawing.Point(29, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sports";
            // 
            // radInvisible
            // 
            this.radInvisible.AutoSize = true;
            this.radInvisible.Location = new System.Drawing.Point(7, 135);
            this.radInvisible.Name = "radInvisible";
            this.radInvisible.Size = new System.Drawing.Size(14, 13);
            this.radInvisible.TabIndex = 5;
            this.radInvisible.UseVisualStyleBackColor = true;
            this.radInvisible.Visible = false;
            // 
            // radSoccer
            // 
            this.radSoccer.AutoSize = true;
            this.radSoccer.Location = new System.Drawing.Point(7, 65);
            this.radSoccer.Name = "radSoccer";
            this.radSoccer.Size = new System.Drawing.Size(59, 17);
            this.radSoccer.TabIndex = 4;
            this.radSoccer.Text = "Soccer";
            this.radSoccer.UseVisualStyleBackColor = true;
            this.radSoccer.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radTennis
            // 
            this.radTennis.AutoSize = true;
            this.radTennis.Location = new System.Drawing.Point(7, 111);
            this.radTennis.Name = "radTennis";
            this.radTennis.Size = new System.Drawing.Size(57, 17);
            this.radTennis.TabIndex = 3;
            this.radTennis.Text = "Tennis";
            this.radTennis.UseVisualStyleBackColor = true;
            this.radTennis.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radSwim
            // 
            this.radSwim.AutoSize = true;
            this.radSwim.Location = new System.Drawing.Point(7, 87);
            this.radSwim.Name = "radSwim";
            this.radSwim.Size = new System.Drawing.Size(72, 17);
            this.radSwim.TabIndex = 2;
            this.radSwim.Text = "Swimming";
            this.radSwim.UseVisualStyleBackColor = true;
            this.radSwim.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radBasketball
            // 
            this.radBasketball.AutoSize = true;
            this.radBasketball.Location = new System.Drawing.Point(7, 44);
            this.radBasketball.Name = "radBasketball";
            this.radBasketball.Size = new System.Drawing.Size(74, 17);
            this.radBasketball.TabIndex = 1;
            this.radBasketball.Text = "Basketball";
            this.radBasketball.UseVisualStyleBackColor = true;
            this.radBasketball.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radBaseball
            // 
            this.radBaseball.AutoSize = true;
            this.radBaseball.Location = new System.Drawing.Point(7, 20);
            this.radBaseball.Name = "radBaseball";
            this.radBaseball.Size = new System.Drawing.Size(65, 17);
            this.radBaseball.TabIndex = 0;
            this.radBaseball.Text = "Baseball";
            this.radBaseball.UseVisualStyleBackColor = true;
            this.radBaseball.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // picBaseBall
            // 
            this.picBaseBall.Image = ((System.Drawing.Image)(resources.GetObject("picBaseBall.Image")));
            this.picBaseBall.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBaseBall.InitialImage")));
            this.picBaseBall.Location = new System.Drawing.Point(152, 36);
            this.picBaseBall.Name = "picBaseBall";
            this.picBaseBall.Size = new System.Drawing.Size(125, 141);
            this.picBaseBall.TabIndex = 1;
            this.picBaseBall.TabStop = false;
            this.picBaseBall.Visible = false;
            // 
            // picBasketball
            // 
            this.picBasketball.Image = ((System.Drawing.Image)(resources.GetObject("picBasketball.Image")));
            this.picBasketball.Location = new System.Drawing.Point(152, 36);
            this.picBasketball.Name = "picBasketball";
            this.picBasketball.Size = new System.Drawing.Size(125, 141);
            this.picBasketball.TabIndex = 2;
            this.picBasketball.TabStop = false;
            this.picBasketball.Visible = false;
            // 
            // picSoccer
            // 
            this.picSoccer.Image = ((System.Drawing.Image)(resources.GetObject("picSoccer.Image")));
            this.picSoccer.Location = new System.Drawing.Point(152, 36);
            this.picSoccer.Name = "picSoccer";
            this.picSoccer.Size = new System.Drawing.Size(125, 141);
            this.picSoccer.TabIndex = 3;
            this.picSoccer.TabStop = false;
            this.picSoccer.Visible = false;
            // 
            // picSwim
            // 
            this.picSwim.Image = ((System.Drawing.Image)(resources.GetObject("picSwim.Image")));
            this.picSwim.Location = new System.Drawing.Point(152, 36);
            this.picSwim.Name = "picSwim";
            this.picSwim.Size = new System.Drawing.Size(125, 141);
            this.picSwim.TabIndex = 4;
            this.picSwim.TabStop = false;
            this.picSwim.Visible = false;
            // 
            // picTennis
            // 
            this.picTennis.Image = ((System.Drawing.Image)(resources.GetObject("picTennis.Image")));
            this.picTennis.Location = new System.Drawing.Point(152, 36);
            this.picTennis.Name = "picTennis";
            this.picTennis.Size = new System.Drawing.Size(125, 141);
            this.picTennis.TabIndex = 5;
            this.picTennis.TabStop = false;
            this.picTennis.Visible = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(152, 36);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(125, 141);
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(5, 210);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 7;
            // 
            // SportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 290);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picTennis);
            this.Controls.Add(this.picSwim);
            this.Controls.Add(this.picSoccer);
            this.Controls.Add(this.picBasketball);
            this.Controls.Add(this.picBaseBall);
            this.Controls.Add(this.groupBox1);
            this.Name = "SportsForm";
            this.Text = "League Sign Up App";
            this.Load += new System.EventHandler(this.SportsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBaseBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSoccer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTennis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radSoccer;
        private System.Windows.Forms.RadioButton radTennis;
        private System.Windows.Forms.RadioButton radSwim;
        private System.Windows.Forms.RadioButton radBasketball;
        private System.Windows.Forms.RadioButton radBaseball;
        private System.Windows.Forms.PictureBox picBaseBall;
        private System.Windows.Forms.PictureBox picBasketball;
        private System.Windows.Forms.PictureBox picSoccer;
        private System.Windows.Forms.PictureBox picSwim;
        private System.Windows.Forms.PictureBox picTennis;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.RadioButton radInvisible;
        private System.Windows.Forms.Label lblMessage;
    }
}

