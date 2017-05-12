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
using System.Text.RegularExpressions;
using Skin.Utils;

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
            
            this.pbSave.MouseClick += OnSave;
        }

        /// <summary>
        /// 会员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSave(object sender, MouseEventArgs e)
        {
            string error = string.Empty;
            if (!this.IsValid(ref error))
            {
                MessageBox.Show(error,"注册会员");
                return;
            }

            Member member = new Member();
            member.ShopId = this.txtShopId.Text.Trim();
            member.Password = MD5Util.GetMd5String(this.txtPassword.Text.Trim());
            member.CreateDate = this.txtCreateDate.Text.Trim();
            member.Level = this.txtLevel.Text.Trim();
            member.Status = this.txtStatus.Text.Trim();
            member.Number = this.txtNumber.Text.Trim();

            if (rbSexTypeMan.Checked)
            {
                member.SexType = SexType.Man;
            }
            else
            {
                member.SexType = SexType.Women;
            }

            member.Name = this.txtName.Text.Trim();
            member.Email = this.txtEmail.Text.Trim();
            member.BirthDate = new DateTime(int.Parse(this.txtBirthDateYear.Text), int.Parse(this.txtBirthDateMonth.Text), int.Parse(this.txtBirthDateDay.Text));

            member.Occupation = this.txtOccupation.Text.Trim();
            member.Phone = this.txtPhone.Text.Trim();
            member.QQ = this.txtQQ.Text.Trim();
            member.Adviser = this.txtAdviser.Text.Trim();
            member.Province = this.txtProvince.Text.Trim();
            member.City = this.txtCity.Text.Trim();
            member.County = this.txtCounty.Text.Trim();
            member.Address = this.txtAddress.Text.Trim();
            member.Code = this.txtCode.Text.Trim();

            using (SkinDbContext context = new SkinDbContext())
            {
                context.Members.Add(member);
                context.SaveChanges();
            }

            // 进入
        }

        private bool IsValid(ref string error)
        {
            // 检查输入是否合法
            if (string.IsNullOrWhiteSpace(this.txtShopId.Text))
            {
                error = "店铺编号不允许为空";
                this.txtShopId.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                error = "密码不允许为空";
                this.txtPassword.Focus();
                return false;
            }

            Regex reg = new Regex("^[0-9]*[1-9][0-9]*$");
            if (!reg.IsMatch(this.txtPassword.Text))
            {
                error = "密码只允许输入数字";
                this.txtPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtNumber.Text))
            {
                error = "会员编号不允许为空";
                this.txtNumber.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtName.Text))
            {
                error = "姓名不允许为空";
                this.txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtEmail.Text))
            {
                error = "Email不允许为空";
                this.txtEmail.Focus();
                return false;
            }

            reg = new Regex(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            if (!reg.IsMatch(this.txtEmail.Text))
            {
                error = "Email地址无效";
                this.txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtBirthDateYear.Text))
            {
                error = "年不允许为空";
                this.txtBirthDateYear.Focus();
                return false;
            }

            int birthDate;

            if (!int.TryParse(this.txtBirthDateYear.Text,out birthDate))
            {
                error = "年请输入正整数";
                this.txtBirthDateYear.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtBirthDateMonth.Text))
            {
                error = "月不允许为空";
                this.txtBirthDateMonth.Focus();
                return false;
            }

            if (!int.TryParse(this.txtBirthDateMonth.Text, out birthDate))
            {
                error = "月范围在1~12之间";
                this.txtBirthDateMonth.Focus();
                return false;
            }

            if (!(birthDate >= 1 && birthDate <= 12))
            {
                error = "月范围在1~12之间";
                this.txtBirthDateMonth.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtBirthDateDay.Text))
            {
                error = "日不允许为空";
                this.txtBirthDateDay.Focus();
                return false;
            }

            if (!int.TryParse(this.txtBirthDateDay.Text, out birthDate))
            {
                error = "日范围在1~31之间";
                this.txtBirthDateDay.Focus();
                return false;
            }

            if (!(birthDate >= 1 && birthDate <= 31))
            {
                error = "日范围在1~31之间";
                this.txtBirthDateDay.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.txtPhone.Text))
            {
                error = "联系电话不允许为空";
                this.txtPhone.Focus();
                return false;
            }

            return true;
        }


        private void GoHomePage(object sender, MouseEventArgs e)
        {
            MainForm.Instance.SetCurrentContentPanel(typeof(HomePageControl));
        }
    }
}
