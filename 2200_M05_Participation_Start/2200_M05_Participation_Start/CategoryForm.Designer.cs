namespace _2200_M05_Participation_Start
{
    partial class CategoryForm
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
            this.LvCategories = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // LvCategories
            // 
            this.LvCategories.HideSelection = false;
            this.LvCategories.Location = new System.Drawing.Point(13, 13);
            this.LvCategories.Name = "LvCategories";
            this.LvCategories.Size = new System.Drawing.Size(375, 425);
            this.LvCategories.TabIndex = 0;
            this.LvCategories.UseCompatibleStateImageBehavior = false;
            this.LvCategories.View = System.Windows.Forms.View.Details;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.LvCategories);
            this.Name = "CategoryForm";
            this.Text = "Category Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvCategories;
    }
}