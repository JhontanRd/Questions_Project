using QuestionsSolution.Models;

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
            User user = new User(TxtUser.Text, TxtPassword.Text);
            // Criar a parte do controller
        }
    }
}
