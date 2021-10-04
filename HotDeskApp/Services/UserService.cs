using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotDeskApp.Repo;
using HotDeskApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HotDeskApp.Services
{
    public class UserService : IRepositoryUser<User>
    {
        private HotDeskDbContext db;

        public UserService(HotDeskDbContext _db)
        {
            this.db = _db;
        }

        public User FindUser(string Login)
        {
            return db.Users.Find(Login);
        }
    }
}
