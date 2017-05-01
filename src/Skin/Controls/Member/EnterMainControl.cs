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
    /// 会员进入
    /// </summary>
    public partial class EnterMainControl : UserControl
    {
        public EnterMainControl()
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
            foreach (var eachControl in this.pbEnterMain.Controls)
            {
                var pb = eachControl as TransparentPictureBox;
                if (pb != null)
                {
                    pb.RegisterEvent();
                }
            }

            this.pbPrevious.MouseClick += GoHomePage;
            this.pbHomePage.MouseClick += GoHomePage;
            this.pbCustomer.MouseClick += PbCustomer_MouseClick;
            this.pbMember.MouseClick += PbMember_MouseClick;
        }

        /// <summary>
        /// 会员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbMember_MouseClick(object sender, MouseEventArgs e)
        {
            // 如果已经注册则进入登录页面,否则进入注册页面

            if (ApplicationConfiguration.IsRegisted)
            {
                MainForm.Instance.SetCurrentContentPanel(typeof(MemberLoginControl), false);

                var newControl = MainForm.Instance.CurrentControl as MemberLoginControl;
                newControl.ParentControl = this;
            }
            else
            {
                MainForm.Instance.SetCurrentContentPanel(typeof(MemberRegistControl), false);

                var newControl = MainForm.Instance.CurrentControl as MemberRegistControl;
                newControl.ParentControl = this;
            }
        }

        /// <summary>
        /// 顾客
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbCustomer_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void GoHomePage(object sender, MouseEventArgs e)
        {
            MainForm.Instance.SetCurrentContentPanel(typeof(HomePageControl));
        }
    }
}
