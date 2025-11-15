namespace _2200_M05_Participation_Start
{
    partial class ProductSearchForm
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
            this.DgvProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxProductDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbProductId = new System.Windows.Forms.ComboBox();
            this.BtnAddNewProd = new System.Windows.Forms.Button();
            this.BtnDeleteProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProducts
            // 
            this.DgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducts.Location = new System.Drawing.Point(13, 13);
            this.DgvProducts.Name = "DgvProducts";
            this.DgvProducts.Size = new System.Drawing.Size(775, 143);
            this.DgvProducts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Description:";
            // 
            // TxtBoxProductDesc
            // 
            this.TxtBoxProductDesc.Location = new System.Drawing.Point(123, 179);
            this.TxtBoxProductDesc.Name = "TxtBoxProductDesc";
            this.TxtBoxProductDesc.Size = new System.Drawing.Size(231, 20);
            this.TxtBoxProductDesc.TabIndex = 2;
            this.TxtBoxProductDesc.TextChanged += new System.EventHandler(this.TxtBoxProductDesc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Id:";
            // 
            // CbProductId
            // 
            this.CbProductId.FormattingEnabled = true;
            this.CbProductId.Location = new System.Drawing.Point(355, 221);
            this.CbProductId.Name = "CbProductId";
            this.CbProductId.Size = new System.Drawing.Size(180, 21);
            this.CbProductId.TabIndex = 4;
            // 
            // BtnAddNewProd
            // 
            this.BtnAddNewProd.Location = new System.Drawing.Point(616, 179);
            this.BtnAddNewProd.Name = "BtnAddNewProd";
            this.BtnAddNewProd.Size = new System.Drawing.Size(172, 23);
            this.BtnAddNewProd.TabIndex = 5;
            this.BtnAddNewProd.Text = "Add New Product";
            this.BtnAddNewProd.UseVisualStyleBackColor = true;
            this.BtnAddNewProd.Click += new System.EventHandler(this.BtnAddNewProd_Click);
            // 
            // BtnDeleteProd
            // 
            this.BtnDeleteProd.Location = new System.Drawing.Point(616, 224);
            this.BtnDeleteProd.Name = "BtnDeleteProd";
            this.BtnDeleteProd.Size = new System.Drawing.Size(172, 23);
            this.BtnDeleteProd.TabIndex = 6;
            this.BtnDeleteProd.Text = "Delete Product";
            this.BtnDeleteProd.UseVisualStyleBackColor = true;
            this.BtnDeleteProd.Click += new System.EventHandler(this.BtnDeleteProd_Click);
            // 
            // ProductSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 411);
            this.Controls.Add(this.BtnDeleteProd);
            this.Controls.Add(this.BtnAddNewProd);
            this.Controls.Add(this.CbProductId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBoxProductDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvProducts);
            this.Name = "ProductSearchForm";
            this.Text = "Product Search Form";
            this.Load += new System.EventHandler(this.ProductSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxProductDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbProductId;
        private System.Windows.Forms.Button BtnAddNewProd;
        private System.Windows.Forms.Button BtnDeleteProd;
    }
}