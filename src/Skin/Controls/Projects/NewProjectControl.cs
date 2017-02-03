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
using Skin.EF;

namespace Skin.Controls.Projects
{
    public partial class NewProjectControl : UserControl
    {
        public NewProjectControl()
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
            foreach (var eachControl in this.pbNewProject.Controls)
            {
                var pb = eachControl as TransparentPictureBox;
                if (pb != null)
                {
                    pb.RegisterEvent();
                }
            }

            this.pbPrevious.MouseClick += GoPrevious;
            this.pbHomePage.MouseClick += GoHomePage;
            this.pbImage.MouseClick += OnSetProjectImage;
            this.pbSave.MouseClick += OnSave;
        }


        private void GoHomePage(object sender, MouseEventArgs e)
        {
            MainForm.Instance.SetCurrentContentPanel(typeof(HomePageControl));
        }

        private void GoPrevious(object sender, MouseEventArgs e)
        {
            MainForm.Instance.SetCurrentContentPanel(this.ParentControl);
        }

        private void OnSetProjectImage(object sender, MouseEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "*.jpg|*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.pbImage.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void OnSave(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtName.Text.Trim()))
            {
                MessageBox.Show("项目名称不允许为空", "保存项目", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtSequence.Text.Trim()))
            {
                MessageBox.Show("项目系列名称不允许为空", "保存项目", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtSequence.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtCode.Text.Trim()))
            {
                MessageBox.Show("项目代码不允许为空", "保存项目", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtCode.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtBriefIntroduction.Text.Trim()))
            {
                MessageBox.Show("项目简介不允许为空", "保存项目", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtBriefIntroduction.Focus();
                return;
            }

            if (this.pbImage.Image == null)
            {
                MessageBox.Show("项目图片不允许为空", "保存项目", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.pbImage.Focus();
                return;
            }

            Project newProject = new Project();
            newProject.Name = this.txtName.Text.Trim();
            newProject.Sequence = this.txtSequence.Text.Trim();
            newProject.Code = this.txtCode.Text.Trim();
            newProject.BriefIntroduction = this.txtBriefIntroduction.Text.Trim();
            newProject.ImageData = ImageHelper.ImageToBytes(this.pbImage.Image);

            using (SkinDbContext context = new SkinDbContext())
            {
                context.Projects.Add(newProject);
                context.SaveChanges();
            }

                // 重新查询
             MainForm.Instance.SetCurrentContentPanel(this.ParentControl);
            ((ProjectListControl)this.ParentControl).Research();
        }
    }
}
