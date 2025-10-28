namespace QuestionsSolution.Validators.IValidators
{
    interface IUserValidator
    {
        public bool ValidateLogin(string login);
        public bool ValidatePassword(string password);

    }
}
