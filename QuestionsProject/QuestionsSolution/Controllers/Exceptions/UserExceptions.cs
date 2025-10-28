using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsSolution.Controllers.Exceptions
{
    class UserExceptions : ApplicationException
    {
        public UserExceptions(string msg) : base(msg)  { }
    }
}
