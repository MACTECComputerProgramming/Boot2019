namespace BankAccountApp
{
    partial class FrmBankApp
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
            System.Windows.Forms.Label lblBalance;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankApp));
            this.accountBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsDataSet = new BankAccountApp.AccountsDataSet();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnToolStripRetrieve = new System.Windows.Forms.ToolStripButton();
            this.txtBxBalance = new System.Windows.Forms.TextBox();
            this.accountTableAdapter = new BankAccountApp.AccountsDataSetTableAdapters.AccountTableAdapter();
            this.tableAdapterManager = new BankAccountApp.AccountsDataSetTableAdapters.TableAdapterManager();
            this.txtBxAccNo = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblMessage = new System.Windows.Forms.Label();
            lblBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingNavigator)).BeginInit();
            this.accountBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new System.Drawing.Point(130, 100);
            lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new System.Drawing.Size(118, 18);
            lblBalance.TabIndex = 1;
            lblBalance.Text = "Current Balance:";
            // 
            // accountBindingNavigator
            // 
            this.accountBindingNavigator.AddNewItem = null;
            this.accountBindingNavigator.BindingSource = this.accountBindingSource;
            this.accountBindingNavigator.CountItem = null;
            this.accountBindingNavigator.DeleteItem = null;
            this.accountBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator2,
            this.btnToolStripRetrieve});
            this.accountBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.accountBindingNavigator.MoveFirstItem = null;
            this.accountBindingNavigator.MoveLastItem = null;
            this.accountBindingNavigator.MoveNextItem = null;
            this.accountBindingNavigator.MovePreviousItem = null;
            this.accountBindingNavigator.Name = "accountBindingNavigator";
            this.accountBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.accountBindingNavigator.PositionItem = null;
            this.accountBindingNavigator.Size = new System.Drawing.Size(513, 32);
            this.accountBindingNavigator.TabIndex = 0;
            this.accountBindingNavigator.Text = "bindingNavigator1";
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.accountsDataSet;
            // 
            // accountsDataSet
            // 
            this.accountsDataSet.DataSetName = "AccountsDataSet";
            this.accountsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // btnToolStripRetrieve
            // 
            this.btnToolStripRetrieve.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnToolStripRetrieve.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnToolStripRetrieve.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnToolStripRetrieve.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnToolStripRetrieve.Image = ((System.Drawing.Image)(resources.GetObject("btnToolStripRetrieve.Image")));
            this.btnToolStripRetrieve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolStripRetrieve.Name = "btnToolStripRetrieve";
            this.btnToolStripRetrieve.Size = new System.Drawing.Size(257, 29);
            this.btnToolStripRetrieve.Text = "Retrieve By Account Number";
            this.btnToolStripRetrieve.Click += new System.EventHandler(this.btnToolStripRetrieve_Click);
            // 
            // txtBxBalance
            // 
            this.txtBxBalance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountBindingSource, "CurrentBalance", true));
            this.txtBxBalance.Location = new System.Drawing.Point(268, 96);
            this.txtBxBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxBalance.Name = "txtBxBalance";
            this.txtBxBalance.Size = new System.Drawing.Size(115, 24);
            this.txtBxBalance.TabIndex = 2;
            this.txtBxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = this.accountTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BankAccountApp.AccountsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtBxAccNo
            // 
            this.txtBxAccNo.Location = new System.Drawing.Point(282, 5);
            this.txtBxAccNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxAccNo.Name = "txtBxAccNo";
            this.txtBxAccNo.Size = new System.Drawing.Size(148, 24);
            this.txtBxAccNo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtBxAccNo, "Enter account number then click Retrieve button");
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(47, 206);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 18);
            this.lblMessage.TabIndex = 3;
            // 
            // FrmBankApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 363);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtBxAccNo);
            this.Controls.Add(lblBalance);
            this.Controls.Add(this.txtBxBalance);
            this.Controls.Add(this.accountBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBankApp";
            this.Text = "Banking App...";
            this.Load += new System.EventHandler(this.FrmBankingAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingNavigator)).EndInit();
            this.accountBindingNavigator.ResumeLayout(false);
            this.accountBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AccountsDataSet accountsDataSet;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private AccountsDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private AccountsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator accountBindingNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox txtBxBalance;
        private System.Windows.Forms.ToolStripButton btnToolStripRetrieve;
        private System.Windows.Forms.TextBox txtBxAccNo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblMessage;
    }
}

