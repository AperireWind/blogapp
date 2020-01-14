using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApi.Models.Tables
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class Users
    {
        /// <summary>
        /// 
        /// </summary>
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string User_Id { get; set; }
        /// <summary>
        /// 用户组ID
        /// </summary>
        public string Group_Id { get; set; }
        public string User_Name { get; set; }
        public string User_PWD { get; set; }
        public string User_Phone { get; set; }
        public string User_Sex { get; set; }
        public string User_QQ { get; set; }
        public string User_Email { get; set; }
        public string User_Address { get; set; }
        public string User_Mark { get; set; }
        public string User_RankId { get; set; }
        public string User_LastLoginIP { get; set; }
        public DateTime User_Birthday { get; set; }
        public string User_Description { get; set; }
        public string User_ImageUrl { get; set; }
        public string User_School { get; set; }
        public string User_RegisterIP { get; set; }
        public DateTime User_RegisterTime { get; set; }
        public DateTime User_LastUpdateTime { get; set; }
        public string User_Weibo { get; set; }
        public string User_BloodType { get; set; }
        public string User_Says { get; set; }
        public string User_Lock { get; set; }
        public string User_Freeze { get; set; }
        public string User_Power { get; set; }
    }
}
