namespace TicketProcessingApp
{
    partial class TicketProcessingForm
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
            this.cmboEvent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.cmboSeat = new System.Windows.Forms.ComboBox();
            this.cmboRow = new System.Windows.Forms.ComboBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.cmboPrice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmboEvent
            // 
            this.cmboEvent.FormattingEnabled = true;
            this.cmboEvent.Items.AddRange(new object[] {
            "Green Lecture",
            "Lecture on Sustainability",
            "Yellow Raisin Men",
            "Strings Musical"});
            this.cmboEvent.Location = new System.Drawing.Point(106, 60);
            this.cmboEvent.Name = "cmboEvent";
            this.cmboEvent.Size = new System.Drawing.Size(215, 26);
            this.cmboEvent.TabIndex = 0;
            this.cmboEvent.SelectedIndexChanged += new System.EventHandler(this.cmboEvent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Which event would you like to purchase tickets?";
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Location = new System.Drawing.Point(218, 144);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(99, 18);
            this.lblSeat.TabIndex = 2;
            this.lblSeat.Text = "Seat Number:";
            this.lblSeat.Visible = false;
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(110, 144);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(100, 18);
            this.lblRow.TabIndex = 3;
            this.lblRow.Text = "Row Number:";
            this.lblRow.Visible = false;
            // 
            // cmboSeat
            // 
            this.cmboSeat.FormattingEnabled = true;
            this.cmboSeat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.cmboSeat.Location = new System.Drawing.Point(221, 175);
            this.cmboSeat.Name = "cmboSeat";
            this.cmboSeat.Size = new System.Drawing.Size(76, 26);
            this.cmboSeat.TabIndex = 4;
            this.cmboSeat.Visible = false;
            // 
            // cmboRow
            // 
            this.cmboRow.FormattingEnabled = true;
            this.cmboRow.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cmboRow.Location = new System.Drawing.Point(113, 175);
            this.cmboRow.Name = "cmboRow";
            this.cmboRow.Size = new System.Drawing.Size(76, 26);
            this.cmboRow.TabIndex = 5;
            this.cmboRow.Visible = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(99, 119);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(260, 15);
            this.lblInstructions.TabIndex = 6;
            this.lblInstructions.Text = "Select Seat and Row number and Ticket Price:";
            // 
            // cmboPrice
            // 
            this.cmboPrice.FormattingEnabled = true;
            this.cmboPrice.Items.AddRange(new object[] {
            "50.00",
            "70.00",
            "90.00",
            "100.00",
            "105.00",
            "150.00"});
            this.cmboPrice.Location = new System.Drawing.Point(150, 253);
            this.cmboPrice.Name = "cmboPrice";
            this.cmboPrice.Size = new System.Drawing.Size(121, 26);
            this.cmboPrice.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ticket Price:";
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.Green;
            this.btnProcess.Location = new System.Drawing.Point(154, 301);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(119, 50);
            this.btnProcess.TabIndex = 9;
            this.btnProcess.Text = "Process Request";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // TicketProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(426, 363);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmboPrice);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.cmboRow);
            this.Controls.Add(this.cmboSeat);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.lblSeat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboEvent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightYellow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TicketProcessingForm";
            this.Text = "Ticket Processing App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.ComboBox cmboSeat;
        private System.Windows.Forms.ComboBox cmboRow;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.ComboBox cmboPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcess;
    }
}

