using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Skin.Controls;
using Skin.HomePage;
using Skin.EF;
using Skin.Models;
using Skin.Utils;

namespace Skin.Controls.Projects
{
    /// <summary>
    /// 会员登录
    /// </summary>
    public partial class MemberLoginControl : UserControl
    {
        private StringBuilder _passwords = new StringBuilder();

        public MemberLoginControl()
        {
            InitializeComponent();
        }

        public UserControl ParentControl
        {
            get;
            set;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.RegisterEvent();
        }

        private void RegisterEvent()
        {
            foreach (var eachControl in this.pbMemberLogin.Controls)
            {
                var pb = eachControl as TransparentPictureBox;
                if (pb != null)
                {
                    pb.RegisterEvent();
                }
            }

            foreach (var eachControl in this.pbMemberLogin.Controls)
            {
                var pb = eachControl as TransparentPictureBox;
                if (pb != null && pb.Name.Contains("Number_"))
                {
                    pb.Click += Pb_Click;
                }
            }

            this.pbLogin.Click += PbLogin_Click;

            this.pbPrevious.MouseClick += GoPrevious;
            this.pbHomePage.MouseClick += GoHomePage;
        }

        // 登录
        private void PbLogin_Click(object sender, EventArgs e)
        {
            var result = ApplicationConfiguration.Login(this._passwords.ToString());
            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Error,"登录");
                return;
            }
        }

        // 数字点击按钮
        private void Pb_Click(object sender, EventArgs e)
        {
            this._passwords.Append(((Control)(sender)).Tag);
        }

        private void GoHomePage(object sender, MouseEventArgs e)
        {
            MainForm.Instance.SetCurrentContentPanel(typeof(HomePageControl));
        }

        private void GoPrevious(object sender, MouseEventArgs e)
        {
            MainForm.Instance.SetCurrentContentPanel(this.ParentControl);
        }
    }
}
