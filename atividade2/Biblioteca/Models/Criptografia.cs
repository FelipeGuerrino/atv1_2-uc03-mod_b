using System.Security.Cryptography;
using System.Text;

namespace Biblioteca.Models
{
    public class Criptografia
    {
        public static string Encriptar(string senha)
        {
            using(MD5 md5Hash = MD5.Create())
            {
                byte[] dado = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));

                StringBuilder sBuilder = new StringBuilder();

                for (int i = 0; i < dado.Length; i++)
                {
                    sBuilder.Append(dado[i].ToString("x2"));
                }

                return sBuilder.ToString();
            }
        }
    }
}