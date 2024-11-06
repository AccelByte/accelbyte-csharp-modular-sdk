// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core
{
    public sealed class ApiError
    {
        public static readonly ApiError Empty = new ApiError("", "");

        public string Code { get; }

        public string Message { get; }

        public bool IsAvailable { get; }

        public ApiError(string code,string message)
        {
            Code = code;
            Message = message;
            IsAvailable = Code != "";
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            if (obj is ApiError)
                return Code.Equals(((ApiError)obj).Code);
            else
                return false;
        }

        public Exception ThrowException()
        {
            return new Exception($"Code: {Code}, Message: {Message}");
        }

        #region Operator Overloading
        public static bool operator ==(ApiError left, ApiError right)
        {
            if (left is null)
                return (right is null);
            return left.Code == right.Code;
        }

        public static bool operator !=(ApiError left, ApiError right)
        {
            return left.Code != right.Code;
        }

        public static bool operator ==(ApiError left, string right)
        {
            return left.Code == right;
        }

        public static bool operator !=(ApiError left, string right)
        {
            return left.Code != right;
        }

        public static bool operator ==(string left, ApiError right)
        {
            return left == right.Code;
        }

        public static bool operator !=(string left, ApiError right)
        {
            return left != right.Code;
        }
        #endregion
    }
}
