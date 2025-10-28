using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuestionsSolution.Data;
using QuestionsSolution.Models;
using QuestionsSolution.Repositories.IRepositories;

namespace QuestionsSolution.Repositories
{
    class UserRepository : IUserRepository
    {
        public bool RequestLoginAccess(User user)
        {
            using var db = new AppDbContext();

            var clientLogin = db.Users.FirstOrDefault(u => u.UserLogin == user.UserLogin && u.UserPassword == user.UserPassword);
            if (clientLogin != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
