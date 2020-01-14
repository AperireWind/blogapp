using BlogWebApi.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApi.IServices
{
    interface IUserRulesService
    {
        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        List<Users> GetAllUsers();
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPWD"></param>
        /// <returns></returns>
        bool Login(string userName, string userPWD);
    }
}
