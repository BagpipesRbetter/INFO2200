namespace _2200_BarclayE_Participation04
{
    partial class LandingForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnImportedPhoneNumbers = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLocalPhoneNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(106, 61);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 52);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnImportedPhoneNumbers
            // 
            this.btnImportedPhoneNumbers.Location = new System.Drawing.Point(106, 6);
            this.btnImportedPhoneNumbers.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportedPhoneNumbers.Name = "btnImportedPhoneNumbers";
            this.btnImportedPhoneNumbers.Size = new System.Drawing.Size(96, 52);
            this.btnImportedPhoneNumbers.TabIndex = 1;
            this.btnImportedPhoneNumbers.Text = "Imported Phone Numbers";
            this.btnImportedPhoneNumbers.UseVisualStyleBackColor = true;
            this.btnImportedPhoneNumbers.Click += new System.EventHandler(this.btnImportedPhoneNumbers_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 61);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnLocalPhoneNumbers
            // 
            this.btnLocalPhoneNumbers.Location = new System.Drawing.Point(6, 6);
            this.btnLocalPhoneNumbers.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocalPhoneNumbers.Name = "btnLocalPhoneNumbers";
            this.btnLocalPhoneNumbers.Size = new System.Drawing.Size(96, 52);
            this.btnLocalPhoneNumbers.TabIndex = 3;
            this.btnLocalPhoneNumbers.Text = "&Local Phone Numbers";
            this.btnLocalPhoneNumbers.UseVisualStyleBackColor = true;
            this.btnLocalPhoneNumbers.Click += new System.EventHandler(this.btnLocalPhoneNumbers_Click);
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 146);
            this.Controls.Add(this.btnLocalPhoneNumbers);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnImportedPhoneNumbers);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LandingForm";
            this.Text = "Landing Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnImportedPhoneNumbers;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLocalPhoneNumbers;
    }
}

