// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Linq;
using System.Text;

namespace AccelByte.Sdk.Core.Util
{
    public static class Helper
    {
        public static string GenerateCodeVerifier()
        {
            var random = new Random();
            return random.GenerateCodeVerifier();
        }

        public static string GenerateCodeChallenge(string codeVerifier)
        {
            return codeVerifier.GenerateCodeChallenge();
        }

        public static string ConvertInputStreamToString(Stream @is)
        {
            return @is.ReadToString();
        }

        private static string EncodeBase64Url(byte[] data)
        {
            return data.EncodeBase64Url();
        }

        public static byte[] DecodeBase64Url(string source)
        {
            return source.DecodeBase64Url();
        }

        public static string GenerateRandomId(int length)
        {
            Random random = new Random();
            return random.GenerateRandomId(length);
        }

        private static string RandomizeChar(Random random, string source, int length)
        {
            return random.RandomizeChar(source, length);
        }

        public static string GenerateRandomPassword(int length)
        {
            Random random = new Random();
            return random.GenerateRandomPassword(length);
        }
    }
}