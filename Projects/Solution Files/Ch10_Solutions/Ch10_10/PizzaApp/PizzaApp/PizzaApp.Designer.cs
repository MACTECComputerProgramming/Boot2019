namespace PizzaApp
{
    partial class PizzaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPizza = new System.Windows.Forms.TabPage();
            this.cmboSauce = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmboSpecialPizza = new System.Windows.Forms.ComboBox();
            this.lstBxToppings = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmboCrust = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmboSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBeverage = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBxWaterQty = new System.Windows.Forms.TextBox();
            this.txtBxSodaQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmboSpeciality = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabContactInfo = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.txtBxPhone = new System.Windows.Forms.TextBox();
            this.txtBxAddress = new System.Windows.Forms.TextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPizza.SuspendLayout();
            this.tabBeverage.SuspendLayout();
            this.tabOther.SuspendLayout();
            this.tabContactInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPizza);
            this.tabControl1.Controls.Add(this.tabBeverage);
            this.tabControl1.Controls.Add(this.tabOther);
            this.tabControl1.Controls.Add(this.tabContactInfo);
            this.tabControl1.Location = new System.Drawing.Point(8, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(307, 240);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPizza
            // 
            this.tabPizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPizza.BackgroundImage")));
            this.tabPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPizza.Controls.Add(this.cmboSauce);
            this.tabPizza.Controls.Add(this.label21);
            this.tabPizza.Controls.Add(this.label20);
            this.tabPizza.Controls.Add(this.label11);
            this.tabPizza.Controls.Add(this.cmboSpecialPizza);
            this.tabPizza.Controls.Add(this.lstBxToppings);
            this.tabPizza.Controls.Add(this.label5);
            this.tabPizza.Controls.Add(this.label10);
            this.tabPizza.Controls.Add(this.cmboCrust);
            this.tabPizza.Controls.Add(this.label2);
            this.tabPizza.Controls.Add(this.cmboSize);
            this.tabPizza.Controls.Add(this.label1);
            this.tabPizza.Location = new System.Drawing.Point(4, 22);
            this.tabPizza.Name = "tabPizza";
            this.tabPizza.Padding = new System.Windows.Forms.Padding(3);
            this.tabPizza.Size = new System.Drawing.Size(299, 214);
            this.tabPizza.TabIndex = 0;
            this.tabPizza.Text = "Pizza";
            this.tabPizza.UseVisualStyleBackColor = true;
            // 
            // cmboSauce
            // 
            this.cmboSauce.FormattingEnabled = true;
            this.cmboSauce.Items.AddRange(new object[] {
            "Tomato",
            "Pesto",
            "White",
            "Ranch"});
            this.cmboSauce.Location = new System.Drawing.Point(5, 115);
            this.cmboSauce.Name = "cmboSauce";
            this.cmboSauce.Size = new System.Drawing.Size(138, 21);
            this.cmboSauce.TabIndex = 12;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Blue;
            this.label21.Location = new System.Drawing.Point(53, 100);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "Sauce";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(68, 188);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(162, 24);
            this.label20.TabIndex = 10;
            this.label20.Text = "Pizza Selections";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(25, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Specially Pizzas";
            // 
            // cmboSpecialPizza
            // 
            this.cmboSpecialPizza.FormattingEnabled = true;
            this.cmboSpecialPizza.Items.AddRange(new object[] {
            "",
            "Meat Lovers",
            "Supreme",
            "Veggie Lovers",
            "Hawaiian",
            "BLT Pizza"});
            this.cmboSpecialPizza.Location = new System.Drawing.Point(7, 164);
            this.cmboSpecialPizza.Name = "cmboSpecialPizza";
            this.cmboSpecialPizza.Size = new System.Drawing.Size(136, 21);
            this.cmboSpecialPizza.TabIndex = 8;
            // 
            // lstBxToppings
            // 
            this.lstBxToppings.FormattingEnabled = true;
            this.lstBxToppings.Items.AddRange(new object[] {
            "Pepperoni",
            "Extra Cheese",
            "Onions",
            "Garlic",
            "Green Peppers",
            "Green Olives",
            "Mushroom",
            "Green Peppers",
            "Black Olives",
            "Chicken",
            "Bacon",
            "Beef",
            "Ham",
            "Sausage"});
            this.lstBxToppings.Location = new System.Drawing.Point(167, 49);
            this.lstBxToppings.Name = "lstBxToppings";
            this.lstBxToppings.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBxToppings.Size = new System.Drawing.Size(120, 108);
            this.lstBxToppings.TabIndex = 7;
            this.toolTip1.SetToolTip(this.lstBxToppings, "Use the Ctrl key for multiple selections\r\n");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(171, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Toppings - $1.50 ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "D && B Pizza Express";
            // 
            // cmboCrust
            // 
            this.cmboCrust.FormattingEnabled = true;
            this.cmboCrust.Items.AddRange(new object[] {
            "Thin & Crispy Crust",
            "Pan Crust",
            "Regular Crust"});
            this.cmboCrust.Location = new System.Drawing.Point(5, 78);
            this.cmboCrust.Name = "cmboCrust";
            this.cmboCrust.Size = new System.Drawing.Size(138, 21);
            this.cmboCrust.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(57, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Crust";
            // 
            // cmboSize
            // 
            this.cmboSize.FormattingEnabled = true;
            this.cmboSize.Items.AddRange(new object[] {
            "Small (10\") - $9.95",
            "Medium (12\") - $12.95",
            "Large (16\") - $15.95"});
            this.cmboSize.Location = new System.Drawing.Point(5, 43);
            this.cmboSize.Name = "cmboSize";
            this.cmboSize.Size = new System.Drawing.Size(138, 21);
            this.cmboSize.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(61, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size";
            // 
            // tabBeverage
            // 
            this.tabBeverage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabBeverage.BackgroundImage")));
            this.tabBeverage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabBeverage.Controls.Add(this.label16);
            this.tabBeverage.Controls.Add(this.label4);
            this.tabBeverage.Controls.Add(this.label9);
            this.tabBeverage.Controls.Add(this.txtBxWaterQty);
            this.tabBeverage.Controls.Add(this.txtBxSodaQty);
            this.tabBeverage.Controls.Add(this.label7);
            this.tabBeverage.Controls.Add(this.label6);
            this.tabBeverage.Controls.Add(this.label3);
            this.tabBeverage.Location = new System.Drawing.Point(4, 22);
            this.tabBeverage.Name = "tabBeverage";
            this.tabBeverage.Padding = new System.Windows.Forms.Padding(3);
            this.tabBeverage.Size = new System.Drawing.Size(299, 214);
            this.tabBeverage.TabIndex = 1;
            this.tabBeverage.Text = "Beverages";
            this.tabBeverage.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(59, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(181, 24);
            this.label16.TabIndex = 11;
            this.label16.Text = "D && B Pizza Express";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(51, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Soda cost is $1.75 - Water is free!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Drink Selections";
            // 
            // txtBxWaterQty
            // 
            this.txtBxWaterQty.Location = new System.Drawing.Point(147, 81);
            this.txtBxWaterQty.Name = "txtBxWaterQty";
            this.txtBxWaterQty.Size = new System.Drawing.Size(40, 20);
            this.txtBxWaterQty.TabIndex = 8;
            this.txtBxWaterQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBxSodaQty
            // 
            this.txtBxSodaQty.Location = new System.Drawing.Point(147, 56);
            this.txtBxSodaQty.Name = "txtBxSodaQty";
            this.txtBxSodaQty.Size = new System.Drawing.Size(40, 20);
            this.txtBxSodaQty.TabIndex = 5;
            this.txtBxSodaQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(149, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(89, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Water(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(89, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soda(s)";
            // 
            // tabOther
            // 
            this.tabOther.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabOther.BackgroundImage")));
            this.tabOther.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabOther.Controls.Add(this.label22);
            this.tabOther.Controls.Add(this.label17);
            this.tabOther.Controls.Add(this.cmboSpeciality);
            this.tabOther.Controls.Add(this.label8);
            this.tabOther.Location = new System.Drawing.Point(4, 22);
            this.tabOther.Name = "tabOther";
            this.tabOther.Size = new System.Drawing.Size(299, 214);
            this.tabOther.TabIndex = 2;
            this.tabOther.Text = "Other Items";
            this.tabOther.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Blue;
            this.label22.Location = new System.Drawing.Point(93, 38);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(118, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Choose Other Items";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(59, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(181, 24);
            this.label17.TabIndex = 6;
            this.label17.Text = "D && B Pizza Express";
            // 
            // cmboSpeciality
            // 
            this.cmboSpeciality.FormattingEnabled = true;
            this.cmboSpeciality.Items.AddRange(new object[] {
            "",
            "Wings - $5.00",
            "Cheese Sticks - $4.00",
            "Garlic Bread - $3.00"});
            this.cmboSpeciality.Location = new System.Drawing.Point(89, 57);
            this.cmboSpeciality.Name = "cmboSpeciality";
            this.cmboSpeciality.Size = new System.Drawing.Size(121, 21);
            this.cmboSpeciality.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Specialty Items";
            // 
            // tabContactInfo
            // 
            this.tabContactInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabContactInfo.BackgroundImage")));
            this.tabContactInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabContactInfo.Controls.Add(this.label19);
            this.tabContactInfo.Controls.Add(this.label18);
            this.tabContactInfo.Controls.Add(this.txtBxEmail);
            this.tabContactInfo.Controls.Add(this.txtBxPhone);
            this.tabContactInfo.Controls.Add(this.txtBxAddress);
            this.tabContactInfo.Controls.Add(this.txtBxName);
            this.tabContactInfo.Controls.Add(this.label15);
            this.tabContactInfo.Controls.Add(this.label14);
            this.tabContactInfo.Controls.Add(this.label13);
            this.tabContactInfo.Controls.Add(this.label12);
            this.tabContactInfo.Location = new System.Drawing.Point(4, 22);
            this.tabContactInfo.Name = "tabContactInfo";
            this.tabContactInfo.Size = new System.Drawing.Size(299, 214);
            this.tabContactInfo.TabIndex = 3;
            this.tabContactInfo.Text = "Customer Info";
            this.tabContactInfo.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(49, 186);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(201, 24);
            this.label19.TabIndex = 9;
            this.label19.Text = "Delivery Contact Info";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(59, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(181, 24);
            this.label18.TabIndex = 8;
            this.label18.Text = "D && B Pizza Express";
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(45, 105);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(133, 20);
            this.txtBxEmail.TabIndex = 7;
            // 
            // txtBxPhone
            // 
            this.txtBxPhone.Location = new System.Drawing.Point(51, 81);
            this.txtBxPhone.Name = "txtBxPhone";
            this.txtBxPhone.Size = new System.Drawing.Size(100, 20);
            this.txtBxPhone.TabIndex = 6;
            // 
            // txtBxAddress
            // 
            this.txtBxAddress.Location = new System.Drawing.Point(112, 57);
            this.txtBxAddress.Name = "txtBxAddress";
            this.txtBxAddress.Size = new System.Drawing.Size(171, 20);
            this.txtBxAddress.TabIndex = 5;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(48, 33);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(168, 20);
            this.txtBxName.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(3, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Email:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(3, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Delivery  Address:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(3, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Phone:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(3, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Name:";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(215, 246);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceOrder.TabIndex = 4;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Location = new System.Drawing.Point(5, 227);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMsg.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(17, 246);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset Order";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 275);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnPlaceOrder);
            this.Name = "PizzaForm";
            this.Text = "B & D Pizza Express";
            this.Load += new System.EventHandler(this.PizzaForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPizza.ResumeLayout(false);
            this.tabPizza.PerformLayout();
            this.tabBeverage.ResumeLayout(false);
            this.tabBeverage.PerformLayout();
            this.tabOther.ResumeLayout(false);
            this.tabOther.PerformLayout();
            this.tabContactInfo.ResumeLayout(false);
            this.tabContactInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPizza;
        private System.Windows.Forms.TabPage tabBeverage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.ComboBox cmboCrust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmboSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBxWaterQty;
        private System.Windows.Forms.TextBox txtBxSodaQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabOther;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmboSpeciality;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstBxToppings;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmboSpecialPizza;
        private System.Windows.Forms.TabPage tabContactInfo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.TextBox txtBxPhone;
        private System.Windows.Forms.TextBox txtBxAddress;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmboSauce;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnReset;
    }
}

