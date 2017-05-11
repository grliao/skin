using Skin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Skin.Utils
{
    public sealed class ApplicationConfiguration
    {
        private static bool _isLogined;
        private static Member _currentUser;


        /// <summary>
        /// 是否登录
        /// </summary>
        public static bool IsLogined
        {
            get
            {
                return _isLogined;
            }
        }

        /// <summary>
        /// 是否注册过
        /// </summary>
        public static bool IsRegisted
        {
            get
            {
                using (var context = new Skin.EF.SkinDbContext())
                {
                    return context.Members.Count() > 0;
                }
            }
        }

        public static Member CurrentUser
        {
            get
            {
                return _currentUser;
            }
        }

        /// <summary>
        ///  登录系统
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static LoginResult Login(string password)
        {
            LoginResult result = new LoginResult();
            password =  MD5Util.GetMd5String(password);

            using (var context = new Skin.EF.SkinDbContext())
            {
                var member = context.Members.FirstOrDefault();
                if (member == null)
                {
                    result.IsSuccess = false;
                    result.Error = "会员不存在,请注册";
                    return result;
                }

                if (member.Password != password)
                {
                    result.IsSuccess = false;
                    result.Error = "密码不对,请重新输入";
                    return result;
                }

                _currentUser = member;
                result.IsSuccess = true;
                _isLogined = true;
            }

            return result;
        }
    }

    public class LoginResult
    {
        public bool IsSuccess
        {
            get;
            set;
        }

        public string Error
        {
            get;
            set;
        }

    }

}
