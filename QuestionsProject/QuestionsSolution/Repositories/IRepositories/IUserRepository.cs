using QuestionsSolution.Models;


namespace QuestionsSolution.Repositories.IRepositories
{
    interface IUserRepository
    {
        public bool RequestLoginAccess(User user);
    }
}
