namespace Skin.Controls.About
{
    partial class MediaPlayerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayerControl));
            this.axMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // axMediaPlayer
            // 
            this.axMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMediaPlayer.Enabled = true;
            this.axMediaPlayer.Location = new System.Drawing.Point(0, 0);
            this.axMediaPlayer.Name = "axMediaPlayer";
            this.axMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMediaPlayer.OcxState")));
            this.axMediaPlayer.Size = new System.Drawing.Size(476, 288);
            this.axMediaPlayer.TabIndex = 1;
            // 
            // MediaPlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axMediaPlayer);
            this.Name = "MediaPlayerControl";
            this.Size = new System.Drawing.Size(476, 288);
            ((System.ComponentModel.ISupportInitialize)(this.axMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axMediaPlayer;
    }
}
