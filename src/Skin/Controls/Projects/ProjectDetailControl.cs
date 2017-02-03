using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skin.HomePage;
using Skin.Models;
using Skin.Utils;

namespace Skin.Controls.Projects
{
    public partial class ProjectDetailControl : UserControl
    {
        public ProjectDetailControl()
        {
            InitializeComponent();
        }

        public Project CurrentProject
        {
            set
            {
                if (value.ImageData != null && value.ImageData.Length > 0)
                {
                    this.pbProjectImage.Image = ImageHelper.BytesToImage(value.ImageData);
                }
            }
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
            foreach (var eachControl in this.pbProjectDetail.Controls)
            {
                var pb = eachControl as TransparentPictureBox;
                if (pb != null)
                {
                    pb.RegisterEvent();
                }
            }

            this.pbPrevious.MouseClick += GoPrevious;
            this.pbHomePage.MouseClick += GoHomePage;
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
