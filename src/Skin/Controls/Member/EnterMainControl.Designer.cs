namespace Skin.Controls.Projects
{
    partial class EnterMainControl
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
            this.pbEnterMain = new Skin.Controls.TransparentPictureBox();
            this.pbHomePage = new Skin.Controls.TransparentPictureBox();
            this.pbPrevious = new Skin.Controls.TransparentPictureBox();
            this.pbMember = new Skin.Controls.TransparentPictureBox();
            this.pbCustomer = new Skin.Controls.TransparentPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnterMain)).BeginInit();
            this.pbEnterMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProjectList
            // 
            this.pbEnterMain.BackColor = System.Drawing.Color.Transparent;
            this.pbEnterMain.Controls.Add(this.pbHomePage);
            this.pbEnterMain.Controls.Add(this.pbPrevious);
            this.pbEnterMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbEnterMain.Image = global::Skin.Resources.EnterMain;
            this.pbEnterMain.Location = new System.Drawing.Point(0, 0);
            this.pbEnterMain.Name = "pbProjectList";
            this.pbEnterMain.Size = new System.Drawing.Size(1024, 560);
            this.pbEnterMain.TabIndex = 0;
            this.pbEnterMain.TabStop = false;
            this.pbEnterMain.Controls.Add(this.pbCustomer);
            this.pbEnterMain.Controls.Add(this.pbMember);
            // 
            // pbHomePage
            // 
            this.pbHomePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHomePage.BackColor = System.Drawing.Color.Transparent;
            this.pbHomePage.Image = global::Skin.Resources.GoHomePage;
            this.pbHomePage.Location = new System.Drawing.Point(934, 28);
            this.pbHomePage.Name = "pbHomePage";
            this.pbHomePage.Size = new System.Drawing.Size(51, 50);
            this.pbHomePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHomePage.TabIndex = 6;
            this.pbHomePage.TabStop = false;
            // 
            // pbPrevious
            // 
            this.pbPrevious.BackColor = System.Drawing.Color.Transparent;
            this.pbPrevious.Image = global::Skin.Resources.Previous;
            this.pbPrevious.Location = new System.Drawing.Point(34, 28);
            this.pbPrevious.Name = "pbPrevious";
            this.pbPrevious.Size = new System.Drawing.Size(51, 50);
            this.pbPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrevious.TabIndex = 5;
            this.pbPrevious.TabStop = false;
            // 
            // pbMember
            // 
            this.pbMember.BackColor = System.Drawing.Color.Transparent;
            this.pbMember.Image = global::Skin.Resources.Member;
            this.pbMember.Location = new System.Drawing.Point(760, 190);
            this.pbMember.Name = "pbMember";
            this.pbMember.Size = new System.Drawing.Size(139, 45);
            this.pbMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMember.TabIndex = 1;
            this.pbMember.TabStop = false;
            // 
            // pbCustomer
            // 
            this.pbCustomer.BackColor = System.Drawing.Color.Transparent;
            this.pbCustomer.Image = global::Skin.Resources.Customer;
            this.pbCustomer.Location = new System.Drawing.Point(760, 253);
            this.pbCustomer.Name = "pbCustomer";
            this.pbCustomer.Size = new System.Drawing.Size(139, 45);
            this.pbCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCustomer.TabIndex = 2;
            this.pbCustomer.TabStop = false;
            // 
            // EnterMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.Controls.Add(this.pbEnterMain);
            this.Name = "EnterMainControl";
            this.Size = new System.Drawing.Size(1024, 560);
            ((System.ComponentModel.ISupportInitialize)(this.pbEnterMain)).EndInit();
            this.pbEnterMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHomePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.TransparentPictureBox pbEnterMain;
        private Controls.TransparentPictureBox pbHomePage;
        private Controls.TransparentPictureBox pbPrevious;
        private TransparentPictureBox pbMember;
        private TransparentPictureBox pbCustomer;
    }
}
