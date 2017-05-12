using AForge.Video.DirectShow;
using SkinTalk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFWTest
{
    public partial class VideoForm : Form
    {
        VideoCaptureDevice videoSource;

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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo eachDevice in videoDevices)
                {
                    this.cboxDevice.Items.Add(new FilterInfoItem(eachDevice));
                }

                if (videoDevices.Count > 0)
                {
                    this.cboxDevice.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                this.AppendContext("获取当前视频输入设备失败，详细信息:" + ex.Message);
            }
            
        }

        private void Start(object sender, EventArgs e)
        {
            if (this.CurrentFilterInfo == null)
            {
                this.AppendContext("请选择视频输入设备");
                this.cboxDevice.Focus();
                return;
            }

            if (this.vedioPalyer.IsRunning)
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    this.videoSource.Stop();

                    this.btnConnect.Text = "开始连接";
                }
                catch (Exception ex)
                {
                    this.AppendContext("停止视频输入设备失败,详细信息:" + ex.Message);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
            else
            {
                videoSource = new VideoCaptureDevice(this.CurrentFilterInfo.MonikerString);//连接摄像头。

                if (videoSource.VideoCapabilities == null || videoSource.VideoCapabilities.Length == 0)
                {
                    this.AppendContext("视频输入设备有效参数为空");
                    return;
                }

                videoSource.VideoResolution = videoSource.VideoCapabilities[0];
                vedioPalyer.VideoSource = videoSource;
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    vedioPalyer.Start();
                    this.AppendContext("启动视频输入设成功");
                    this.btnConnect.Text = "停止连接";
                }
                catch (Exception ex)
                {
                    this.AppendContext("启动视频输入设备失败,详细信息:" + ex.Message);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void AppendContext(string message)
        {
            if (this.txtContent.InvokeRequired)
            {
                this.txtContent.Invoke(new Action<string>(this.AppendContext), message);
                return;
            }

            this.txtContent.AppendText(message + Environment.NewLine);
            this.txtContent.SelectionStart = this.txtContent.Text.Length;
        }

        private void StartAnalysis(object sender, EventArgs e)
        {
            if (vedioPalyer.IsRunning)
            {
                var image = (Bitmap)vedioPalyer.GetCurrentVideoFrame().Clone();
                image.Save(@"d:\" + Guid.NewGuid().ToString() + ".bmp", ImageFormat.Bmp);

                Dictionary<string, string> result = new Dictionary<string, string>();

                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    SkinService service = new SkinService();

                    var imageResult = service.ProcessImage(SkinTalk.Core.AnalysisType.Human, null, true, (Bitmap)image.Clone());
                    result.Add("肤色", imageResult.Score.ToString());

                    imageResult = service.ProcessImage(SkinTalk.Core.AnalysisType.Inflammation, null, true, (Bitmap)image.Clone());
                    result.Add("炎症", imageResult.Score.ToString());

                    imageResult = service.ProcessImage(SkinTalk.Core.AnalysisType.Mositure, null, true, (Bitmap)image.Clone());
                    result.Add("水分", imageResult.Score.ToString());

                    imageResult = service.ProcessImage(SkinTalk.Core.AnalysisType.Oil, null, true, (Bitmap)image.Clone());
                    result.Add("油脂", imageResult.Score.ToString());

                    imageResult = service.ProcessImage(SkinTalk.Core.AnalysisType.Pigment, null, true, (Bitmap)image.Clone());
                    result.Add("色素", imageResult.Score.ToString());

                    imageResult = service.ProcessImage(SkinTalk.Core.AnalysisType.Pores, null, true, (Bitmap)image.Clone());
                    result.Add("毛孔", imageResult.Score.ToString());

                    imageResult = service.ProcessImage(SkinTalk.Core.AnalysisType.Texture, null, true, (Bitmap)image.Clone());
                    result.Add("纹理", imageResult.Score.ToString());
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }

                ResultForm resultForm = new ResultForm();
                resultForm.StartPosition = FormStartPosition.CenterParent;
                resultForm.ItemResults = result;
                resultForm.ShowDialog();
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

        protected override void OnClosed(EventArgs e)
        {
            try
            {
                if (vedioPalyer.IsRunning)
                {
                    vedioPalyer.Stop();
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
    }
}
