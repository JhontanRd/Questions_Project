using QuestionsSolution.Controllers.Exceptions;
using QuestionsSolution.Models;
using QuestionsSolution.Repositories.IRepositories;
using QuestionsSolution.Validators.IValidators;


namespace QuestionsSolution.Controllers
{
    class UserController
    {
        private IUserValidator _userValidator;
        private IUserRepository _userRepository;

        public UserController(IUserValidator userValidator, IUserRepository userRepository)
        {
            _userValidator = userValidator;
            _userRepository = userRepository;
        }

        public void RequestLogin(User user)
        {
            if (_userValidator.ValidateLogin(user.UserLogin))
                throw new UserExceptions("Login inválido!");

            if (_userValidator.ValidatePassword(user.UserPassword))
                throw new UserExceptions("Senha inválida!");

            if (!_userRepository.RequestLoginAccess(user))
                throw new UserExceptions("Acesso negado, informe um login válido");
        }
        
        public void RegisterRequest(User user)
        {
            if (_userValidator.ValidateLogin(user.UserLogin))
                throw new UserExceptions("Login inválido!");

            if (_userValidator.ValidatePassword(user.UserPassword))
                throw new UserExceptions("Senha inválida!");

            _userRepository.Insert(user);
                
        }
    }
}
