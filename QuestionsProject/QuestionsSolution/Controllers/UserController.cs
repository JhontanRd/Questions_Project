using QuestionsSolution.Controllers.Exceptions;
using QuestionsSolution.Models;
using QuestionsSolution.Validators.IValidators;


namespace QuestionsSolution.Controllers
{
    class UserController
    {
        private IUserValidator _userValidator;

        public UserController(IUserValidator userValidator)
        {
            _userValidator = userValidator;
        }

        public void RequestLogin(User user)
        {
            if (_userValidator.ValidateLogin(user.UserLogin))
                throw new UserExceptions("Login inválido!");

            if (_userValidator.ValidatePassword(user.UserPassword))
                throw new UserExceptions("Senha inválida!");
        }
    }
}
