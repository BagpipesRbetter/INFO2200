namespace _2200_BarclayE_Participation04
{
    partial class LocalPhoneNumbersForm
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
            this.phoneListDataGridView = new System.Windows.Forms.DataGridView();
            this.Searchbox = new System.Windows.Forms.GroupBox();
            this.SortByLastbtn = new System.Windows.Forms.Button();
            this.Age30btn = new System.Windows.Forms.Button();
            this.AvgAgebtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localPhoneListDBDataSet = new _2200_BarclayE_Participation04.LocalPhoneListDBDataSet();
            this.phoneListTableAdapter = new _2200_BarclayE_Participation04.LocalPhoneListDBDataSetTableAdapters.PhoneListTableAdapter();
            this.tableAdapterManager = new _2200_BarclayE_Participation04.LocalPhoneListDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListDataGridView)).BeginInit();
            this.Searchbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localPhoneListDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneListDataGridView
            // 
            this.phoneListDataGridView.AutoGenerateColumns = false;
            this.phoneListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.phoneListDataGridView.DataSource = this.phoneListBindingSource;
            this.phoneListDataGridView.Location = new System.Drawing.Point(12, 12);
            this.phoneListDataGridView.Name = "phoneListDataGridView";
            this.phoneListDataGridView.Size = new System.Drawing.Size(548, 363);
            this.phoneListDataGridView.TabIndex = 0;
            // 
            // Searchbox
            // 
            this.Searchbox.Controls.Add(this.textBox1);
            this.Searchbox.Controls.Add(this.Searchbtn);
            this.Searchbox.Location = new System.Drawing.Point(12, 381);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.Size = new System.Drawing.Size(235, 124);
            this.Searchbox.TabIndex = 1;
            this.Searchbox.TabStop = false;
            this.Searchbox.Text = "Search";
            // 
            // SortByLastbtn
            // 
            this.SortByLastbtn.Location = new System.Drawing.Point(253, 382);
            this.SortByLastbtn.Name = "SortByLastbtn";
            this.SortByLastbtn.Size = new System.Drawing.Size(157, 52);
            this.SortByLastbtn.TabIndex = 2;
            this.SortByLastbtn.Text = "Sort By Last Name";
            this.SortByLastbtn.UseVisualStyleBackColor = true;
            // 
            // Age30btn
            // 
            this.Age30btn.Location = new System.Drawing.Point(416, 382);
            this.Age30btn.Name = "Age30btn";
            this.Age30btn.Size = new System.Drawing.Size(141, 52);
            this.Age30btn.TabIndex = 3;
            this.Age30btn.Text = "Age > 30";
            this.Age30btn.UseVisualStyleBackColor = true;
            // 
            // AvgAgebtn
            // 
            this.AvgAgebtn.Location = new System.Drawing.Point(416, 440);
            this.AvgAgebtn.Name = "AvgAgebtn";
            this.AvgAgebtn.Size = new System.Drawing.Size(144, 50);
            this.AvgAgebtn.TabIndex = 4;
            this.AvgAgebtn.Text = "Average Age";
            this.AvgAgebtn.UseVisualStyleBackColor = true;
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(253, 440);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(157, 50);
            this.Clearbtn.TabIndex = 5;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(7, 46);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(221, 63);
            this.Searchbtn.TabIndex = 0;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PersonID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PersonID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn5.HeaderText = "Age";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // phoneListBindingSource
            // 
            this.phoneListBindingSource.DataMember = "PhoneList";
            this.phoneListBindingSource.DataSource = this.localPhoneListDBDataSet;
            // 
            // localPhoneListDBDataSet
            // 
            this.localPhoneListDBDataSet.DataSetName = "LocalPhoneListDBDataSet";
            this.localPhoneListDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phoneListTableAdapter
            // 
            this.phoneListTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PhoneListTableAdapter = this.phoneListTableAdapter;
            this.tableAdapterManager.UpdateOrder = _2200_BarclayE_Participation04.LocalPhoneListDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LocalPhoneNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 514);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.AvgAgebtn);
            this.Controls.Add(this.Age30btn);
            this.Controls.Add(this.SortByLastbtn);
            this.Controls.Add(this.Searchbox);
            this.Controls.Add(this.phoneListDataGridView);
            this.Name = "LocalPhoneNumbersForm";
            this.Text = "Local Phone Numbers";
            this.Load += new System.EventHandler(this.LocalPhoneNumbersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phoneListDataGridView)).EndInit();
            this.Searchbox.ResumeLayout(false);
            this.Searchbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localPhoneListDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LocalPhoneListDBDataSet localPhoneListDBDataSet;
        private System.Windows.Forms.BindingSource phoneListBindingSource;
        private LocalPhoneListDBDataSetTableAdapters.PhoneListTableAdapter phoneListTableAdapter;
        private LocalPhoneListDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView phoneListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox Searchbox;
        private System.Windows.Forms.Button SortByLastbtn;
        private System.Windows.Forms.Button Age30btn;
        private System.Windows.Forms.Button AvgAgebtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Searchbtn;
    }
}