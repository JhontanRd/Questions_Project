using QuestionsSolution.Controllers;
using QuestionsSolution.Controllers.Exceptions;
using QuestionsSolution.Models;
using QuestionsSolution.Repositories;
using QuestionsSolution.Validators;

namespace QuestionsSolution
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void BtnAccess_Click_1(object sender, EventArgs e)
        {
            UserController userController = new UserController(new UserValidator(), new UserRepository());
            User user = new User(TxtUser.Text, TxtPassword.Text);
            try
            {
                userController.RequestLogin(user);
                MessageBox.Show("Success", "Login funcionou");
            }
            catch (UserExceptions uX)
            {
                MessageBox.Show(uX.Message, "Erro na operação ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController(new UserValidator(), new UserRepository());
            User user = new User(TxtUser.Text, TxtPassword.Text);
            try
            {
                userController.RegisterRequest(user);
                MessageBox.Show("Success", "Usuario criado");
            }
            catch (UserExceptions uX)
            {
                MessageBox.Show(uX.Message, "Erro na operação ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
