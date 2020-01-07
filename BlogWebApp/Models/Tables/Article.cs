using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApp.Models.Tables
{
    /// <summary>
    /// 文章表
    /// </summary>
    public class Article
    {
        /// <summary>
        /// 
        /// </summary>
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        /// <summary>
        /// 文章id
        /// </summary>
        public string Article_Id { get; set; }
        /// <summary>
        /// 文章名称
        /// </summary>
        public string Article_Name { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime Article_Time { get; set; }
        /// <summary>
        /// 发布IP
        /// </summary>
        public string Article_IP { get; set; }
        /// <summary>
        /// 查看人数
        /// </summary>
        public int Article_Click { get; set; }
        /// <summary>
        /// 所属分类
        /// </summary>
        public int Sort_Article_Id { get; set; }
        /// <summary>
        /// 所属用户ID
        /// </summary>
        public string User_Id { get; set; }
        /// <summary>
        /// 栏目ID
        /// </summary>
        public string Type_Id { get; set; }
        /// <summary>
        /// 文章的模式:0为私有，1为公开，2为仅好友查看
        /// </summary>
        public int Article_Type { get; set; }
        /// <summary>
        /// 文章内容
        /// </summary>
        public string Article_Content { get; set; }
        /// <summary>
        /// 是否置顶:0为否，1为是
        /// </summary>
        public int Article_Up { get; set; }
        /// <summary>
        /// 是否博主推荐:0为否，1为是
        /// </summary>
        public int Article_Support { get; set; }
    }
}
