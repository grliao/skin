using AForge.Controls;

namespace VFWTest
{
    partial class VideoForm
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
            this.vedioPalyer = new AForge.Controls.VideoSourcePlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxDevice = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vedioPalyer
            // 
            this.vedioPalyer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vedioPalyer.Location = new System.Drawing.Point(0, 0);
            this.vedioPalyer.Name = "vedioPalyer";
            this.vedioPalyer.Size = new System.Drawing.Size(768, 401);
            this.vedioPalyer.TabIndex = 0;
            this.vedioPalyer.VideoSource = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboxDevice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAnalysis);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 44);
            this.panel1.TabIndex = 0;
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalysis.Location = new System.Drawing.Point(681, 10);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(75, 25);
            this.btnAnalysis.TabIndex = 1;
            this.btnAnalysis.Text = "分析";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(595, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 25);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "开始连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.Start);
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtContent.Location = new System.Drawing.Point(0, 339);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(768, 62);
            this.txtContent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "视频设备:";
            // 
            // cboxDevice
            // 
            this.cboxDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDevice.FormattingEnabled = true;
            this.cboxDevice.Location = new System.Drawing.Point(75, 10);
            this.cboxDevice.Name = "cboxDevice";
            this.cboxDevice.Size = new System.Drawing.Size(190, 21);
            this.cboxDevice.TabIndex = 3;
            // 
            // VideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 401);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vedioPalyer);
            this.Name = "VideoForm";
            this.Text = "视频窗口";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private VideoSourcePlayer vedioPalyer;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxDevice;
    }
}