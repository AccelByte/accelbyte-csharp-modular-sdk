// Copyright (c) 2023-2025 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core
{
    public static class Random_Extensions
    {
        public static string GenerateCodeVerifier(this Random random)
        {
            var codeVerifier = new byte[32];
            random.NextBytes(codeVerifier);
            return codeVerifier.EncodeBase64Url();
        }

        public static string GenerateCodeVerifier(this RandomNumberGenerator random)
        {
            var codeVerifier = new byte[32];
            random.GetBytes(codeVerifier);
            return codeVerifier.EncodeBase64Url();
        }

        public static string GenerateRandomId(this Random random, int length)
        {
            string chars = "abcdefghijklmnopqrstuvw0123456789";
            return new String(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string GenerateRandomAlphabet(this Random random, int length)
        {
            string chars = "abcdefghijklmnopqrstuvwxyz";
            return new String(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomizeChar(this Random random, string source, int length)
        {
            string result = "";
            for (int i = 0; i < length; i++)
            {
                char temp = source[random.Next(source.Length)];
                while (true)
                {
                    if (result.IndexOf(temp) > -1)
                        temp = source[random.Next(source.Length)];
                    else
                    {
                        result += temp.ToString();
                        break;
                    }
                }
            }
            return result;
        }

        public static string RandomizeChar(string source, int length)
        {
            string result = "";
            for (int i = 0; i < length; i++)
            {
                char temp = source[RandomNumberGenerator.GetInt32(source.Length)];
                while (true)
                {
                    if (result.IndexOf(temp) > -1)
                        temp = source[RandomNumberGenerator.GetInt32(source.Length)];
                    else
                    {
                        result += temp.ToString();
                        break;
                    }
                }
            }
            return result;
        }

        public static string GenerateRandomPassword(this Random random, int length)
        {
            string final = "";
            int pCount = (length / 3);

            final += RandomizeChar("ABCDEFGHIJKLMNOPQRSTUVWXYZ", pCount);
            final += RandomizeChar("abcdefghijklmnopqrstuvwxyz", pCount);

            int fCount = (length - (pCount * 2));
            final += RandomizeChar("0123456789!@#$%^&*()", fCount);

            return final;
        }
    }
}
