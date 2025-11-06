using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuestionsSolution.Data;
using QuestionsSolution.Models;
using QuestionsSolution.Repositories.IRepositories;
using QuestionsSolution.Services;

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

        public bool RequestLoginAccess(User user, string plainPassword)
        {
            using var db = new AppDbContext();

            var a = db.Users.Where(u => u.UserLogin == user.UserLogin).Select(u => new { u.UserPassword, u.Salt }).ToList();

            return (HashGenerator.GetHash(plainPassword + a[0].Salt) == a[0].UserPassword);
        }


    }
}
