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

namespace Skin.Controls.Projects
{
    /// <summary>
    /// 会员注册
    /// </summary>
    public partial class MemberRegistControl : UserControl
    {
        public MemberRegistControl()
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
            foreach (var eachControl in this.pbMemberRegist.Controls)
            {
                var pb = eachControl as TransparentPictureBox;
                if (pb != null)
                {
                    pb.RegisterEvent();
                }
            }

            this.pbPrevious.MouseClick += GoHomePage;
            this.pbHomePage.MouseClick += GoHomePage;
            
            this.pbSave.MouseClick += PbMember_MouseClick;
        }

        /// <summary>
        /// 会员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbMember_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm.Instance.SetCurrentContentPanel(typeof(MemberLoginControl),false);

            var newControl = MainForm.Instance.CurrentControl as MemberLoginControl;
            newControl.ParentControl = this;
        }


        private void GoHomePage(object sender, MouseEventArgs e)
        {
            MainForm.Instance.SetCurrentContentPanel(typeof(HomePageControl));
        }
    }
}
