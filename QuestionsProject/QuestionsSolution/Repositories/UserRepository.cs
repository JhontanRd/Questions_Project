using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuestionsSolution.Data;
using QuestionsSolution.Models;
using QuestionsSolution.Repositories.IRepositories;

namespace QuestionsSolution.Repositories
{
    class UserRepository : IUserRepository
    {
        public void Insert(User user)
        {
            using var db = new AppDbContext();

            db.Users.Add(user);
            db.SaveChanges();
        }

        public bool RequestLoginAccess(User user)
        {
            using var db = new AppDbContext();

            return db.Users.Any(u => u.UserLogin == user.UserLogin && u.UserPassword == user.UserPassword);
        }


    }
}
