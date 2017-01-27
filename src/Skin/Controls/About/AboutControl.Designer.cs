namespace Skin.Controls.About
{
    partial class AboutControl
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
            this.pbAbout = new Skin.Controls.TransparentPictureBox();
            this.pbFounder = new Skin.Controls.TransparentPictureBox();
            this.pbCompanyVedio = new Skin.Controls.TransparentPictureBox();
            this.pbSenseOfWorth = new Skin.Controls.TransparentPictureBox();
            this.pbNext = new Skin.Controls.TransparentPictureBox();
            this.pbHomePage = new Skin.Controls.TransparentPictureBox();
            this.pbPrevious = new Skin.Controls.TransparentPictureBox();
            this.ctrlMediaPlayer = new Skin.Controls.About.MediaPlayerControl();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).BeginInit();
            this.pbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFounder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyVedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSenseOfWorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAbout
            // 
            this.pbAbout.BackColor = System.Drawing.Color.Transparent;
            this.pbAbout.Controls.Add(this.pbFounder);
            this.pbAbout.Controls.Add(this.pbCompanyVedio);
            this.pbAbout.Controls.Add(this.pbSenseOfWorth);
            this.pbAbout.Controls.Add(this.pbNext);
            this.pbAbout.Controls.Add(this.pbHomePage);
            this.pbAbout.Controls.Add(this.pbPrevious);
            this.pbAbout.Controls.Add(this.ctrlMediaPlayer);
            this.pbAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAbout.Image = global::Skin.Resources.AboutMe;
            this.pbAbout.Location = new System.Drawing.Point(0, 0);
            this.pbAbout.Name = "pbAbout";
            this.pbAbout.Size = new System.Drawing.Size(1024, 560);
            this.pbAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAbout.TabIndex = 0;
            this.pbAbout.TabStop = false;
            // 
            // pbFounder
            // 
            this.pbFounder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbFounder.BackColor = System.Drawing.Color.Transparent;
            this.pbFounder.Image = global::Skin.Resources.Founder;
            this.pbFounder.Location = new System.Drawing.Point(757, 264);
            this.pbFounder.Name = "pbFounder";
            this.pbFounder.Size = new System.Drawing.Size(123, 32);
            this.pbFounder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFounder.TabIndex = 6;
            this.pbFounder.TabStop = false;
            // 
            // pbCompanyVedio
            // 
            this.pbCompanyVedio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbCompanyVedio.BackColor = System.Drawing.Color.Transparent;
            this.pbCompanyVedio.Image = global::Skin.Resources.CompanyVedio;
            this.pbCompanyVedio.Location = new System.Drawing.Point(757, 216);
            this.pbCompanyVedio.Name = "pbCompanyVedio";
            this.pbCompanyVedio.Size = new System.Drawing.Size(123, 32);
            this.pbCompanyVedio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCompanyVedio.TabIndex = 5;
            this.pbCompanyVedio.TabStop = false;
            // 
            // pbSenseOfWorth
            // 
            this.pbSenseOfWorth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbSenseOfWorth.BackColor = System.Drawing.Color.Transparent;
            this.pbSenseOfWorth.Image = global::Skin.Resources.SenseOf_Worth;
            this.pbSenseOfWorth.Location = new System.Drawing.Point(757, 166);
            this.pbSenseOfWorth.Name = "pbSenseOfWorth";
            this.pbSenseOfWorth.Size = new System.Drawing.Size(123, 32);
            this.pbSenseOfWorth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSenseOfWorth.TabIndex = 4;
            this.pbSenseOfWorth.TabStop = false;
            // 
            // pbNext
            // 
            this.pbNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbNext.BackColor = System.Drawing.Color.Transparent;
            this.pbNext.Image = global::Skin.Resources.Next;
            this.pbNext.Location = new System.Drawing.Point(814, 490);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(155, 30);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNext.TabIndex = 3;
            this.pbNext.TabStop = false;
            // 
            // pbHomePage
            // 
            this.pbHomePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHomePage.BackColor = System.Drawing.Color.Transparent;
            this.pbHomePage.Image = global::Skin.Resources.GoHomePage;
            this.pbHomePage.Location = new System.Drawing.Point(934, 20);
            this.pbHomePage.Name = "pbHomePage";
            this.pbHomePage.Size = new System.Drawing.Size(51, 50);
            this.pbHomePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHomePage.TabIndex = 2;
            this.pbHomePage.TabStop = false;
            // 
            // pbPrevious
            // 
            this.pbPrevious.BackColor = System.Drawing.Color.Transparent;
            this.pbPrevious.Image = global::Skin.Resources.Previous;
            this.pbPrevious.Location = new System.Drawing.Point(34, 20);
            this.pbPrevious.Name = "pbPrevious";
            this.pbPrevious.Size = new System.Drawing.Size(51, 50);
            this.pbPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrevious.TabIndex = 1;
            this.pbPrevious.TabStop = false;
            // 
            // ctrlMediaPlayer
            // 
            this.ctrlMediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlMediaPlayer.Location = new System.Drawing.Point(120, 86);
            this.ctrlMediaPlayer.Name = "ctrlMediaPlayer";
            this.ctrlMediaPlayer.Size = new System.Drawing.Size(615, 315);
            this.ctrlMediaPlayer.TabIndex = 7;
            this.ctrlMediaPlayer.Visible = false;
            // 
            // AboutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pbAbout);
            this.Name = "AboutControl";
            this.Size = new System.Drawing.Size(1024, 560);
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).EndInit();
            this.pbAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFounder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyVedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSenseOfWorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TransparentPictureBox pbAbout;
        private TransparentPictureBox pbPrevious;
        private TransparentPictureBox pbHomePage;
        private TransparentPictureBox pbNext;
        private TransparentPictureBox pbSenseOfWorth;
        private TransparentPictureBox pbCompanyVedio;
        private TransparentPictureBox pbFounder;
        private MediaPlayerControl ctrlMediaPlayer;
    }
}
