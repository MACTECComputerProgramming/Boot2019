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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label relationshipLabel;
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.relationshipTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            relationshipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyTableBindingNavigator)).BeginInit();
            this.familyTableBindingNavigator.SuspendLayout();
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
            this.familyTableBindingNavigator.Size = new System.Drawing.Size(355, 25);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = System.Drawing.Color.PaleGreen;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(26, 98);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(101, 20);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.PaleGreen;
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.familyTableBindingSource, "firstName", true));
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(141, 95);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(124, 26);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = System.Drawing.Color.PaleGreen;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(26, 124);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(100, 20);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.PaleGreen;
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.familyTableBindingSource, "lastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(141, 121);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(124, 26);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // relationshipLabel
            // 
            relationshipLabel.AutoSize = true;
            relationshipLabel.BackColor = System.Drawing.Color.PaleGreen;
            relationshipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            relationshipLabel.Location = new System.Drawing.Point(26, 152);
            relationshipLabel.Name = "relationshipLabel";
            relationshipLabel.Size = new System.Drawing.Size(114, 20);
            relationshipLabel.TabIndex = 9;
            relationshipLabel.Text = "Relationship:";
            // 
            // relationshipTextBox
            // 
            this.relationshipTextBox.BackColor = System.Drawing.Color.PaleGreen;
            this.relationshipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.familyTableBindingSource, "relationship", true));
            this.relationshipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relationshipTextBox.Location = new System.Drawing.Point(141, 149);
            this.relationshipTextBox.Name = "relationshipTextBox";
            this.relationshipTextBox.Size = new System.Drawing.Size(124, 26);
            this.relationshipTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Family Members Who";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Live in My Hometown";
            // 
            // FrmFamilyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(355, 270);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(relationshipLabel);
            this.Controls.Add(this.relationshipTextBox);
            this.Controls.Add(this.familyTableBindingNavigator);
            this.Name = "FrmFamilyApp";
            this.Text = "Joan Lettinga\'s Family";
            this.Load += new System.EventHandler(this.FrmFamilyApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyTableBindingNavigator)).EndInit();
            this.familyTableBindingNavigator.ResumeLayout(false);
            this.familyTableBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox relationshipTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

