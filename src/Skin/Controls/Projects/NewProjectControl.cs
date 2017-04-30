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

            // 今天是否化妆
            this.cboxIsTodayMakeupYes.CheckedChanged += CboxIsTodayMakeupYes_CheckedChanged;
            this.cboxIsTodayMakeupNo.CheckedChanged += CboxIsTodayMakeupNo_CheckedChanged;

            // 年龄
            this.cboxLessThan20.CheckedChanged += CboxLessThan20_CheckedChanged;
            this.cboxBetween20And29.CheckedChanged += CboxBetween20And29_CheckedChanged;
            this.cboxBetween30And39.CheckedChanged += CboxBetween30And39_CheckedChanged;
            this.cboxBetween40And49.CheckedChanged += CboxBetween40And49_CheckedChanged;
            this.cboxBetween50And59.CheckedChanged += CboxBetween50And59_CheckedChanged;
            this.cboxGreaterThan59.CheckedChanged += CboxGreaterThan59_CheckedChanged;

            // 性别
            this.cboxSexTypeMan.CheckedChanged += CboxSexTypeMan_CheckedChanged;
            this.cboxSexTypeWoman.CheckedChanged += CboxSexWoman_CheckedChanged;
        }

        #region 今天是否化妆

        private void CboxIsTodayMakeupYes_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cboxIsTodayMakeupYes.Checked)
            {
                if (this.cboxIsTodayMakeupNo.Checked)
                {
                    this.cboxIsTodayMakeupNo.Checked = false;
                }
            }
        }

        private void CboxIsTodayMakeupNo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cboxIsTodayMakeupNo.Checked)
            {
                if (this.cboxIsTodayMakeupYes.Checked)
                {
                    this.cboxIsTodayMakeupYes.Checked = false;
                }
            }
        }

        #endregion

        #region 年龄

        private void CboxGreaterThan59_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cboxGreaterThan59.Checked)
            {
                this.cboxLessThan20.Checked = false;
                this.cboxBetween20And29.Checked = false;
                this.cboxBetween30And39.Checked = false;
                this.cboxBetween40And49.Checked = false;
                this.cboxBetween50And59.Checked = false;
            }
        }

        private void CboxBetween50And59_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cboxBetween50And59.Checked)
            {
                this.cboxLessThan20.Checked = false;
                this.cboxBetween20And29.Checked = false;
                this.cboxBetween30And39.Checked = false;
                this.cboxBetween40And49.Checked = false;
                this.cboxGreaterThan59.Checked = false;
            }
        }

        private void CboxBetween40And49_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cboxBetween40And49.Checked)
            {
                this.cboxLessThan20.Checked = false;
                this.cboxBetween20And29.Checked = false;
                this.cboxBetween30And39.Checked = false;
                this.cboxBetween50And59.Checked = false;
                this.cboxGreaterThan59.Checked = false;
            }
        }

        private void CboxBetween30And39_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cboxBetween30And39.Checked)
            {
                this.cboxLessThan20.Checked = false;
                this.cboxBetween20And29.Checked = false;
                this.cboxBetween40And49.Checked = false;
                this.cboxBetween50And59.Checked = false;
                this.cboxGreaterThan59.Checked = false;
            }
        }

        private void CboxBetween20And29_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cboxBetween20And29.Checked)
            {
                this.cboxLessThan20.Checked = false;
                this.cboxBetween30And39.Checked = false;
                this.cboxBetween40And49.Checked = false;
                this.cboxBetween50And59.Checked = false;
                this.cboxGreaterThan59.Checked = false;
            }
        }

        private void CboxLessThan20_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cboxLessThan20.Checked)
            {
                this.cboxBetween20And29.Checked = false;
                this.cboxBetween30And39.Checked = false;
                this.cboxBetween40And49.Checked = false;
                this.cboxBetween50And59.Checked = false;
                this.cboxGreaterThan59.Checked = false;
            }
        }

        #endregion

        #region 性别

        private void CboxSexWoman_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cboxSexTypeWoman.Checked)
            {
                this.cboxSexTypeMan.Checked = false;
            }
        }

        private void CboxSexTypeMan_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cboxSexTypeMan.Checked)
            {
                this.cboxSexTypeWoman.Checked = false;
            }
        }

        #endregion


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
            newProject.SkinColor = this.CalcProperty("SkinColor");
            newProject.WaterContent = this.CalcProperty("WaterContent");
            newProject.Pore = this.CalcProperty("Pore");
            newProject.Inflammation = this.CalcProperty("Inflammation");
            newProject.Pigment = this.CalcProperty("Pigment");
            newProject.Sensitive = this.CalcProperty("Sensitive");
            newProject.SkinCare = this.CalcProperty("SkinCare");


            // 今天是否化妆
            if (this.cboxIsTodayMakeupYes.Checked)
            {
                newProject.IsTodayMakeup = true;
            }
            else if(this.cboxIsTodayMakeupNo.Checked)
            {
                newProject.IsTodayMakeup = false;
            }

            // 年龄
            if (this.cboxLessThan20.Checked)
            {
                newProject.AgeCategory = AgeCategory.LessThan20;
            }
            else if (this.cboxBetween20And29.Checked)
            {
                newProject.AgeCategory = AgeCategory.Between20And29;
            }
            else if (this.cboxBetween30And39.Checked)
            {
                newProject.AgeCategory = AgeCategory.Between30And39;
            }
            else if (this.cboxBetween40And49.Checked)
            {
                newProject.AgeCategory = AgeCategory.Between40And49;
            }
            else if (this.cboxBetween50And59.Checked)
            {
                newProject.AgeCategory = AgeCategory.Between50And59;
            }
            else if (this.cboxGreaterThan59.Checked)
            {
                newProject.AgeCategory = AgeCategory.GreaterThan59;
            }

            if (this.cboxSexTypeMan.Checked)
            {
                newProject.SexType = SexType.Man;
            }
            else if (this.cboxSexTypeWoman.Checked)
            {
                newProject.SexType = SexType.Women;
            }

            using (SkinDbContext context = new SkinDbContext())
            {
                context.Projects.Add(newProject);
                context.SaveChanges();
            }

                // 重新查询
             MainForm.Instance.SetCurrentContentPanel(this.ParentControl);
            ((ProjectListControl)this.ParentControl).Research();
        }

        private ProjectProperty? CalcProperty(string name)
        {
            ProjectProperty? property = null;

            var cbox = this.GetControlByName("cbox" + name + "A") as CheckBox;
            if(cbox != null)
            {
                if (cbox.Checked)
                {
                    property = ProjectProperty.A;
                }
            }

            cbox = this.GetControlByName("cbox" + name + "B") as CheckBox;
            if (cbox != null)
            {
                if (cbox.Checked)
                {
                    if (property == null)
                    {
                        property = ProjectProperty.B;
                    }
                    else
                    {
                        property = property | ProjectProperty.B;
                    }
                }
            }

            cbox = this.GetControlByName("cbox" + name + "C") as CheckBox;
            if (cbox != null)
            {
                if (cbox.Checked)
                {
                    if (property == null)
                    {
                        property = ProjectProperty.C;
                    }
                    else
                    {
                        property = property | ProjectProperty.C;
                    }
                }
            }

            return property;
        }

        private Control GetControlByName(string name)
        {
            var controls = this.Controls.Find(name, true);
            if (controls.Length == 0)
            {
                return null;
            }

            return controls[0];
        }
    }
}
