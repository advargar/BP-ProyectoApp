using System.Security.Cryptography;
using System.Text;

namespace BP_Proyecto.Services
{
    public class Utility
    {
        public static string EncriptPassword(string password)
        {
            StringBuilder sb = new StringBuilder();

            using (SHA256 hash = SHA256.Create())
            { 
                Encoding encoding = Encoding.UTF8;

                byte[] result = hash.ComputeHash(encoding.GetBytes(password));
                foreach(byte b in result)
                {
                    sb.Append(b.ToString("x2"));
                }
            }
            return sb.ToString();
        }
    }
}
