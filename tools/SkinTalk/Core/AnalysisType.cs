using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace SkinTalk.Core
{
    /// <summary>
    /// 分析类型
    /// </summary>
    public enum AnalysisType
    {
        Lens = 0,

        /// <summary>
        /// 肤色
        /// </summary>
        Human,

        /// <summary>
        /// 炎症
        /// </summary>
        Inflammation,

        /// <summary>
        /// 水分
        /// </summary>
        Mositure,
        
        /// <summary>
        /// 油脂
        /// </summary>
        Oil,

        /// <summary>
        /// 色素
        /// </summary>
        Pigment,

        /// <summary>
        /// 毛孔
        /// </summary>
        Pores,

        /// <summary>
        /// 纹理
        /// </summary>
        Texture,
    }
}
