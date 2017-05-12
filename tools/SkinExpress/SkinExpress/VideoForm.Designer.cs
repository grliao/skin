
using VFWTest.Controls;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.palTable = new System.Windows.Forms.TableLayoutPanel();
            this.videoPalyerA = new VFWTest.Controls.VideoPictureBox();
            this.videoPalyerB = new VFWTest.Controls.VideoPictureBox();
            this.pbImageA = new VFWTest.Controls.FilePictureBox();
            this.pbImageB = new VFWTest.Controls.FilePictureBox();
            this.btnClose = new VFWTest.Controls.GlassButton();
            this.btnFullScreen = new VFWTest.Controls.GlassButton();
            this.btnReset = new VFWTest.Controls.GlassButton();
            this.btnConnect = new VFWTest.Controls.GlassButton();
            this.panel1.SuspendLayout();
            this.palTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoPalyerA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPalyerB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::VFWTest.Resources.Background;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnFullScreen);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.cboxDevice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 49);
            this.panel1.TabIndex = 0;
            // 
            // cboxDevice
            // 
            this.cboxDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDevice.FormattingEnabled = true;
            this.cboxDevice.Location = new System.Drawing.Point(75, 15);
            this.cboxDevice.Name = "cboxDevice";
            this.cboxDevice.Size = new System.Drawing.Size(190, 20);
            this.cboxDevice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "视频设备:";
            // 
            // palTable
            // 
            this.palTable.ColumnCount = 2;
            this.palTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.palTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.palTable.Controls.Add(this.videoPalyerA, 0, 0);
            this.palTable.Controls.Add(this.videoPalyerB, 0, 1);
            this.palTable.Controls.Add(this.pbImageA, 1, 0);
            this.palTable.Controls.Add(this.pbImageB, 1, 1);
            this.palTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palTable.Location = new System.Drawing.Point(0, 49);
            this.palTable.Name = "palTable";
            this.palTable.RowCount = 2;
            this.palTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.palTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.palTable.Size = new System.Drawing.Size(810, 454);
            this.palTable.TabIndex = 1;
            // 
            // videoPalyerA
            // 
            this.videoPalyerA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPalyerA.Location = new System.Drawing.Point(3, 3);
            this.videoPalyerA.Name = "videoPalyerA";
            this.videoPalyerA.Size = new System.Drawing.Size(399, 221);
            this.videoPalyerA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.videoPalyerA.TabIndex = 0;
            this.videoPalyerA.TabStop = false;
            // 
            // videoPalyerB
            // 
            this.videoPalyerB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPalyerB.Location = new System.Drawing.Point(3, 230);
            this.videoPalyerB.Name = "videoPalyerB";
            this.videoPalyerB.Size = new System.Drawing.Size(399, 221);
            this.videoPalyerB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.videoPalyerB.TabIndex = 0;
            this.videoPalyerB.TabStop = false;
            // 
            // pbImageA
            // 
            this.pbImageA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImageA.Image = ((System.Drawing.Image)(resources.GetObject("pbImageA.Image")));
            this.pbImageA.Location = new System.Drawing.Point(408, 3);
            this.pbImageA.Name = "pbImageA";
            this.pbImageA.Size = new System.Drawing.Size(399, 221);
            this.pbImageA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImageA.TabIndex = 0;
            this.pbImageA.TabStop = false;
            // 
            // pbImageB
            // 
            this.pbImageB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImageB.Image = ((System.Drawing.Image)(resources.GetObject("pbImageB.Image")));
            this.pbImageB.Location = new System.Drawing.Point(408, 230);
            this.pbImageB.Name = "pbImageB";
            this.pbImageB.Size = new System.Drawing.Size(399, 221);
            this.pbImageB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImageB.TabIndex = 1;
            this.pbImageB.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(722, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 27);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullScreen.Location = new System.Drawing.Point(641, 9);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(75, 27);
            this.btnFullScreen.TabIndex = 5;
            this.btnFullScreen.Text = "全屏";
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(556, 9);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 27);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "重置";
            this.btnReset.Click += new System.EventHandler(this.OnReset);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(475, 9);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 27);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "开始连接";
            this.btnConnect.Click += new System.EventHandler(this.Start);
            // 
            // VideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 503);
            this.Controls.Add(this.palTable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VideoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "视频窗口";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.palTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoPalyerA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoPalyerB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VideoPictureBox videoPalyerA;
        private VideoPictureBox videoPalyerB;
        private System.Windows.Forms.Panel panel1;
        private GlassButton btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxDevice;
        private System.Windows.Forms.TableLayoutPanel palTable;
        private FilePictureBox pbImageA;
        private FilePictureBox pbImageB;
        private GlassButton btnReset;
        private GlassButton btnFullScreen;
        private GlassButton btnClose;
    }
}