using QuestionsSolution.Services;

namespace QuestionsSolution.Models
{
    public class User
    {
        private string _userPassword;
        public int UserId { get; private set; }
        public string UserLogin { get; private set; }
        public string Salt { get; private set; }

        public string UserPassword
        {
            get { return _userPassword; }
            private set
            {
                _userPassword = value;
            }
        }

        // Necessario para o EF funcionar
        protected User() { }

        public User(string userLogin, string userPassword)
        {
            UserLogin = userLogin;
            SetPassword(userPassword);
        }

        // Vou deixar esse metodo, se eu não precisar eu apago
        public override string ToString()
        {
            return "User created";
        }

        public void SetPassword(string plainPassword)
        {
            Salt = SaltGenerator.GetSalt();
            _userPassword = HashGenerator.GetHash(plainPassword + Salt);
        }

    }
}
