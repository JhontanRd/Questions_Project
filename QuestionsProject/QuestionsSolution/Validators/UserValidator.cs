using QuestionsSolution.Validators.IValidators;

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
            else
            {
                return false;
            }
        }
    }
}
