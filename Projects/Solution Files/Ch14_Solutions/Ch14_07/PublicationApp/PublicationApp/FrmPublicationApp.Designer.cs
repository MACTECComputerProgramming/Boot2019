namespace PublicationApp
{
    partial class FrmPublicationApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPublicationApp));
            this.booksDataSet = new PublicationApp.BooksDataSet();
            this.bookTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableTableAdapter = new PublicationApp.BooksDataSetTableAdapters.BookTableTableAdapter();
            this.tableAdapterManager = new PublicationApp.BooksDataSetTableAdapters.TableAdapterManager();
            this.bookTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bookTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bookTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableBindingNavigator)).BeginInit();
            this.bookTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "BooksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableBindingSource
            // 
            this.bookTableBindingSource.DataMember = "BookTable";
            this.bookTableBindingSource.DataSource = this.booksDataSet;
            // 
            // bookTableTableAdapter
            // 
            this.bookTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableTableAdapter = this.bookTableTableAdapter;
            this.tableAdapterManager.CourseBookTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PublicationApp.BooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookTableBindingNavigator
            // 
            this.bookTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bookTableBindingNavigator.BindingSource = this.bookTableBindingSource;
            this.bookTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bookTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bookTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bookTableBindingNavigatorSaveItem});
            this.bookTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bookTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bookTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bookTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bookTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bookTableBindingNavigator.Name = "bookTableBindingNavigator";
            this.bookTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bookTableBindingNavigator.Size = new System.Drawing.Size(431, 25);
            this.bookTableBindingNavigator.TabIndex = 0;
            this.bookTableBindingNavigator.Text = "bindingNavigator1";
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
            // bookTableBindingNavigatorSaveItem
            // 
            this.bookTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookTableBindingNavigatorSaveItem.Image")));
            this.bookTableBindingNavigatorSaveItem.Name = "bookTableBindingNavigatorSaveItem";
            this.bookTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bookTableBindingNavigatorSaveItem.Text = "Save Data";
            this.bookTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.bookTableBindingNavigatorSaveItem_Click);
            // 
            // bookTableDataGridView
            // 
            this.bookTableDataGridView.AutoGenerateColumns = false;
            this.bookTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.bookTableDataGridView.DataSource = this.bookTableBindingSource;
            this.bookTableDataGridView.Location = new System.Drawing.Point(0, 57);
            this.bookTableDataGridView.Name = "bookTableDataGridView";
            this.bookTableDataGridView.Size = new System.Drawing.Size(431, 196);
            this.bookTableDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CourseNumber";
            this.dataGridViewTextBoxColumn8.HeaderText = "Course Number (or Fun)";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 75;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn1.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Book Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // FrmPublicationApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 339);
            this.Controls.Add(this.bookTableDataGridView);
            this.Controls.Add(this.bookTableBindingNavigator);
            this.Name = "FrmPublicationApp";
            this.Text = "Publication App..";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableBindingNavigator)).EndInit();
            this.bookTableBindingNavigator.ResumeLayout(false);
            this.bookTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BooksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource bookTableBindingSource;
        private BooksDataSetTableAdapters.BookTableTableAdapter bookTableTableAdapter;
        private BooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bookTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bookTableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bookTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

