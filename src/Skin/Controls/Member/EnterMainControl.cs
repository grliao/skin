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
        }

        private void GoHomePage(object sender, MouseEventArgs e)
        {
            MainForm.Instance.SetCurrentContentPanel(typeof(HomePageControl));
        }
    }
}
