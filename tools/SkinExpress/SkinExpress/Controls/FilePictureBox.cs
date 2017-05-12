
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace VFWTest.Controls
{
    /// <summary>
    /// 文件图片控件
    /// </summary>
    public class FilePictureBox:PictureBox
    {
        public FilePictureBox()
        {
            this.MouseEnter += OnMouseEnter;
            this.MouseLeave += OnMouseLeave;
            this.Click += FilePictureBox_Click;

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
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "PNG(*.png)|*.png|JPEG(*.jpg,*.jpeg)|*.jpg,*.jpeg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // 拷贝文件拷贝到当前目录下
                string dir = Path.Combine(Application.StartupPath, "Images");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                string dest = Path.Combine(dir, Guid.NewGuid().ToString() + new FileInfo(dialog.FileName).Extension );
                File.Copy(dialog.FileName, dest);

                // 修改配置文件
                VFWTest.Configuration.AppConfiguration.SaveImagePath(this.Name, dest);

                this.Load(dest);
            }
        }
    }
}
