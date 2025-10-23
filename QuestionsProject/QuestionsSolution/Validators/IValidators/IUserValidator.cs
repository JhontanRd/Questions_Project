using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsSolution.Validators.IValidators
{
    interface IUserValidator
    {
        public bool ValidateLogin(string login);

    }
}
