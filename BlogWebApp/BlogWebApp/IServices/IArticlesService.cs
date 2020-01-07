using BlogWebApp.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApp.IServices
{
    interface IArticlesService
    {
        /// <summary>
        /// 获取所有文章
        /// </summary>
        /// <returns></returns>
        List<Article> GetAllArticles();
        /// <summary>
        /// 根据用户ID获取该用户文章
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Article> GetArticle(string userId);
        /// <summary>
        /// 新增文章
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        bool CreateArticle(Article article);
        /// <summary>
        /// 修改文章
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        bool UpdateArticle(Article article);
        /// <summary>
        /// 根据ID删除文章
        /// </summary>
        /// <param name="articleId"></param>
        /// <returns></returns>
        bool DeleteArticle(string articleId);
    }
}
