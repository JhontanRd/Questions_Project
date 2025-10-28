using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsSolution.Models
{
    class User
    {
        public int UserId { get; private set; }
        public string UserLogin { get; private set; }
        public string UserPassword { get; private set; }

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
