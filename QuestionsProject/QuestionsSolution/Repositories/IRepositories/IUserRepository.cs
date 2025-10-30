using QuestionsSolution.Models;


namespace QuestionsSolution.Repositories.IRepositories
{
    interface IUserRepository
    {
        public bool RequestLoginAccess(User user);
        public void Insert(User user);
    }
}
