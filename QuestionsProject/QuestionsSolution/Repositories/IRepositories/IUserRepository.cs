using QuestionsSolution.Models;


namespace QuestionsSolution.Repositories.IRepositories
{
    interface IUserRepository
    {
        public bool RequestLoginAccess(User user, string plainPassword);
        public void Insert(User user);
    }
}
