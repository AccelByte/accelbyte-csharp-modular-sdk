using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AccelByte.Sdk.Core
{
    public static class Stream_Extensions
    {
        public static string ReadToString(this Stream source)
        {
            using (var sr = new StreamReader(source))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
