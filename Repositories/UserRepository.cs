using System.Collections.Generic;
using System.Linq;
using JwtSimpleApp.Models;

namespace JwtSimpleApp.Repositories
{
    public static class UserRepository
    {
        public static User GetUser(string username, string password)
        {
            var users = new List<User>()
            {
                new User(){Id = 1, Name = "joao", Password = "senha", Role = "manager"},
                new User(){Id = 2, Name = "maria", Password = "senha", Role = "worker"}
            };

            return users.Where(x=>x.Name == username.ToLower() && x.Password == password.ToLower()).FirstOrDefault();
        }
    }
}