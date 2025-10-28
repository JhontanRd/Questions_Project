using Microsoft.VisualBasic.Logging;
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
        public bool ValidateLogin(string login)
        {
            if (string.IsNullOrEmpty(login))
            {
                return true;
            }
            if (string.IsNullOrWhiteSpace(login))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidatePassword(string password)
        {
            if (this.ValidateLogin(password))
            {
                return true;
            }
            if (password.Length < 8)
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
