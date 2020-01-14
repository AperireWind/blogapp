using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogWebApi.Models.Tables;
using BlogWebApi.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors("cors")]
    public class UserRulesController : ControllerBase
    {
        private readonly UserRulesService _userRulesService;
        public UserRulesController(UserRulesService userRulesService)
        {
            _userRulesService = userRulesService;
        }

        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<Users>> GetAllUsers() =>
            _userRulesService.GetAllUsers();

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPWD"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<bool> Login(string userName, string userPWD)
        {
            return _userRulesService.Login(userName, userPWD);
        }

        // POST: api/UserRules
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/UserRules/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
