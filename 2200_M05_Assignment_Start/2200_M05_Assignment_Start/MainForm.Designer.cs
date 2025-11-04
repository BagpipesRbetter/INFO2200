namespace _2200_M05_Assignment_Start
{
    partial class MainForm
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
            this.btnSearchFlavors = new System.Windows.Forms.Button();
            this.btnShowFlavor = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_2200_M05_Assignment_Start.Properties.Resources.jellybellylogo;
            this.pictureBox1.Location = new System.Drawing.Point(29, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearchFlavors
            // 
            this.btnSearchFlavors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFlavors.Location = new System.Drawing.Point(289, 378);
            this.btnSearchFlavors.Name = "btnSearchFlavors";
            this.btnSearchFlavors.Size = new System.Drawing.Size(203, 31);
            this.btnSearchFlavors.TabIndex = 1;
            this.btnSearchFlavors.Text = "Search Jelly Belly Flavors";
            this.btnSearchFlavors.UseVisualStyleBackColor = true;
            this.btnSearchFlavors.Click += new System.EventHandler(this.btnSearchFlavors_Click);
            // 
            // btnShowFlavor
            // 
            this.btnShowFlavor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFlavor.Location = new System.Drawing.Point(29, 378);
            this.btnShowFlavor.Name = "btnShowFlavor";
            this.btnShowFlavor.Size = new System.Drawing.Size(203, 31);
            this.btnShowFlavor.TabIndex = 2;
            this.btnShowFlavor.Text = "Show Flavor Categories";
            this.btnShowFlavor.UseVisualStyleBackColor = true;
            this.btnShowFlavor.Click += new System.EventHandler(this.btnShowFlavor_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(407, 424);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 463);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShowFlavor);
            this.Controls.Add(this.btnSearchFlavors);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Jelly Belly Central";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearchFlavors;
        private System.Windows.Forms.Button btnShowFlavor;
        private System.Windows.Forms.Button btnClose;
    }
}

