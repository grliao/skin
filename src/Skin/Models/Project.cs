using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Skin.Models
{
    /// <summary>
    /// 项目 
    /// </summary>
    [Table("Project")]
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Sequence
        {
            get;
            set;
        }

        public string Code
        {
            get;
            set;
        }

        public string BriefIntroduction
        {
            get;
            set;
        }

        public byte[] ImageData
        {
            get;
            set;
        }

        /// <summary>
        /// 肤色
        /// </summary>
        public ProjectProperty SkinColour
        {
            get;
            set;
        }

        /// <summary>
        /// 水分
        /// </summary>
        public ProjectProperty WaterContent
        {
            get;
            set;
        }

        /// <summary>
        /// 毛孔
        /// </summary>
       
        public ProjectProperty Pore
        {
            get;
            set;
        }

        /// <summary>
        /// 炎症
        /// </summary>
        public ProjectProperty Inflammation
        {
            get;
            set;
        }

        /// <summary>
        /// 色素
        /// </summary>
        public ProjectProperty Pigment
        {
            get;
            set;
        }

        /// <summary>
        /// 敏感
        /// </summary>
        public ProjectProperty Sensitive
        {
            get;
            set;
        }

        /// <summary>
        /// 是否化妆
        /// </summary>
        public bool IsTodayMakeup
        {
            get;
            set;
        }

        /// <summary>
        /// 肤色关注
        /// </summary>
        public ProjectProperty SkinCare
        {
            get;
            set;
        }

        /// <summary>
        /// 年龄分类
        /// </summary>
        public AgeCategory AgeCategory
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
    }

    public enum ProjectProperty
    {
        A,
        B,
        C,
    }

    public enum AgeCategory
    {
        LessThan20,
        Between20And29,
        Between30And39,
        Between40And49,
        Between50And59,
        GreaterThan59
    }

    public enum SexType
    {
        Man,
        Women,
    }
}
