namespace pythontest
{
    partial class frmMain
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
            this.uiShowPicture = new System.Windows.Forms.PictureBox();
            this.uiShowResult = new System.Windows.Forms.TextBox();
            this.uiActionChoosePicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiShowPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // uiShowPicture
            // 
            this.uiShowPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiShowPicture.Location = new System.Drawing.Point(12, 62);
            this.uiShowPicture.Name = "uiShowPicture";
            this.uiShowPicture.Size = new System.Drawing.Size(330, 365);
            this.uiShowPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiShowPicture.TabIndex = 1;
            this.uiShowPicture.TabStop = false;
            // 
            // uiShowResult
            // 
            this.uiShowResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiShowResult.Location = new System.Drawing.Point(12, 438);
            this.uiShowResult.Name = "uiShowResult";
            this.uiShowResult.ReadOnly = true;
            this.uiShowResult.Size = new System.Drawing.Size(330, 20);
            this.uiShowResult.TabIndex = 2;
            // 
            // uiActionChoosePicture
            // 
            this.uiActionChoosePicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiActionChoosePicture.Location = new System.Drawing.Point(12, 27);
            this.uiActionChoosePicture.Name = "uiActionChoosePicture";
            this.uiActionChoosePicture.Size = new System.Drawing.Size(330, 23);
            this.uiActionChoosePicture.TabIndex = 0;
            this.uiActionChoosePicture.Text = "Odaberi sliku";
            this.uiActionChoosePicture.UseVisualStyleBackColor = true;
            this.uiActionChoosePicture.Click += new System.EventHandler(this.uiActionChoosePicture_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 461);
            this.Controls.Add(this.uiActionChoosePicture);
            this.Controls.Add(this.uiShowResult);
            this.Controls.Add(this.uiShowPicture);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klasifikator slika";
            ((System.ComponentModel.ISupportInitialize)(this.uiShowPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox uiShowPicture;
        private System.Windows.Forms.TextBox uiShowResult;
        private System.Windows.Forms.Button uiActionChoosePicture;
    }
}

