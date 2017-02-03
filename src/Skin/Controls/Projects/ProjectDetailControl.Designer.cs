namespace Skin.Controls.Projects
{
    partial class ProjectDetailControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbProjectDetail = new Skin.Controls.TransparentPictureBox();
            this.pbHomePage = new Skin.Controls.TransparentPictureBox();
            this.pbPrevious = new Skin.Controls.TransparentPictureBox();
            this.pbProjectImage = new Skin.Controls.TransparentPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProjectDetail)).BeginInit();
            this.pbProjectDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProjectImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProjectDetail
            // 
            this.pbProjectDetail.BackColor = System.Drawing.Color.Transparent;
            this.pbProjectDetail.Controls.Add(this.pbHomePage);
            this.pbProjectDetail.Controls.Add(this.pbPrevious);
            this.pbProjectDetail.Controls.Add(this.pbProjectImage);
            this.pbProjectDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProjectDetail.Image = global::Skin.Resources.ProjectDetail;
            this.pbProjectDetail.Location = new System.Drawing.Point(0, 0);
            this.pbProjectDetail.Name = "pbProjectDetail";
            this.pbProjectDetail.Size = new System.Drawing.Size(1024, 560);
            this.pbProjectDetail.TabIndex = 0;
            this.pbProjectDetail.TabStop = false;
            // 
            // pbHomePage
            // 
            this.pbHomePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHomePage.BackColor = System.Drawing.Color.Transparent;
            this.pbHomePage.Image = global::Skin.Resources.GoHomePage;
            this.pbHomePage.Location = new System.Drawing.Point(931, 19);
            this.pbHomePage.Name = "pbHomePage";
            this.pbHomePage.Size = new System.Drawing.Size(51, 50);
            this.pbHomePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHomePage.TabIndex = 8;
            this.pbHomePage.TabStop = false;
            // 
            // pbPrevious
            // 
            this.pbPrevious.BackColor = System.Drawing.Color.Transparent;
            this.pbPrevious.Image = global::Skin.Resources.Previous;
            this.pbPrevious.Location = new System.Drawing.Point(31, 19);
            this.pbPrevious.Name = "pbPrevious";
            this.pbPrevious.Size = new System.Drawing.Size(51, 50);
            this.pbPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrevious.TabIndex = 7;
            this.pbPrevious.TabStop = false;
            // 
            // pbProjectImage
            // 
            this.pbProjectImage.BackColor = System.Drawing.Color.Transparent;
            this.pbProjectImage.Location = new System.Drawing.Point(86, 103);
            this.pbProjectImage.Name = "pbProjectImage";
            this.pbProjectImage.Size = new System.Drawing.Size(256, 310);
            this.pbProjectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProjectImage.TabIndex = 1;
            this.pbProjectImage.TabStop = false;
            // 
            // ProjectDetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbProjectDetail);
            this.Name = "ProjectDetailControl";
            this.Size = new System.Drawing.Size(1024, 560);
            ((System.ComponentModel.ISupportInitialize)(this.pbProjectDetail)).EndInit();
            this.pbProjectDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHomePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProjectImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TransparentPictureBox pbProjectDetail;
        private TransparentPictureBox pbProjectImage;
        private TransparentPictureBox pbHomePage;
        private TransparentPictureBox pbPrevious;
    }
}
