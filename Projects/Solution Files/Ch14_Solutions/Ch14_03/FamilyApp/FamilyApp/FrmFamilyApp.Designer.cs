namespace FamilyApp
{
    partial class FrmFamilyApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFamilyApp));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.familyDataSet = new FamilyApp.FamilyDataSet();
            this.familyTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familyTableTableAdapter = new FamilyApp.FamilyDataSetTableAdapters.FamilyTableTableAdapter();
            this.tableAdapterManager = new FamilyApp.FamilyDataSetTableAdapters.TableAdapterManager();
            this.familyTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.familyTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dtaGridFamilyTable = new System.Windows.Forms.DataGridView();
            this.lblHeading = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyTableBindingNavigator)).BeginInit();
            this.familyTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridFamilyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // familyDataSet
            // 
            this.familyDataSet.DataSetName = "FamilyDataSet";
            this.familyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // familyTableBindingSource
            // 
            this.familyTableBindingSource.DataMember = "FamilyTable";
            this.familyTableBindingSource.DataSource = this.familyDataSet;
            // 
            // familyTableTableAdapter
            // 
            this.familyTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FamilyTableTableAdapter = this.familyTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = FamilyApp.FamilyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // familyTableBindingNavigator
            // 
            this.familyTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.familyTableBindingNavigator.BindingSource = this.familyTableBindingSource;
            this.familyTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.familyTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.familyTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.familyTableBindingNavigatorSaveItem});
            this.familyTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.familyTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.familyTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.familyTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.familyTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.familyTableBindingNavigator.Name = "familyTableBindingNavigator";
            this.familyTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.familyTableBindingNavigator.Size = new System.Drawing.Size(473, 25);
            this.familyTableBindingNavigator.TabIndex = 0;
            this.familyTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // familyTableBindingNavigatorSaveItem
            // 
            this.familyTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.familyTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("familyTableBindingNavigatorSaveItem.Image")));
            this.familyTableBindingNavigatorSaveItem.Name = "familyTableBindingNavigatorSaveItem";
            this.familyTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.familyTableBindingNavigatorSaveItem.Text = "Save Data";
            this.familyTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.familyTableBindingNavigatorSaveItem_Click);
            // 
            // dtaGridFamilyTable
            // 
            this.dtaGridFamilyTable.AutoGenerateColumns = false;
            this.dtaGridFamilyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridFamilyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dtaGridFamilyTable.DataSource = this.familyTableBindingSource;
            this.dtaGridFamilyTable.Location = new System.Drawing.Point(37, 85);
            this.dtaGridFamilyTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtaGridFamilyTable.Name = "dtaGridFamilyTable";
            this.dtaGridFamilyTable.Size = new System.Drawing.Size(398, 106);
            this.dtaGridFamilyTable.TabIndex = 1;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblHeading.Location = new System.Drawing.Point(108, 41);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(257, 26);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Family Members Over 21";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "firstName";
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lastName";
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "relationship";
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn5.HeaderText = "Relationship";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "age";
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn6.HeaderText = "Age";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // FrmFamilyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(473, 332);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.dtaGridFamilyTable);
            this.Controls.Add(this.familyTableBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmFamilyApp";
            this.Text = "Joan Lettinga\'s Family";
            this.Load += new System.EventHandler(this.FrmFamilyApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyTableBindingNavigator)).EndInit();
            this.familyTableBindingNavigator.ResumeLayout(false);
            this.familyTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridFamilyTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FamilyDataSet familyDataSet;
        private System.Windows.Forms.BindingSource familyTableBindingSource;
        private FamilyDataSetTableAdapters.FamilyTableTableAdapter familyTableTableAdapter;
        private FamilyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator familyTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton familyTableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dtaGridFamilyTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

