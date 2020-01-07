using BlogWebApp.IServices;
using BlogWebApp.Models;
using BlogWebApp.Models.Tables;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace BlogWebApp.Services
{
    public class ArticlesService : CommonService, IArticlesService
    {
        private readonly IMongoCollection<Article> _Articles;
        public ArticlesService(IDatabaseSettings settings) : base(settings)
        {
            _Articles = _database.GetCollection<Article>(settings.ArticleCollectionName);
        }
        /// <summary>
        /// 获取所有文章
        /// </summary>
        /// <returns></returns>
        public List<Article> GetAllArticles()
        {
            return _Articles.Find(u => true).ToList();
        }
        /// <summary>
        /// 根据用户ID获取该用户文章
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Article> GetArticle(string userId)
        {
            return _Articles.Find(u => u.User_Id == userId).ToList();
        }

        /// <summary>
        /// 新增文章
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        public bool CreateArticle(Article article)
        {
            _Articles.InsertOne(article);
            return true;
        }

        /// <summary>
        /// 修改文章
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        public bool UpdateArticle(Article article)
        {
            _Articles.ReplaceOne(u => u.Article_Id == article.Article_Id, article);
            return true;
        }

        /// <summary>
        /// 根据ID删除文章
        /// </summary>
        /// <param name="articleId"></param>
        /// <returns></returns>
        public bool DeleteArticle(string articleId)
        {
            _Articles.DeleteOne(u => u.Article_Id == articleId);
            return true;
        }
    }
}
