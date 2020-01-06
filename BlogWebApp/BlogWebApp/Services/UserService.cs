using BlogWebApp.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApp.Services
{
    public class UserService:CommonService
    {
        private readonly IMongoCollection<Users> _users;

        public UserService(IDatabaseSettings settings) : base(settings)
        {
            _users = _database.GetCollection<Users>(settings.UserCollectionName);
        }

        public List<Users> GetUsers()
        {
            return _users.Find(user => true).ToList();
        }
    }
}
