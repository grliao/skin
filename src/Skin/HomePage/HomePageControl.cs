using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Skin.Controls;
using Skin.Controls.About;

namespace Skin.HomePage
{
    public partial class HomePageControl : UserControl
    {
        public HomePageControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.RegisterEvent();
        }

        private void RegisterEvent()
        {
            foreach (var eachControl in this.pbHomePage.Controls)
            {
                var pb = eachControl as TransparentPictureBox;
                if (pb != null)
                {
                    pb.RegisterEvent();
                }
            }

            // 退出应用程序
            this.pbClose.MouseClick += CloseApplication;
            this.pbExit.MouseClick += CloseApplication;

            // 关于
            this.pbAbout.MouseClick += PbAbout_MouseClick;
        }

        private void PbAbout_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm.Instance.SetCurrentContentPanel(typeof(AboutControl));
        }

        private void CloseApplication(object sender, MouseEventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
