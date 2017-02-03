namespace Skin.Controls.Projects
{
    partial class NewProjectControl
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSequence = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtBriefIntroduction = new System.Windows.Forms.TextBox();
            this.pbSave = new Skin.Controls.TransparentPictureBox();
            this.pbImage = new Skin.Controls.TransparentPictureBox();
            this.pbHomePage = new Skin.Controls.TransparentPictureBox();
            this.pbPrevious = new Skin.Controls.TransparentPictureBox();
            this.pbNewProject = new Skin.Controls.TransparentPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewProject)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(201, 83);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 27);
            this.txtName.TabIndex = 11;
            // 
            // txtSequence
            // 
            this.txtSequence.Location = new System.Drawing.Point(201, 120);
            this.txtSequence.Multiline = true;
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Size = new System.Drawing.Size(228, 27);
            this.txtSequence.TabIndex = 12;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(201, 156);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(228, 27);
            this.txtCode.TabIndex = 13;
            // 
            // txtBriefIntroduction
            // 
            this.txtBriefIntroduction.Location = new System.Drawing.Point(201, 189);
            this.txtBriefIntroduction.Multiline = true;
            this.txtBriefIntroduction.Name = "txtBriefIntroduction";
            this.txtBriefIntroduction.Size = new System.Drawing.Size(228, 114);
            this.txtBriefIntroduction.TabIndex = 14;
            // 
            // pbSave
            // 
            this.pbSave.BackColor = System.Drawing.Color.Transparent;
            this.pbSave.Image = global::Skin.Resources.SaveProject;
            this.pbSave.Location = new System.Drawing.Point(819, 490);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(134, 33);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSave.TabIndex = 16;
            this.pbSave.TabStop = false;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.Location = new System.Drawing.Point(201, 309);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(106, 115);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 15;
            this.pbImage.TabStop = false;
            // 
            // pbHomePage
            // 
            this.pbHomePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHomePage.BackColor = System.Drawing.Color.Transparent;
            this.pbHomePage.Image = global::Skin.Resources.GoHomePage;
            this.pbHomePage.Location = new System.Drawing.Point(935, 23);
            this.pbHomePage.Name = "pbHomePage";
            this.pbHomePage.Size = new System.Drawing.Size(51, 50);
            this.pbHomePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHomePage.TabIndex = 10;
            this.pbHomePage.TabStop = false;
            // 
            // pbPrevious
            // 
            this.pbPrevious.BackColor = System.Drawing.Color.Transparent;
            this.pbPrevious.Image = global::Skin.Resources.Previous;
            this.pbPrevious.Location = new System.Drawing.Point(35, 23);
            this.pbPrevious.Name = "pbPrevious";
            this.pbPrevious.Size = new System.Drawing.Size(51, 50);
            this.pbPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrevious.TabIndex = 9;
            this.pbPrevious.TabStop = false;
            // 
            // pbNewProject
            // 
            this.pbNewProject.BackColor = System.Drawing.Color.Transparent;
            this.pbNewProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbNewProject.Image = global::Skin.Resources.AddProject;
            this.pbNewProject.Location = new System.Drawing.Point(0, 0);
            this.pbNewProject.Name = "pbNewProject";
            this.pbNewProject.Size = new System.Drawing.Size(1024, 560);
            this.pbNewProject.TabIndex = 0;
            this.pbNewProject.TabStop = false;
            this.pbNewProject.Controls.Add(this.pbSave);
            this.pbNewProject.Controls.Add(this.pbImage);
            this.pbNewProject.Controls.Add(this.txtBriefIntroduction);
            this.pbNewProject.Controls.Add(this.txtCode);
            this.pbNewProject.Controls.Add(this.txtSequence);
            this.pbNewProject.Controls.Add(this.txtName);
            this.pbNewProject.Controls.Add(this.pbHomePage);
            this.pbNewProject.Controls.Add(this.pbPrevious);
            // 
            // NewProjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbNewProject);
            this.Name = "NewProjectControl";
            this.Size = new System.Drawing.Size(1024, 560);
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TransparentPictureBox pbNewProject;
        private TransparentPictureBox pbHomePage;
        private TransparentPictureBox pbPrevious;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSequence;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtBriefIntroduction;
        private TransparentPictureBox pbImage;
        private TransparentPictureBox pbSave;
    }
}
