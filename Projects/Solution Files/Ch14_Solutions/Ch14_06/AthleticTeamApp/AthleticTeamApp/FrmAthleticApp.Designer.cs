namespace AthleticTeamApp
{
    partial class FrmAthleticApp
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
            System.Windows.Forms.Label sportLabel;
            System.Windows.Forms.Label coachLastNameLabel;
            System.Windows.Forms.Label coachFirstNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAthleticApp));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.teamDataSet = new AthleticTeamApp.TeamDataSet();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamTableAdapter = new AthleticTeamApp.TeamDataSetTableAdapters.TeamTableAdapter();
            this.tableAdapterManager = new AthleticTeamApp.TeamDataSetTableAdapters.TableAdapterManager();
            this.athleteTableAdapter = new AthleticTeamApp.TeamDataSetTableAdapters.AthleteTableAdapter();
            this.teamBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.teamBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sportTextBox = new System.Windows.Forms.TextBox();
            this.coachLastNameTextBox = new System.Windows.Forms.TextBox();
            this.coachFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.athleteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.athleteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sportLabel = new System.Windows.Forms.Label();
            coachLastNameLabel = new System.Windows.Forms.Label();
            coachFirstNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingNavigator)).BeginInit();
            this.teamBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.athleteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athleteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sportLabel
            // 
            sportLabel.AutoSize = true;
            sportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sportLabel.Location = new System.Drawing.Point(18, 42);
            sportLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sportLabel.Name = "sportLabel";
            sportLabel.Size = new System.Drawing.Size(59, 24);
            sportLabel.TabIndex = 1;
            sportLabel.Text = "Sport:";
            // 
            // coachLastNameLabel
            // 
            coachLastNameLabel.AutoSize = true;
            coachLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            coachLastNameLabel.Location = new System.Drawing.Point(18, 80);
            coachLastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            coachLastNameLabel.Name = "coachLastNameLabel";
            coachLastNameLabel.Size = new System.Drawing.Size(164, 24);
            coachLastNameLabel.TabIndex = 3;
            coachLastNameLabel.Text = "Coach Last Name:";
            // 
            // coachFirstNameLabel
            // 
            coachFirstNameLabel.AutoSize = true;
            coachFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            coachFirstNameLabel.Location = new System.Drawing.Point(18, 118);
            coachFirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            coachFirstNameLabel.Name = "coachFirstNameLabel";
            coachFirstNameLabel.Size = new System.Drawing.Size(166, 24);
            coachFirstNameLabel.TabIndex = 5;
            coachFirstNameLabel.Text = "Coach First Name:";
            // 
            // teamDataSet
            // 
            this.teamDataSet.DataSetName = "TeamDataSet";
            this.teamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataMember = "Team";
            this.teamBindingSource.DataSource = this.teamDataSet;
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AthleteTableAdapter = this.athleteTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TeamTableAdapter = this.teamTableAdapter;
            this.tableAdapterManager.UpdateOrder = AthleticTeamApp.TeamDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // athleteTableAdapter
            // 
            this.athleteTableAdapter.ClearBeforeFill = true;
            // 
            // teamBindingNavigator
            // 
            this.teamBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.teamBindingNavigator.BindingSource = this.teamBindingSource;
            this.teamBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.teamBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.teamBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.teamBindingNavigatorSaveItem});
            this.teamBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.teamBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.teamBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.teamBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.teamBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.teamBindingNavigator.Name = "teamBindingNavigator";
            this.teamBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.teamBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.teamBindingNavigator.Size = new System.Drawing.Size(506, 25);
            this.teamBindingNavigator.TabIndex = 0;
            this.teamBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.ForeColor = System.Drawing.Color.Black;
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
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
            // teamBindingNavigatorSaveItem
            // 
            this.teamBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.teamBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("teamBindingNavigatorSaveItem.Image")));
            this.teamBindingNavigatorSaveItem.Name = "teamBindingNavigatorSaveItem";
            this.teamBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.teamBindingNavigatorSaveItem.Text = "Save Data";
            this.teamBindingNavigatorSaveItem.Click += new System.EventHandler(this.teamBindingNavigatorSaveItem_Click);
            // 
            // sportTextBox
            // 
            this.sportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamBindingSource, "Sport", true));
            this.sportTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sportTextBox.Location = new System.Drawing.Point(89, 37);
            this.sportTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sportTextBox.Name = "sportTextBox";
            this.sportTextBox.Size = new System.Drawing.Size(148, 29);
            this.sportTextBox.TabIndex = 2;
            // 
            // coachLastNameTextBox
            // 
            this.coachLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamBindingSource, "CoachLastName", true));
            this.coachLastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coachLastNameTextBox.Location = new System.Drawing.Point(196, 76);
            this.coachLastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.coachLastNameTextBox.Name = "coachLastNameTextBox";
            this.coachLastNameTextBox.Size = new System.Drawing.Size(148, 29);
            this.coachLastNameTextBox.TabIndex = 4;
            // 
            // coachFirstNameTextBox
            // 
            this.coachFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamBindingSource, "CoachFirstName", true));
            this.coachFirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coachFirstNameTextBox.Location = new System.Drawing.Point(196, 114);
            this.coachFirstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.coachFirstNameTextBox.Name = "coachFirstNameTextBox";
            this.coachFirstNameTextBox.Size = new System.Drawing.Size(148, 29);
            this.coachFirstNameTextBox.TabIndex = 6;
            // 
            // athleteBindingSource
            // 
            this.athleteBindingSource.DataMember = "TeamAthlete";
            this.athleteBindingSource.DataSource = this.teamBindingSource;
            // 
            // athleteDataGridView
            // 
            this.athleteDataGridView.AutoGenerateColumns = false;
            this.athleteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.athleteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.athleteDataGridView.DataSource = this.athleteBindingSource;
            this.athleteDataGridView.Location = new System.Drawing.Point(38, 196);
            this.athleteDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.athleteDataGridView.Name = "athleteDataGridView";
            this.athleteDataGridView.Size = new System.Drawing.Size(443, 95);
            this.athleteDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StudentLastName";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Athlete Last Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StudentFirstName";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn3.HeaderText = "Athlete First Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // FrmAthleticApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(506, 380);
            this.Controls.Add(this.athleteDataGridView);
            this.Controls.Add(coachFirstNameLabel);
            this.Controls.Add(this.coachFirstNameTextBox);
            this.Controls.Add(coachLastNameLabel);
            this.Controls.Add(this.coachLastNameTextBox);
            this.Controls.Add(sportLabel);
            this.Controls.Add(this.sportTextBox);
            this.Controls.Add(this.teamBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAthleticApp";
            this.Text = "Athletic Teams";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingNavigator)).EndInit();
            this.teamBindingNavigator.ResumeLayout(false);
            this.teamBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.athleteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athleteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TeamDataSet teamDataSet;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private TeamDataSetTableAdapters.TeamTableAdapter teamTableAdapter;
        private TeamDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator teamBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton teamBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox sportTextBox;
        private TeamDataSetTableAdapters.AthleteTableAdapter athleteTableAdapter;
        private System.Windows.Forms.TextBox coachLastNameTextBox;
        private System.Windows.Forms.TextBox coachFirstNameTextBox;
        private System.Windows.Forms.BindingSource athleteBindingSource;
        private System.Windows.Forms.DataGridView athleteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

