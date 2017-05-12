
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace VFWTest.Controls
{
    /// <summary>
    /// 文件图片控件
    /// </summary>
    public class VideoPictureBox : PictureBox
    {
        private int _currentCount = 0;

        public VideoPictureBox()
        {
            this.MouseEnter += OnMouseEnter;
            this.MouseLeave += OnMouseLeave;
            this.Click += FilePictureBox_Click;

            this.Image = Resources.Camera;
            this.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// 点击换图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilePictureBox_Click(object sender, EventArgs e)
        {
            this._currentCount++;
        }

        /// <summary>
        /// 重设计数
        /// </summary>
        public void ResetCount()
        {
            this._currentCount = 0;

            this.Image = Resources.Camera;
        }

        /// <summary>
        /// 设置图片
        /// </summary>
        /// <param name="image"></param>
        public void SetImage(Bitmap image)
        {
            if (this._currentCount % 2 == 0)
            {
                if (this.Image != null)
                {
                    this.Image.Dispose();
                }

                this.Image = (Bitmap)image.Clone();
            }
        }
    }
}
