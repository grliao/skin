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
using Skin.Controls.Projects;

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
            this.pbEnter.MouseClick += PbEnter_MouseClick;
            this.pbAbout.MouseClick += OnCompanyAbout;
            this.pbNewProject.MouseClick += OnNewProject;
        }

        // 进入
        private void PbEnter_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm.Instance.SetCurrentContentPanel(typeof(EnterMainControl));
        }

        // 关于
        private void OnCompanyAbout(object sender, MouseEventArgs e)
        {
            MainForm.Instance.SetCurrentContentPanel(typeof(AboutControl));
        }

        // 退出
        private void CloseApplication(object sender, MouseEventArgs e)
        {
            this.ParentForm.Close();
        }

        private void OnNewProject(object sender, MouseEventArgs e)
        {
            MainForm.Instance.SetCurrentContentPanel(typeof(ProjectListControl));
        }
    }
}
