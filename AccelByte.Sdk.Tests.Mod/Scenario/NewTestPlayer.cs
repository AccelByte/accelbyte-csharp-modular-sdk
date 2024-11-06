// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Tests.Mod.Scenario
{
    public class NewTestPlayer : ITestPlayer
    {
        private string _UserName = String.Empty;

        private readonly bool _DeleteOnLogout;

        private readonly DefaultTokenRepository _TokenRepo;

        private readonly IAccelByteSdk _SdkClient;

        private readonly IAccelByteSdk _Sdk;

        public string AccessToken
        {
            get => _TokenRepo.Token;
        }

        public string UserId { get; private set; } = String.Empty;

        public static string GenerateRandomNumber(int length)
        {
            Random random = new Random();
            string chars = "0123456789";
            return new String(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string GenerateRandomAlphabet(int length)
        {
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new String(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// Create an ITestPlayer object by creating a new user via IAM.
        /// </summary>
        /// <param name="sdkClient">AccelByteSDK object with necessary access and permission to create a user.</param>
        /// <param name="deleteOnLogout">Set true to delete the created user on logout.</param>
        public NewTestPlayer(IAccelByteSdk sdkClient, bool deleteOnLogout)
        {
            _DeleteOnLogout = deleteOnLogout;
            _SdkClient = sdkClient;

            Random random = new Random();

            _UserName = ("csharpsdk_" + random.GenerateRandomId(4));
            string user_password = random.GenerateRandomPassword(10);
            string user_email = $"{_UserName}@dummy.com";

            AccountCreateUserRequestV4 newUser = new AccountCreateUserRequestV4()
            {
                AuthType = "EMAILPASSWD",
                EmailAddress = user_email,
                Password = user_password,
                DisplayName = $"SDK_{GenerateRandomAlphabet(8)}".ToLower(),
                Username = _UserName,
                Country = "ID",
                DateOfBirth = "1995-01-10"
            };

            AccountCreateUserResponseV4 cuResp = sdkClient.GetIamApi().UsersV4.PublicCreateUserV4Op
                .Execute(newUser, sdkClient.Namespace)
                .Ok();
            UserId = cuResp.UserId!;

            _TokenRepo = new DefaultTokenRepository();
            _Sdk = AccelByteSdk.Builder
                .UseDefaultConfigRepository()
                .UseDefaultHttpClient()
                .SetTokenRepository(_TokenRepo)
                .Build();

            _Sdk.LoginUser(_UserName, user_password);
        }

        public void Login() { }

        public void Logout()
        {
            _Sdk.Logout();
            if (_DeleteOnLogout)
            {
                _SdkClient.GetIamApi().Users.AdminDeleteUserInformationV3Op
                    .Execute(_SdkClient.Namespace, UserId)
                    .Ok();
            }   
        }

        public void Run(Action<IAccelByteSdk, ITestPlayer> action)
        {
            action.Invoke(_Sdk, this);
        }
    }
}