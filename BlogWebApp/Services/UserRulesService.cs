using BlogWebApi.IServices;
using BlogWebApi.Models.Tables;
using BlogWebApp.IServices;
using BlogWebApp.Models;
using BlogWebApp.Services;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApi.Services
{
    public class UserRulesService : CommonService, IUserRulesService
    {
        private readonly IMongoCollection<Users> _Users;
        public UserRulesService(IDatabaseSettings settings) : base(settings)
        {
            _Users = _database.GetCollection<Users>(settings.UsersCollectionName);
        }
        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        public List<Users> GetAllUsers()
        {
            return _Users.Find(u => true).ToList();
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPWD"></param>
        /// <returns></returns>
        public bool Login(string userName, string userPWD)
        {
            var user = _Users.Find(u => u.User_Name == userName && u.User_PWD == userPWD).ToList();
            return user.Count > 0;
        }
    }
}
