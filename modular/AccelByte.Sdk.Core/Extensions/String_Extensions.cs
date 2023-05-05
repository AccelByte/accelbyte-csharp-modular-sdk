using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AccelByte.Sdk.Core
{
    public static class String_Extensions
    {
        public static byte[] DecodeBase64Url(this string source)
        {
            string temp = (source.Length % 4 == 0 ? source : source + "====".Substring(source.Length % 4))
                .Replace("_", "/").Replace("-", "+");
            return Convert.FromBase64String(temp);
        }

        public static string GenerateCodeChallenge(this string codeVerifier)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(codeVerifier));
                if (bytes != null)
                    return bytes.EncodeBase64Url();
                else
                    return "";
            }
        }
    }
}
