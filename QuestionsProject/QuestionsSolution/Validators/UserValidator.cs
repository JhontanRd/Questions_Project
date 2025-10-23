using QuestionsSolution.Validators.IValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsSolution.Validators
{
    class UserValidator : IUserValidator
    {
        private IUserValidator _userValidator;

        public UserValidator(IUserValidator userValidator)
        {
            _userValidator = userValidator;
        }

        public bool ValidateLogin(string login)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrWhiteSpace(login))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
