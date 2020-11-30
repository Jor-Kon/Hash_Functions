using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashFunctions
{
    public class Hash
    {
        public static string MD5(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(new UTF8Encoding().GetBytes(input));
            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            Console.WriteLine(hash);
            return hash.ToString();
        }

        public static string SHA1(string input)
        {
            StringBuilder hash = new StringBuilder();
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] bytes = sha1.ComputeHash(new UTF8Encoding().GetBytes(input));
            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            Console.WriteLine(hash);
            return hash.ToString();
        }

        public static string SHA2(string input)
        {
            StringBuilder hash = new StringBuilder();
            SHA256CryptoServiceProvider sha2 = new SHA256CryptoServiceProvider();
            byte[] bytes = sha2.ComputeHash(new UTF8Encoding().GetBytes(input));
            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            Console.WriteLine(hash);
            return hash.ToString();
        }

        public static string SHA3(string input)
        {
            StringBuilder hash = new StringBuilder();
            SHA384CryptoServiceProvider sha3 = new SHA384CryptoServiceProvider();
            byte[] bytes = sha3.ComputeHash(new UTF8Encoding().GetBytes(input));
            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            Console.WriteLine(hash);
            return hash.ToString();
        }
    }
}
