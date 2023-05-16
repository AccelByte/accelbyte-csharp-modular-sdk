using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core
{
    public static class ByteArray_Extensions
    {
        public static string EncodeBase64Url(this byte[] data)
        {
            if (data == null)
                throw new ArgumentNullException("data");

            return Convert.ToBase64String(data).TrimEnd('=').Replace('+', '-').Replace('/', '_');
        }
    }
}
