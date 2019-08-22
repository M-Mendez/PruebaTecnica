using System;
using System.Security.Cryptography;
using System.Text;

namespace PruebaT.LogicaN
{
    public class tokenGenerate
    {
        private string getSha256(string valor)
        {
            SHA256 sha256 = SHA256Managed.Create();
            
            ASCIIEncoding encode = new ASCIIEncoding();
            
            byte[] stream = null;

            StringBuilder sb = new StringBuilder();

            stream = sha256.ComputeHash(encode.GetBytes(valor));

            for(int i = 0; i < stream.Length; i++)
            {
                sb.AppendFormat("{0:x2}", stream[i]);
            }

            return sb.ToString();
        }

        public string generarToken()
        {
            return getSha256(Guid.NewGuid().ToString());
        }

    }
}