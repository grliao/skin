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
        private int _count = 0;

        public AboutControl()
        {
            InitializeComponent();

            //this.RegistResizeControls(this.pbCompanyVedio, this.pbFounder, this.pbSenseOfWorth,this.ctrlMediaPlayer);
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

            this.pbNext.MouseClick += OnNext;
        }

        private void GoSenseOfWorth(object sender, MouseEventArgs e)
        {
            this.pbAbout.Image = Resources.About_SenseOfWorth;
            this.ctrlMediaPlayer.Visible = false;
            this.ctrlMediaPlayer.Stop();

            if(e != null)
            {
                this._count = 1;
            }
        }

        private void GoFounder(object sender, MouseEventArgs e)
        {
            this.pbAbout.Image = Resources.About_Founder;
            this.ctrlMediaPlayer.Visible = false;
            this.ctrlMediaPlayer.Stop();

            if (e != null)
            {
                this._count = 3;
            }
        }

        private void GoCompanyVedio(object sender, MouseEventArgs e)
        {
            this.pbAbout.Image = Resources.About_CompanyVedio;
            this.ctrlMediaPlayer.Visible = true;
            this.ctrlMediaPlayer.Play();

            if (e != null)
            {
                this._count = 2;
            }
        }

        private void GoHomePage(object sender, MouseEventArgs e)
        {
            MainForm.Instance.SetCurrentContentPanel(typeof(HomePageControl));
        }

        private void OnNext(object sender, MouseEventArgs e)
        {
            if (this._count % 3 == 0)
            {
                this.GoSenseOfWorth(this, null);
            }
            else if (this._count % 3 == 1)
            {
                this.GoCompanyVedio(this, null);
            }
            else if (this._count % 3 == 2)
            {
                this.GoFounder(this, null);
            }

            this._count += 1;
        }
    }
}
