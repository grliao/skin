using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SkinExpress.Configuration;

namespace SkinExpress
{
    public partial class VideoForm : Form
    {
        private VideoCaptureDevice videoSource;

        public VideoForm()
        {
            InitializeComponent();
        }

        public FilterInfo CurrentFilterInfo
        {
            get
            {
                var item = this.cboxDevice.SelectedItem as FilterInfoItem;
                if (item == null)
                {
                    return null;
                }

                return item.FilterInfo;
            }
        }

        /// <summary>
        /// 获取视频设备
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.palTable.CellPaint += OnCellPaint;

            var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo eachDevice in videoDevices)
            {
                this.cboxDevice.Items.Add(new FilterInfoItem(eachDevice));
            }

            if (videoDevices.Count > 0)
            {
                this.cboxDevice.SelectedIndex = 0;
            }

            // 初始化默认标准图片
            var images = AppConfiguration.Images;
            foreach (var eachImage in images)
            {
                if (File.Exists(eachImage.Value))
                {
                    var controls = this.Controls.Find(eachImage.Name, true);
                    if (controls.Length == 1)
                    {
                        ((System.Windows.Forms.PictureBox)controls[0]).Load(eachImage.Value);
                    }
                }
            }
        }

        // 重写TableLayoutPanel Paint
        private void OnCellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Pen pp = new Pen(Color.Blue);
            e.Graphics.DrawRectangle(pp, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.X + e.CellBounds.Width - 1, e.CellBounds.Y + e.CellBounds.Height - 1);
        }

        /// <summary>
        /// 开始连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start(object sender, EventArgs e)
        {
            if (this.CurrentFilterInfo == null)
            {
                this.cboxDevice.Focus();
                return;
            }

            if (this.videoSource != null && this.videoSource.IsRunning)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    this.videoSource.Stop();

                    this.btnConnect.Text = "开始连接";
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
            else
            {
                videoSource = new VideoCaptureDevice(this.CurrentFilterInfo.MonikerString);//连接摄像头。
                videoSource.NewFrame += OnNewFrame;

                if (videoSource.VideoCapabilities == null || videoSource.VideoCapabilities.Length == 0)
                {
                    return;
                }

                videoSource.VideoResolution = videoSource.VideoCapabilities[0];
                
                try
                {
                    videoSource.Start();
                    this.btnConnect.Text = "停止连接";

                    this.videoPalyerA.ResetCount();
                    this.videoPalyerB.ResetCount();
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        /// <summary>
        /// 接收到图片处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void OnNewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            this.videoPalyerA.SetImage(bitmap);
            this.videoPalyerB.SetImage(bitmap);
        }

        /// <summary>
        /// 重置计数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnReset(object sender, EventArgs e)
        {
            this.videoPalyerA.ResetCount();
            this.videoPalyerB.ResetCount();
        }

        protected override void OnClosed(EventArgs e)
        {
            try
            {
                if (this.videoSource != null && this.videoSource.IsRunning)
                {
                    this.videoSource.Stop();
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                base.OnClosed(e);
            }
        }

        private class FilterInfoItem
        {
            public FilterInfoItem(FilterInfo filterInfo)
            {
                this.FilterInfo = filterInfo;
            }

            public FilterInfo FilterInfo
            {
                get;
                private set;
            }

            public override string ToString()
            {
                return this.FilterInfo.Name;
            }
        }

        /// <summary>
        /// 全屏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                this.btnFullScreen.Text = "取消全屏";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.btnFullScreen.Text = "全屏";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
