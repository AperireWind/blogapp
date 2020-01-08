using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogWebApp.Models.Tables;
using BlogWebApp.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors("cors")]
    public class ArticlesController : ControllerBase
    {
        private readonly ArticlesService _articlesService;
        public ArticlesController(ArticlesService articlesService)
        {
            _articlesService = articlesService;
        }
        /// <summary>
        /// 获取所有文章
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<Article>> GetAllArticles() =>
            _articlesService.GetAllArticles();

        /// <summary>
        /// 根据用户ID获取该用户文章
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{userId}")]
        public ActionResult<List<Article>> GetArticle(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                return NotFound();
            }
            return _articlesService.GetArticle(userId);
        }
        /// <summary>
        /// 新增/修改文章
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<bool> PostArticle(Article article)
        {
            if (string.IsNullOrEmpty(article.Article_Id))
            {
                return _articlesService.CreateArticle(article);
            }
            else
            {
                return _articlesService.UpdateArticle(article);
            }
        }
        /// <summary>
        /// 删除文章
        /// </summary>
        /// <param name="articleId"></param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult<bool> DeleteArticle(string articleId)
        {
            if (string.IsNullOrEmpty(articleId))
            {
                return NotFound();
            }
            _articlesService.DeleteArticle(articleId);
            return true;
        }
    }
}