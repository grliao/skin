using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skin.Models
{
    [Table("Member")]
    public class Member
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// 店铺编号
        /// </summary>
        public string ShopId
        {
            get;
            set;
        }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string Password
        {
            get;
            set;
        }

        /// <summary>
        /// 开卡日期 
        /// </summary>
        public string CreateDate
        {
            get;
            set;
        }

        /// <summary>
        /// 等级
        /// </summary>
        public string Level
        {
            get;
            set;
        }

        /// <summary>
        /// 状态
        /// </summary>
        public string Status
        {
            get;
            set;
        }

        /// <summary>
        /// 会员编号
        /// </summary>
        public string Number
        {
            get;
            set;
        }

        /// <summary>
        /// 性别
        /// </summary>
        public SexType SexType
        {
            get;
            set;
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// email
        /// </summary>
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// 生日
        /// </summary>
        public DateTime BirthDate
        {
            get;
            set;
        }

        /// <summary>
        /// 职业
        /// </summary>
        public string Occupation
        {
            get;
            set;
        }

        /// <summary>
        /// 电话
        /// </summary>
        public string Phone
        {
            get;
            set;
        }

        /// <summary>
        /// qq
        /// </summary>
        public string QQ
        {
            get;
            set;
        }

        /// <summary>
        /// 顾问
        /// </summary>
        public string Adviser
        {
            get;
            set;
        }

        /// <summary>
        /// 省
        /// </summary>
        public string Province
        {
            get;
            set;
        }

        /// <summary>
        /// 市
        /// </summary>
        public string City
        {
            get;
            set;
        }

        /// <summary>
        /// 县
        /// </summary>
        public string County
        {
            get;
            set;
        }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address
        {
            get;
            set;
        }

        /// <summary>
        /// 邮编
        /// </summary>
        public string Code
        {
            get;
            set;
        }
    }
}
