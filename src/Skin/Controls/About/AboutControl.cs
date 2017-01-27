using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Skin.HomePage;

namespace Skin.Controls.About
{
    /// <summary>
    /// 关于我们
    /// </summary>
    public partial class AboutControl : UserControl
    {
        public AboutControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.RegisterEvent();
        }

        public void RegisterEvent()
        {
            foreach (var eachControl in this.pbAbout.Controls)
            {
                var pb = eachControl as TransparentPictureBox;
                if (pb != null)
                {
                    pb.RegisterEvent();
                }
            }

            this.pbPrevious.MouseClick += GoHomePage;
            this.pbHomePage.MouseClick += GoHomePage;

            this.pbCompanyVedio.MouseClick += GoCompanyVedio;
            this.pbFounder.MouseClick += GoFounder;
            this.pbSenseOfWorth.MouseClick += GoSenseOfWorth;
        }


        private void GoSenseOfWorth(object sender, MouseEventArgs e)
        {
            this.pbAbout.Image = Resources.About_SenseOfWorth;
            this.ctrlMediaPlayer.Visible = false;
            this.ctrlMediaPlayer.Stop();
        }

        private void GoFounder(object sender, MouseEventArgs e)
        {
            this.pbAbout.Image = Resources.About_Founder;
            this.ctrlMediaPlayer.Visible = false;
            this.ctrlMediaPlayer.Stop();
        }

        private void GoCompanyVedio(object sender, MouseEventArgs e)
        {
            this.pbAbout.Image = Resources.About_CompanyVedio;
            this.ctrlMediaPlayer.Visible = true;
            this.ctrlMediaPlayer.Play();
        }

        private void GoHomePage(object sender, MouseEventArgs e)
        {
            MainForm.Instance.SetCurrentContentPanel(typeof(HomePageControl));
        }
    }
}
