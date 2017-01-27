using Skin.Controls;

namespace Skin.HomePage
{
    partial class HomePageControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageControl));
            this.pbExit = new Skin.Controls.TransparentPictureBox();
            this.pbNewProject = new Skin.Controls.TransparentPictureBox();
            this.pbAbout = new Skin.Controls.TransparentPictureBox();
            this.pbEnter = new Skin.Controls.TransparentPictureBox();
            this.pbHomePage = new Skin.Controls.TransparentPictureBox();
            this.pbClose = new Skin.Controls.TransparentPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomePage)).BeginInit();
            this.pbHomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.BackColor = System.Drawing.Color.Transparent;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(658, 355);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(136, 41);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 3;
            this.pbExit.TabStop = false;
            // 
            // pbNewProject
            // 
            this.pbNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbNewProject.BackColor = System.Drawing.Color.Transparent;
            this.pbNewProject.Image = ((System.Drawing.Image)(resources.GetObject("pbNewProject.Image")));
            this.pbNewProject.Location = new System.Drawing.Point(880, 526);
            this.pbNewProject.Name = "pbNewProject";
            this.pbNewProject.Size = new System.Drawing.Size(136, 31);
            this.pbNewProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewProject.TabIndex = 4;
            this.pbNewProject.TabStop = false;
            // 
            // pbAbout
            // 
            this.pbAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAbout.BackColor = System.Drawing.Color.Transparent;
            this.pbAbout.Image = ((System.Drawing.Image)(resources.GetObject("pbAbout.Image")));
            this.pbAbout.Location = new System.Drawing.Point(658, 299);
            this.pbAbout.Name = "pbAbout";
            this.pbAbout.Size = new System.Drawing.Size(136, 41);
            this.pbAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAbout.TabIndex = 2;
            this.pbAbout.TabStop = false;
            // 
            // pbEnter
            // 
            this.pbEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEnter.BackColor = System.Drawing.Color.Transparent;
            this.pbEnter.Image = ((System.Drawing.Image)(resources.GetObject("pbEnter.Image")));
            this.pbEnter.Location = new System.Drawing.Point(658, 240);
            this.pbEnter.Name = "pbEnter";
            this.pbEnter.Size = new System.Drawing.Size(136, 41);
            this.pbEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnter.TabIndex = 1;
            this.pbEnter.TabStop = false;
            // 
            // pbHomePage
            // 
            this.pbHomePage.BackColor = System.Drawing.Color.Transparent;
            this.pbHomePage.Controls.Add(this.pbClose);
            this.pbHomePage.Controls.Add(this.pbExit);
            this.pbHomePage.Controls.Add(this.pbNewProject);
            this.pbHomePage.Controls.Add(this.pbAbout);
            this.pbHomePage.Controls.Add(this.pbEnter);
            this.pbHomePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbHomePage.Image = ((System.Drawing.Image)(resources.GetObject("pbHomePage.Image")));
            this.pbHomePage.Location = new System.Drawing.Point(0, 0);
            this.pbHomePage.Name = "pbHomePage";
            this.pbHomePage.Size = new System.Drawing.Size(1024, 560);
            this.pbHomePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHomePage.TabIndex = 0;
            this.pbHomePage.TabStop = false;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(865, 28);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(61, 61);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            // 
            // HomePageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pbHomePage);
            this.Name = "HomePageControl";
            this.Size = new System.Drawing.Size(1024, 560);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomePage)).EndInit();
            this.pbHomePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TransparentPictureBox pbHomePage;
        private TransparentPictureBox pbClose;
        private TransparentPictureBox pbEnter;
        private TransparentPictureBox pbAbout;
        private TransparentPictureBox pbExit;
        private TransparentPictureBox pbNewProject;
    }
}
