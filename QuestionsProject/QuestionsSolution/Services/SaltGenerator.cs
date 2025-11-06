using System.Security.Cryptography;


namespace QuestionsSolution.Services
{
    public static class SaltGenerator
    {
        public static string GetSalt(int size = 16)
        {
            // Criação de um array para armazenar os bytes do salt a ser gerado
            byte[] saltBytes = new byte[size];

            // Criando o alrotimo para criar uma sequencia aleatoria para o salt
            using (var rng = RandomNumberGenerator.Create())
            {
                // Gerando o salt
                rng.GetBytes(saltBytes);
            }

            // Retorna o salt no formato de string
            return Convert.ToBase64String(saltBytes);
        }
    }
}
