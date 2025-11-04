namespace _2200_M05_Participation_Start
{
    partial class ProductForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnProdSearch = new System.Windows.Forms.Button();
            this.BtnGroupCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_2200_M05_Participation_Start.Properties.Resources.before;
            this.pictureBox1.Location = new System.Drawing.Point(-90, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 439);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnProdSearch
            // 
            this.BtnProdSearch.BackColor = System.Drawing.Color.Gray;
            this.BtnProdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProdSearch.ForeColor = System.Drawing.Color.White;
            this.BtnProdSearch.Location = new System.Drawing.Point(3, 361);
            this.BtnProdSearch.Name = "BtnProdSearch";
            this.BtnProdSearch.Size = new System.Drawing.Size(155, 34);
            this.BtnProdSearch.TabIndex = 1;
            this.BtnProdSearch.Text = "Product Search";
            this.BtnProdSearch.UseVisualStyleBackColor = false;
            this.BtnProdSearch.Click += new System.EventHandler(this.BtnProdSearch_Click);
            // 
            // BtnGroupCat
            // 
            this.BtnGroupCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGroupCat.Location = new System.Drawing.Point(164, 361);
            this.BtnGroupCat.Name = "BtnGroupCat";
            this.BtnGroupCat.Size = new System.Drawing.Size(179, 34);
            this.BtnGroupCat.TabIndex = 2;
            this.BtnGroupCat.Text = "Group By Category";
            this.BtnGroupCat.UseVisualStyleBackColor = true;
            this.BtnGroupCat.Click += new System.EventHandler(this.BtnGroupCat_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 430);
            this.Controls.Add(this.BtnGroupCat);
            this.Controls.Add(this.BtnProdSearch);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProductForm";
            this.Text = "Your First Name\'s Clothes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnProdSearch;
        private System.Windows.Forms.Button BtnGroupCat;
    }
}

