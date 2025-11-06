using QuestionsSolution.Services;

namespace QuestionsSolution.Models
{
    class User
    {
        private string _userPassword;
        public int UserId { get; private set; }
        public string UserLogin { get; private set; }

        public string UserPassword
        {
            get { return _userPassword; }
            set
            {
                _userPassword = HashGenerator.GetHash(value);
            }
        }

        public User(string userLogin, string userPassword)
        {
            UserLogin = userLogin;
            UserPassword = userPassword;
        }

        // Vou deixar esse metodo, se eu não precisar eu apago
        public override string ToString()
        {
            return "User created";
        }

    }
}
