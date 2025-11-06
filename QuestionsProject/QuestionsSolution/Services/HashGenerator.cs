using System.Security.Cryptography;
using System.Text;


namespace QuestionsSolution.Services
{
    public static class HashGenerator
    {
        public static string GetHash(string value)
        {
            // Aqui eu converto a string para bytes (UTF8)
            byte[] bytes = Encoding.UTF8.GetBytes(value);

            // Criar o algoritmo SHA256 que gera um hash de 64 caracteres hexadecimais
            using (SHA256 sha256 = SHA256.Create())
            {
                // Gerando o hash
                byte[] hashBytes = sha256.ComputeHash(bytes);

                // Converter e retorna o hash em string hexadecimal legível
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}
