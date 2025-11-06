namespace WindowsFormsApp1
{
    partial class MovieCount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieCount));
            this.categoryCountBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.categoryCountBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.categoryCountDataGridView = new System.Windows.Forms.DataGridView();
            this.Closebtn = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNFO2200_CrandallSayDataSetCount = new WindowsFormsApp1.INFO2200_CrandallSayDataSetCount();
            this.categoryCountTableAdapter = new WindowsFormsApp1.INFO2200_CrandallSayDataSetCountTableAdapters.CategoryCountTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.INFO2200_CrandallSayDataSetCountTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCountBindingNavigator)).BeginInit();
            this.categoryCountBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCountDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSetCount)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryCountBindingNavigator
            // 
            this.categoryCountBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.categoryCountBindingNavigator.BindingSource = this.categoryCountBindingSource;
            this.categoryCountBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.categoryCountBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.categoryCountBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.categoryCountBindingNavigatorSaveItem});
            this.categoryCountBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categoryCountBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.categoryCountBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.categoryCountBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.categoryCountBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.categoryCountBindingNavigator.Name = "categoryCountBindingNavigator";
            this.categoryCountBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.categoryCountBindingNavigator.Size = new System.Drawing.Size(282, 25);
            this.categoryCountBindingNavigator.TabIndex = 0;
            this.categoryCountBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // categoryCountBindingNavigatorSaveItem
            // 
            this.categoryCountBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoryCountBindingNavigatorSaveItem.Enabled = false;
            this.categoryCountBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoryCountBindingNavigatorSaveItem.Image")));
            this.categoryCountBindingNavigatorSaveItem.Name = "categoryCountBindingNavigatorSaveItem";
            this.categoryCountBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.categoryCountBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // categoryCountDataGridView
            // 
            this.categoryCountDataGridView.AutoGenerateColumns = false;
            this.categoryCountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryCountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.categoryCountDataGridView.DataSource = this.categoryCountBindingSource;
            this.categoryCountDataGridView.Location = new System.Drawing.Point(12, 28);
            this.categoryCountDataGridView.Name = "categoryCountDataGridView";
            this.categoryCountDataGridView.Size = new System.Drawing.Size(258, 158);
            this.categoryCountDataGridView.TabIndex = 1;
            // 
            // Closebtn
            // 
            this.Closebtn.Location = new System.Drawing.Point(13, 192);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(257, 37);
            this.Closebtn.TabIndex = 2;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn1.HeaderText = "category";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "categoryCount";
            this.dataGridViewTextBoxColumn2.HeaderText = "categoryCount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // categoryCountBindingSource
            // 
            this.categoryCountBindingSource.DataMember = "CategoryCount";
            this.categoryCountBindingSource.DataSource = this.iNFO2200_CrandallSayDataSetCount;
            // 
            // iNFO2200_CrandallSayDataSetCount
            // 
            this.iNFO2200_CrandallSayDataSetCount.DataSetName = "INFO2200_CrandallSayDataSetCount";
            this.iNFO2200_CrandallSayDataSetCount.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryCountTableAdapter
            // 
            this.categoryCountTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.INFO2200_CrandallSayDataSetCountTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MovieCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 241);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.categoryCountDataGridView);
            this.Controls.Add(this.categoryCountBindingNavigator);
            this.Name = "MovieCount";
            this.Text = "Count By Category";
            this.Load += new System.EventHandler(this.MovieCount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryCountBindingNavigator)).EndInit();
            this.categoryCountBindingNavigator.ResumeLayout(false);
            this.categoryCountBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCountDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryCountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSetCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private INFO2200_CrandallSayDataSetCount iNFO2200_CrandallSayDataSetCount;
        private System.Windows.Forms.BindingSource categoryCountBindingSource;
        private INFO2200_CrandallSayDataSetCountTableAdapters.CategoryCountTableAdapter categoryCountTableAdapter;
        private INFO2200_CrandallSayDataSetCountTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator categoryCountBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton categoryCountBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView categoryCountDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button Closebtn;
    }
}